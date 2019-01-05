<h1 align="center">
  <img src="/AIO Loader/Resources/AIO-Loader.png" width="381" height="55" alt="Logo" />
  <br />

</h1>

<h3 align="center">Server-driven application for uploading mods to your PS3</h3>
<div align="center">
</div>
<br />

## What is AIO Loader?
I created an All-In-One Loader for my own personal use, I thought the community could do with something like this so I decided to release. This application is designed to bring all types of mods into one database, idealy to decrease the hassle of needing to open your FTP-client to upload/test mods every so often.

[![Report a bug](http://i.imgur.com/xSpw482.png)](https://github.com/HerbL27/AIO-Loader/issues/new) [![Feature Requests](http://i.imgur.com/mFO0OuX.png)](http://feathub.com/HerbL27/AIO-Loader)

## Current Features:
* Very easy to use, step-by-step basis
* Test connection to your console
* Supports consoles running CFW DEX only
* Upload files/mods to your console
* Popular games supported: CoD's, GTA 4/5 & BF4
* Supports all game regions folders
* Upload custom files
* Supports formatting installation path
* Create and edit console profiles

## Latest Build
AIO Loader - 1.2

## Supported Systems
* Windows XP and above (Windows XP, Vista, 7, 8, 8.1, 10) using .NET 4.7.1 [Download here](https://www.microsoft.com/net/download/dotnet-framework-runtime/net471).

## Installation
Download and run the latest version of the Windows installer, "AIOLoader.Installer.Windows.exe" from the [releases](https://github.com/HerbL27/AIO-Loader/releases/latest) page.

## Creating an Issue
Please supply as much information about the problem you are experiencing as possible. Your issue has a much greater chance of being resolved if logs are supplied so that we can see what is going on, which will be found in your application's installation path.

## Contributing Mods & Code
If you'd like support for new mods then feel free to open a request on the [issues page](https://github.com/HerbL27/AIO-Loader/issues). Please upload a compressed archive (ZIP/RAR) containing the files for the mods to work and also a configuration file for their installation paths. See below for an example.

### Mods Folder
This will contain the files that make up the mod, all file extensions are supported. There should also be the *config.txt* file that will include the installation/upload paths, and while the *readme.txt* file isn't required it would be useful to know some more information about the mods, such as creators/credits, version, etc. so try to include this if possible.

```
.
├── ...
├── 'Mods Name'            # Containing mods files (required)
│   ├── EBOOT.bin          # Modded EBOOT.bin file (must be DEX - any region) (optional)
│   ├── update.rpf         # Modded update.rpf file (optional)
│   ├── mod_file.sprx      # Maybe a SPRX file too (optional)
│   ├── ...                # etc. (other files that need to be included)
│   ├── readme.txt         # Miscellaneous information (optional)
│   └── config.txt         # Configuration file, contains installation paths (see below)
└── ...
```

### Configuration File
Inside your mods folder should be a *config.txt* file, this is used to install the files to the appropriate/correct path (case-insensitive). Create a new text file and add to a new line each of the installation file paths (either existing or non-existing) on the console. If any of the files need to be in a specific game region folder, for example an *EBOOT.BIN* file will need to be in *dev_hdd0/game/BLESXXXX/USRDIR/EBOOT.BIN*, so just replace the *BLESXXXX* with *{REGION}* and it will format the path to the user's selected region. An example of a *config.txt* for the mods folder above would look like this:

```
dev_hdd0/game/{REGION}/USRDIR/update.rpf
dev_hdd0/game/{REGION}/USRDIR/EBOOT.bin
dev_hdd0/tmp/mod_file.sprx
```

All contributions are welcome just send a pull request :-) It is recommended to use Visual Studio 2017 when making code changes in this project. You can download the community version for free [here](https://www.visualstudio.com/downloads/).

## Screenshots
![Screenshot1](https://github.com/HerbL27/AIO-Loader/blob/master/Screenshots/Screenshot1.png?raw=true)
