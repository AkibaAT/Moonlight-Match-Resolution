using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Magic.Samples.DisplaySettings
{
    /// <summary>
    /// The start-up form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Encapsulates the display settings. Initialized by the constructor of the form.
        /// </summary>
        private readonly DisplaySettings _originalSettings;
        private delegate void SafeCallDelegate();

        /// <summary>
        /// Initializes a new instance of MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.Text = Application.ProductName;
            _originalSettings = DisplayManager.GetCurrentSettings();
            Thread thread = new Thread(() => ReadAndFollow(@"C:\ProgramData\NVIDIA Corporation\NvStream\NvStreamerCurrent.log"));
            thread.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            GetCurrentSettings();

            ListAllModes();

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Loads current display settings and refreshes the current settings labels.
        /// </summary>
        protected void GetCurrentSettings()
        {
            if (this.widthLabel.InvokeRequired)
            {
                var d = new SafeCallDelegate(GetCurrentSettings);
                Invoke(d);
            }
            else
            {
                DisplaySettings set = DisplayManager.GetCurrentSettings();

                this.widthLabel.Text = set.Width.ToString(CultureInfo.InvariantCulture);
                this.heightLabel.Text = set.Height.ToString(CultureInfo.InvariantCulture);
                this.orientationLabel.Text = ((int)set.Orientation * 90).ToString(CultureInfo.InvariantCulture);
                this.bitsLabel.Text = set.BitCount.ToString(CultureInfo.InvariantCulture);
                this.freqLabel.Text = set.Frequency.ToString(CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Loads all supported display modes and lists them in the modes list view.
        /// </summary>
        protected void ListAllModes()
        {
            this.modesListView.BeginUpdate();
            this.modesListView.Items.Clear();

            IEnumerator<DisplaySettings> enumerator = DisplayManager.GetModesEnumerator();

            DisplaySettings set;
            ListViewItem itm;

            while (enumerator.MoveNext())
            {
                set = enumerator.Current;
                itm = new ListViewItem(set.Index.ToString(CultureInfo.InvariantCulture));
                itm.SubItems.Add(set.Width.ToString(CultureInfo.InvariantCulture));
                itm.SubItems.Add(set.Height.ToString(CultureInfo.InvariantCulture));
                itm.SubItems.Add(((int)set.Orientation * 90).ToString(CultureInfo.InvariantCulture));
                itm.SubItems.Add(set.BitCount.ToString(CultureInfo.InvariantCulture));
                itm.SubItems.Add(set.Frequency.ToString(CultureInfo.InvariantCulture));
                itm.Tag = set;
                this.modesListView.Items.Add(itm);
            }

            this.modesListView.EndUpdate();
        }

        private void rotateClockwiseButton_Click(object sender, EventArgs e)
        {
            DisplayManager.RotateScreen(true);
            GetCurrentSettings();
            ListAllModes();
        }

        private void rotateAntiClockwiseButton_Click(object sender, EventArgs e)
        {
            DisplayManager.RotateScreen(false);
            GetCurrentSettings();
            ListAllModes();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisplayManager.SetDisplaySettings(_originalSettings);
        }

        private void modesListView_DoubleClick(object sender, EventArgs e)
        {
            if (this.modesListView.SelectedItems.Count == 0) return;


            DisplaySettings set = (DisplaySettings)this.modesListView.SelectedItems[0].Tag;

            DisplayManager.SetDisplaySettings(set);

            GetCurrentSettings();
            ListAllModes();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DisplayManager.SetDisplaySettings(_originalSettings);
            GetCurrentSettings();
            ListAllModes();
        }

        public void ReadAndFollow(string filename)
        {
            using (StreamReader reader = new StreamReader(new FileStream(filename,
                     FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                // start at the start of the file
                long lastMaxOffset = 0;

                while (true)
                {
                    Thread.Sleep(500);

                    //if the file size has not changed, idle
                    if (reader.BaseStream.Length == lastMaxOffset)
                        continue;

                    //seek to the last max offset
                    reader.BaseStream.Seek(lastMaxOffset, SeekOrigin.Begin);

                    //read out of the file until the EOF
                    bool updateResolution = false;
                    string line;
                    int width = 0;
                    int height = 0;
                    int refresh = 0;
                    bool useHdr = false;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("clientViewport"))
                        {
                            Console.WriteLine(line);
                            string[] subs = line.Split(':');
                            if (subs.Length >= 2)
                            {
                                updateResolution = true;
                                if (subs[subs.Length - 2].Contains("clientViewportWd"))
                                {
                                    width = int.Parse(subs[subs.Length - 1].Trim());
                                } 
                                else
                                {
                                    height = int.Parse(subs[subs.Length - 1].Trim());
                                }
                            }
                        }
                        if (line.Contains("maxFPS"))
                        {
                            Console.WriteLine(line);
                            string[] subs = line.Split(':');
                            if (subs.Length >= 2)
                            {
                                updateResolution = true;
                                refresh = int.Parse(subs[subs.Length - 1].Trim());
                            }
                        }
                        if (line.Contains("dynamicRangeMode"))
                        {
                            Console.WriteLine(line);
                            string[] subs = line.Split(':');
                            if (subs.Length >= 2)
                            {
                                updateResolution = true;
                                useHdr = bool.Parse(subs[subs.Length - 1].Trim());
                            }
                        }
                    }

                    if (updateResolution)
                    {
                        IEnumerator<DisplaySettings> enumerator = DisplayManager.GetModesEnumerator();

                        DisplaySettings set;
                        DisplaySettings bestSet = DisplayManager.GetCurrentSettings();

                        while (enumerator.MoveNext())
                        {
                            set = enumerator.Current;
                            if (set.Width == width && set.Height == height)
                            {
                                if (bestSet.Width != set.Width || bestSet.Height != set.Height || set.Frequency > bestSet.Frequency)
                                {
                                    bestSet = set;
                                }
                            }
                        }
                        DisplayManager.SetDisplaySettings(bestSet);
                        GetCurrentSettings();
                    }

                    // update the last max offset
                    lastMaxOffset = reader.BaseStream.Position;
                }
            }
        }
    }
}