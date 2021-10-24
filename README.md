# Moonlight Match Resolution

## What It Does
I wanted to use Moonlight to access my Desktop, while also automatically setting a suitable resolution for use on my tablet.
[cgarst/gamestream_launchpad](https://github.com/cgarst/gamestream_launchpad) sort of did what I wanted, but only allows for setting a static resolution via a config file. So if you use different client devices with different aspect ratios, this is not the most elegant solution to use.

What my solution does different, is it watches the GeForce Experience streaming log file, located at "C:\ProgramData\NVIDIA Corporation\NvStream\NvStreamerCurrent.log", to automatically set the matching display resolution.
All information, like stream resolution, frame rate, HDR settings, etc. are being logged to that file, which the resolution changer app reads to get the information it needs.

## Setup / How To Use
* Download the exe from the [release list](https://github.com/Rejaku/Moonlight-Match-Resolution/releases) somewhere you want to keep it.
* Open GeForce Experience > Settings > Shield > Add Game:  
![image](https://user-images.githubusercontent.com/758840/138605177-37c39fc8-1526-4d67-bb4f-3a88f80b34eb.png)
* Click on Add and select the downloaded exe:  
![image](https://user-images.githubusercontent.com/758840/138605203-2065d7e0-bf5e-49e8-8623-77ff21d7847d.png)
* You can rename the new entry however you like after adding it:  
![image](https://user-images.githubusercontent.com/758840/138605231-fc694590-a680-43a5-bc78-2e46bf891a8e.png)
* Now, launch the Moonlight client on any device, connect to the host machine, and you will have a new entry:  
![image](https://user-images.githubusercontent.com/758840/138605269-b39dd9b9-e68d-44df-a8f5-ed28468bccc2.png)
* Click on the new entry, which will launch the resolution changer on the host, and set the resolution to match the stream resolution:  
![image](https://user-images.githubusercontent.com/758840/138605294-ac63b240-74c2-4f01-87de-df4ee6b14ce7.png)
That's it. While the program is open, it will watch for changes in the requested stream resolution. So if you go back in the Moonlight client, and change your desired stream resolution, and then reconnect again, the screen resolution will automatically be update.

## Future Plans
* Add HDR support - Setting the HDR mode of a monitor looks to be a complicated procedure, so that will require some research.
* Clean up the code - Right now, the functionality is hacked into the form logic. It works, but it's not clean code.
