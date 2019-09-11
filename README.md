<h1 align="center">ModioX</h1>

<h3 align="center">Browse, Download and Install Mods to the PlayStation 3</h3>
<div align="center">
</div>
<br />

A federated desktop application for browsing a regularly updated collection of mods, homebrew and themes, populated by myself and a few friends so that almost all of them have been tested and verified to work. The core purpose is to provide users with an efficient method for browsing, downloading and installing game mods directly to their console, without the need for searching modding forums or using file managers - this does it all for you.

![ModioX](https://github.com/wh1ter0se-x/ModioX/blob/master/Images/Screenshot1.png?raw=true) 

## Features
* Browse major and popular games and categories
* Discover hundreds of game mods, apps and resources
* Complete details, creator, version and other info
* Filter database by firmware and type
* Supports every type of mods and files
* Download archives to computer
* Install mod files directly to console
* Uninstall mod files from console
* Automatically detect game region, or manually
* Built-in ftp client features, with directory listings 
* Add and save multiple console addresses

## Usage

### Requirements
* An internet connection
* .NET Framework 4.6.2
* PlayStation 3 with CFW

### Getting Started
In the upper left corner under **Settings** > **Edit Consoles** is where you can add and save your console. Your address can be found under **System Information**.

### Connecting to Console
Either select your console from the dropdown menu or type it manually in the textbox, then hit the **Connect** button.

Note: This is only testing a connection to the address so that it ensures you're able to upload files. 

### Browsing Mods
Finding mods is extremely simple too. Start by choosing something from the long list of titles/categories that are displayed on the left.

All the mods that are available will be loaded into the gridview, including information such as the name, version, creator, etc. 

Further details that you'll need to know will be displayed on the right side when selecting an item, including the firmware, configuration, description and more. 

### Installing Mods
Before install any files, make sure that your console is either at the XMB menu or with Rebug Toolbox open. It could cause issues such as console freezing or crashing. 

A compressed archive containing the modded files and a set of installation paths are included by default with each, so the **Install** process will be to the appropriate paths to work as instructed/intended.

### Uninstalling Mods
The **Uninstall** option is still being worked on to allow for original files to be backed up. But for now it will remove the specified installation files. Ones that are installed into your game folders are not deleted as it could cause issues with playing the game, these can include the _EBOOT.BIN_, _patch_mp.ff_, etc. You may be able to find the original/default files from the database, install those after uninstalling the game mods. 

### Downloading Mods
You're also able to **Download** the compressed archive to somewhere on your computer. Ideal for sending to friends or installing files manually.

### Reporting
It's encouraged to submit reports of any issues that may occur with mods or files, whether that's ingame problems or installing errors. It will be looked into by someone, for sure. 

### Console File Explorer
There's also included a simple ftp client that allows you to easily navigate both computer and console file systems. Go through your folders to choose the desired file, do the same to your console folders to where you'd like to upload the file then hit **Upload**, otherwise you can download or delete files from your console.

## Installation
Download and run the latest version of the Windows installer, "ModioX.Installer.Windows.exe" from the [releases](https://github.com/wh1ter0se-x/ModioX/releases/latest) page.

## Contributing
Please supply as much information about the problem you are experiencing as possible. Your issue has a much greater chance of being resolved if logs are supplied so that we can see what is going on, which will be found the application startup directory. You're also welcome to submit any pull requests with fixes and suggestions, like additional features for making this project even more great. But, please open an issue so we can discuss things before going further so maybe we can work on this together!

## Requesting Mods
I understand that currently not all mods will be available yet, so I'd welcome you to please use the **Request Mods** to open an issue with the details.

## Credits / Libraries
- Appropriate Authors of the Mods
- DarkUI for WinForms
- Newtonsoft.Json

## Disclaimer
I can accept no responsibility for any damage you cause to your system by using this tool. Follow the instructions so you shouldn't have any issues.
