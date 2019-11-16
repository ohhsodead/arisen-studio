<h1 align="left">ModioX</h1>

An open source desktop application designed to easily browse through a regularly updated library of game mods, homebrew, themes and more for the PlayStation 3. Populated by myself, few friends and awesome contributors, meaning they have been teated and verified to work. It also utilizes the ftp client, which allows for being able to install and uninstall modded files directly to games using a set of installation paths which are included with all mods, without the need for digging up old threads or using file managers - this aims to do everything for you. 

![ModioX](https://github.com/ohhsoash/ModioX/blob/master/Screenshots/Screenshot1.png?raw=true) 

## Features
* Fast, lightweight and simple to use
* Access a huge database of mods
* Complete with info, creator, version, etc.
* Sorted into games and categories
* Filter by firmware and mod type
* Download archives to your computer
* Install modded files directly to games
* Detect game region, or manually chosen
* Backup and restore original game files
* Directory listings with download, delete, etc.
* Save multiple console profiles

## Usage

### Requirements
* NET Framework 4.6.2
* PlayStation 3 with MFW

### Getting Started
Firstly, you can add your console by going to _Settings_ > _Edit Consoles_ which opens the profiles window. Your address can be found under **System Information** on the console. Just hit *Connect* once you're ready to install mods. 

### Installing Mods
It's important to note that before installing any files, ensure that the console is either at the xmb screen or with Rebug Toolbox open (and to be safe, not connected to psn).

A compressed archive containing the necessary modded files and a set of install file paths are included by default with each mods, so the installation process will be done at the appropriate directories in order for the mods to work as instructed/intended.

### Uninstalling Mods
I would suggest that you backup the original game files using our backup manager before installing mods, in the case that mods fail to work or you want to uninstall then you can revert as normal.

If there are game file backups, those will be restored to the game directory. Otherwise, game files will be ignored, but any other files will be removed.

### Reporting Mods
It's encouraged to submit reports of any issues that may occur with mods or files, but could either be due to incompatible firmware or game region. 

## Installation
Download and run the latest version of the Windows installer, "ModioX.Installer.Windows.exe" from the [releases](https://github.com/ohhsoash/ModioX/releases/latest) page.

## Contributing
You're also welcome to submit any pull requests with fixes and suggestions, like additional features for making this project even more great. Please open an issue so we can discuss things before going further so maybe we can work on this together!

## Requesting Mods
I understand that currently not all mods known will be available, so I welcome you to please use the **Request Mods** to open an issue with the details and they will be submitted by someone on your behalf.

## Credits / Libraries
- Appropriate Authors of all Mods
- [DarkUI for Winforms](https://github.com/RobinPerris/DarkUI)
- [Newtonsoft.Json](https://www.newtonsoft.com/json)
- [Apache log4net](https://logging.apache.org/log4net/)

## Disclaimer
I can accept no responsibility for any damage you cause to your system by using this tool. Follow the instructions so you shouldn't have any issues.
