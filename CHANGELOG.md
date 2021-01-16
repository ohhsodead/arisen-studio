# Changelog
All notable changes to this project will be documented in this file.

## Beta v1.5 (Unreleased)
- Improved code readability
- Optimized parts of the application
- Moved Logs from Application folder to Documents\ModioX\Logs
- Upgraded Application to .NET Framework 4.8
- Upgraded dependencies and removed redundant\unused ones
- You can now create and add mods to your own lists
- Added View Log button to Help menu
- Added Open Log Folder button to Help menu
- Added What's New button to Help menu
- Added Package Manager to Tools menu
- Fixed some UI bugs and added all missing icons
- Fixed an issue with creating folders when installing mods
- Fixed an issue with deleting folders when uninstalling mods

## Beta v1.4.8
- Improved some user interface elements
- Mods can now have multiple downloads instead of multiple mods
- Previous mods to the same game won't automatically be uninstalled
- User profile names will now be shown
- Game titles will now be shown in the file manager
- Added Game Updates Finder to Tools menu
- Added WebMAN Controls to Tools menu
- Added Settings window to Options menu
- Removed Offline Mode from Connect menu
- Removed Game Updates category
- Removed Resources menu (some links could promote piracy)
- Removed Request Mods window
- Fixed an issue where a blank console would be created
- Windows 10 icons are now used (via icons8.com)

## Beta v1.4.7
- Removed Games from Resources menu
- Rearranged options in Settings menu

## Beta v1.4.6
- Folders will be created if the files install path doesn't exist
- Folders will be deleted if empty after uninstalling files
- Fixed uninstalling files/folders from USB device
- Fixed deleting files/folders in the file manager
- Fixed selecting an option in the list view dialog
- Other minor improvements

## Beta v1.4.5
- Improved code/naming conventions/folder structure
- Improved the file manager by adding more functions
- You can now set a username and password for consoles (optional)
- You can now create new folders in the file manager
- You can now rename files/folders in the file manager
- You can now edit or delete consoles in the connection window
- Added what's new dialog which shows after an update
- Added last updated date attribute to database
- Added homebrew packages to categories
- Added instructions for installing/uninstalling mods
- Added check for Internet connection before loading database
- Added FluentFTP for faster directory listings
- Removed custom mods, prioritizing file manager instead
- Fixed deleting/uninstalling files

## Beta v1.4.4
- Installed mods are now downloaded to Documents folder
- Added a link to the discord community server
- Added more helpful comments to code
- Fixed a possible error with installing/uninstalling mods

## Beta v1.4.3
- Instruction message will show on first time use
- Backup files are now saved to Documents folder
- You can now add external applications
- You can now reset all settings to default
- You can now manually check for updates
- You can now see game mods installed date/time
- A changelog window will now show after an update
- Added direct Github API for retrieving new release data
- Other minor improvements 

## Beta v1.4.2
- Added support for installing game saves
- Added support for installing files to both console USB ports
- Added automatic uninstall when installing mods to same game
- Added save/edit game regions option to settings
- Added more information window to help menu
- Added mod requests form window
- Fixed uninstalling mods when installing to same game
- Fixed updating scrollbars when using mouse wheel
- Settings file is now saved to Documents folder
- Cleaned and documented most of the code
- Other additional minor improvements

## Beta v1.4.1
A small update to support installing mods to account resources, allowing the user to choose their specified userId when prompted.

- Added support for specific regions to game mods
- Added ability to filter mods by game regions
- Other minor improvements

## Beta v1.4.0
A small update to support installing mods to account resources, allowing the user to choose their specified userId when prompted.

- Added support for installing to user accounts
- Added warning messages about installing to 'dev_rebug' folders
- Disabled uninstall option from 'dev_rebug' folders
- Removed unnecessary game details section

## Beta v1.3.0
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

## Beta v1.1.0
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

## Beta v1.0.0
- Initial Release
