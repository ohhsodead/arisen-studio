<h1 align="left">ModioX</h1>

An open source desktop application designed to easily browse through a regularly updated database of game mods, homebrew, themes and more for the PlayStation 3. A library that is populated by myself, few friends and awesome contributors, so they have all been teated and verified to work. It also utilizes the ftp client for allowing to install and uninstall modded files directly to games. Without the need for digging up old threads or using file managers - this aims to do everything for you. 

![ModioX](https://github.com/ohhsoash/ModioX/blob/master/Screenshots/Screenshot1.png?raw=true) 

## Features
* Fast, lightweight and simple to use
* Browse a large database of ps3 mods
* Complete with info, creator, version, etc.
* Filter by firmware and mod type
* Download archives to your computer
* Install and uninstall any files to console
* Automatic game region detection
* Backup and restore original game files
* Directory listings with basic commands
* Save multiple console profiles

## Usage

### Requirements
* An internet connection
* NET Framework 4.6.2
* PlayStation 3 with MFW

### Getting Started
Firstly, you can add your console by going to _Settings_ > _Edit Consoles_ to open the profiles window. Your address can be found under **System Information** on the console. Just hit *Connect* once you're ready to install mods. 

### Installing Mods
It's important to note that before installing any files, ensure that the console is either at the xmb screen or with Rebug Toolbox open (and to be safe, not connected to psn).

A compressed archive containing the required modded files (some optional) and a set of installation file paths are included. So the installation process will be done at the appropriate directories for the mods to work as instructed/intended by the creators.

### Uninstalling Mods
I would suggest that you backup your original game files before installing mods, then you can revert to normal state by uninstalling the modded files.

If game file backups have been created then those will be restored to the game directory and all other installed files will be removed too. Otherwise, game files will be ignored.

### Reporting Mods
It's encouraged to submit reports of any issues that may occur with mods or files, but could either be due to incompatible firmware or game region. 

## Installation
Download and run the latest version of the Windows installer, "ModioX.Installer.Windows.exe" from the [releases](https://github.com/ohhsoash/ModioX/releases/latest) page.

## Contributing
You're also welcome to submit any pull requests with fixes and suggestions, like additional features for making this project even more great. Please open an issue so we can discuss things before going further so maybe we can work on this together!

## Requesting Mods
I understand that not every mod is available, so I welcome you to please use the **Request Mods** to open an issue with the details and they will be submitted to our database.

## Credits / Libraries
- Appropriate Authors of all Mods
- [DarkUI for Winforms](https://github.com/RobinPerris/DarkUI)
- [Newtonsoft.Json](https://www.newtonsoft.com/json)
- [Apache log4net](https://logging.apache.org/log4net/)

## Disclaimer
I can accept no responsibility for any damage you cause to your system by using this tool. Follow the instructions so you shouldn't have any issues.
