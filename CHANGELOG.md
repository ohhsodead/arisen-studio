# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/), and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## Beta 1.4.1
A small update to support installing mods to account resources, allowing the user to choose their specified userId when prompted.

- Added support for specific regions to game mods
- Added ability to filter mods by game regions
- Other minor improvements

## Beta 1.4.0
A small update to support installing mods to account resources, allowing the user to choose their specified userId when prompted.

- Added support for installing to user accounts
- Added warning messages about installing to 'dev_rebug' folders
- Disabled uninstall option from 'dev_rebug' folders
- Removed unnecessary game details section

## Beta 1.3.0
- Improved game file backups
- Added file explorer to seperate form
- Added mods search textbox
- Added games and resources categories
- Added installed game mods section
- Added game information

## Beta 1.2.0
This update mainly includes improvements to the core functionality for installing and uninstalling mods.

- Added console profile connection window
- Added custom mods window
- Added option to show/hide mod id
- Added game mode property to mods
- Added FileZilla option to applications
- Improved game file backups

## Beta 1.1.0
Improved and cleaned the user interface, also many new features, advancements and customization for a complete built-in ftp client, with a more useful logging library and some bug fixes. 

* Added ability to navigate through local and console directory listings
* Added ability to create and manage game file backups
* Added ability to backup original game files
* Added ability to detect uploads of USB files, and prompt the user of so
* Added attribute _Submitted by_ to mods for submitters
* Added modding resources menu, includes popular forum sites, etc.
* Added applications menu, including external installed applications, e.g. CCAPI
* Added context-menu's for more options 
* Added the ability to favorite mods id's
* Added ability to filter mods by firmware
* Added ability to select random mods from library
* Added ability to query and search mods library
* Settings data is now saved to JSON file, instead of application settings
* Removed many unnecessary controls and code

Notes:
* Loading console files in the file explorer with huge directories can sometimes result in a few files not returning file sizes. Not sure what's causing this, seems like it's a timeout issue for large files.

## Beta 1.0.0
- Initial Release