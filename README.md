# NeoModsX
[![GitHub Latest Release](https://img.shields.io/github/release/ohhsodead/NeoModsX.svg)](https://github.com/ohhsodead/NeoModsX/releases/) [![GitHub Downloads](https://img.shields.io/github/downloads/ohhsodead/NeoModsX/total.svg)](https://github.com/ohhsodead/NeoModsX/releases/) [![GitHub Open Issues](https://img.shields.io/github/issues/ohhsodead/NeoModsX.svg)](https://gitHub.com/ohhsodead/NeoModsX/issues/) [![GitHub Closed Issues](https://img.shields.io/github/issues-closed/ohhsodead/NeoModsX.svg)](https://github.com/ohhsodead/NeoModsX/issues?q=is%3Aissue+is%3Aclosed) [![Join our Discord](https://img.shields.io/badge/chat%20on-discord-7289DA)](https://discord.gg/FTCS3Xu)

An open source desktop application designed to easily browse through a regularly updated database of mods, game saves, homebrew, resources, themes and much more for PlayStation 3 and Xbox 360. A library that is populated by myself, few friends and awesome contributors, so that all mods have been tested and verified. NeoModsX also acts as an FTP client to be able to install and uninstall directly to your console. Without the need for digging up old threads or using file managers - this aims to do everything for you.

**the only one of its kind...**

![Main Form](https://raw.githubusercontent.com/ohhsodead/NeoModsX/master/.screenshots/demo/MainForm.png?raw=true)

**Comments, ideas, suggestions?** Come chat with us in the [Discord Server](https://discord.gg/FTCS3Xu)!

Please give this project a ⭐ if you find it useful.

## Main Features

* Fast, lightweight and simple to use
* Beautiful and simple design layout
* Browse a large database of PS3 & Xbox 360 mods
* Complete with details, creator, version, etc.
* Filter by console type, mod type and region
* Download the mods to your computer
* Install and uninstall mods directly to your console
* Automatically detect and remember game regions
* Manage your downloads and installed mods
* Backup and restore original game files
* Create and add mods to your own lists
* Includes a built-in Game Updates Finder
* Includes a built-in File Manager
* Includes a built-in Package Manager
* Includes webMAN/XBDM commands (Reboot, Shutdown, etc.)

## Requirements

* An Internet Connection on your PC & Console (optional)
* NET Framework 4.8 (Download the official [here](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-web-installer))
* PlayStation 3 (with webMAN, multiMAN or Rebug Toolbox) OR
* Xbox 360 RGH/JTAG (with DashLaunch & Xbdm.xex as Plugin #1)

## Installation

### Windows

Download and run the latest version of the Windows installer, "NeoModsX.Installer.Windows.exe" from the [releases](https://github.com/ohhsodead/NeoModsX/releases/latest) page.

## Quick Guide

### Getting Started

Browsing our huge library of mods can't be easier. On the left side menu, you have a list of categories from games, apps to resources. Select an item to view the mods for each category. You can then search mods by name, system type, mod type and game region. Once you've found one you like, select it from the list and the details will be displayed on the right side, everything you need to know is there. I suggest that you make sure your console type and game region is the same as yours, and reading the description before installing any mods.

### Connecting

You will need to make sure your computer and console are connected to the same network before installing any mods.

If you want to install mods to your console, then first you need to create your console profile. Go to Options > Settings and click 'Add New Console'. A dialog will appear, here you will need to enter the following details:
* Connection Name (can be anything you like)
* Console Type (is the type of console you're using)
* Console Address (this is the IP address of the console, for PS3 this will be in **System Information** and for XBOX it's in **Configure Network** menu)
* Port (by default the port for PS3 is 21 and XBOX is 730)
* Login (by default the username/password are usually 'anonymous' for PS3, and for XBOX usually 'xbox', but these can be changed to your own).

Once you've entered all the details, click **OK** and they will be saved to your settings. If you have more than one console then just do the same.

Before connecting, make sure you have one of the following open (if you're on PS3):
* Rebug Toolbox
* webMAN
* multiMAN

Now you're ready to connect to your console. Go to Connect > PS3/XBOX > Connect to console. Choose your console profile and click **Connect**. Done!

### Installing Mods

After finding some mods you like, connect to your console and go to the mods information. Click **Install** and all of the files will be installed to your console. You may be prompted to backup any game files that are being overwritten, this is recommended to do. See the next section for more details.

### Uninstalling Mods

Want to remove the mods? Find the one you installed and click **Uninstall** and the files will be removed. If you have a backup of a game file then the modded file will be replaced with the backup, otherwise it will be ignored to prevent issues with the game working. So, I suggest to always backup your game files when you're prompted. If you didn't backup files, you will need to re-install the game update.

## Contributing

You're also welcome to submit any pull requests with fixes and suggestions, like additional features for making this project even more great. Please open an issue so we can discuss things before going further, maybe we can work on this together!

## Requesting Mods

I know that not all mods aren't on our database, but if you open an issue with the details then we can get them added for you!

## Credits & Libraries

* Appropriate Creators of all Mods
* [AutoUpdater.NET](https://github.com/ravibpatel/AutoUpdater.NET)
* [DevExpress](https://devexpress.com/)
* [Humanizer](https://github.com/Humanizr/Humanizer)
* [Newtonsoft.Json](https://newtonsoft.com/json)
* [NLog](https://nlog-project.org/)
* [ProfanityDetector](https://github.com/stephenhaunts/ProfanityDetector/)
* [WebMAN API](https://github.com/FxckingCoder/WebmanAPI)
* [XDevkit](https://microsoft.com/)

## Contributors

* [Doregon](https://github.com/Doregon)
* [KayGart](https://github.com/KayGart)
* [TeddyHammer](https://github.com/TeddyHammer)

## Disclaimer

I can accept no responsibility for any damage you cause to your system by using this tool.

## License

This project is released under the GNU General Public License v3.
