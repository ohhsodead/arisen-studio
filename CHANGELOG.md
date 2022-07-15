# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/), and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## Beta v2.3.0
- Renamed project to Arisen Mods
- Updated DevExpress to 22.1
- Updated AutoUpdater.NET package to 1.7.3
- Updated FluentFTP package to 37.0.4
- Updated HtmlAgilityPack package to 1.11.43
- Updated NLog package to 5.0.1
- Updated WebView package to 1.0.1245.22
- Added Tomlyn package for Xbox game patches
- Added ribbon strip to replace menu bar
- Added Our Favorite Mods section to Dashboard
- Added Recently Updated section to Dashboard
- Added default option for console profiles
- Added option to open Request Mods form in browser
- Added support for Spanish and Turkish translations
- Added Console Manager for Xbox 360
- Fixed issue with installing game mods
- Fixed issue with wrong mod dialogs being shown
- Fixed Module Loader not able to fetch modules
- Fixed Dashlaunch Editor saving the launch.ini file
- Fixed problems with using higher scaling
- Replaced XDRPC with JRPC2
- Improved layout of the details dialog
- Lots of improvements to layout/design

## Beta v2.2.1
- Fixed "failed to get epsv port" error message
- Other minor improvements

## Beta v2.2.0
- Updated NLog package to 5.0.0
- Reverted project name and logo
- Added WebView2 package
- Added Google Form to Request Mods
- Added Boot Plugins Editor for PS3
- Added Modules Loader for Xbox 360
- Added XUID Spoofer for Xbox 360
- Added option to always show rich presence
- Added option to detect all game regions for PS3
- Added option to edit name in Game Launcher for Xbox 360
- Added drag and drop for File Manager
- Moved help menu to a three vertical dots button
- Fixed Favorites not being saved after closing
- Fixed missing text in connect menu for disconnecting
- Fixed File Manager not loading due to wrong localization value
- Improvements to design/controls layout

Note: Request Mods form will not load if NeoModsX is installed to the "C:\Program Files\" folder.

## Beta v2.1.3
- Project renamed to Modio, also a new icon
- Added Edit Advanced Settings Tile to Dashboard
- Added Transfer tab to Settings
- Added option to delete local files after installing
- Added option to always backup game files
- Added Homebrew path to Settings
- Added Resources path to Settings
- Added support for Xbox 360 game cheats
- Added About page replacing the dialog
- Added Downloads to mod details
- Added set previous window state
- Fixed loading Package File Manager
- Fixed loading Console Manager
- Fixed downloading Packages using Base Directory
- Fixed Change Log text now wraps for long items
- Fixed "Open Folder" for Downloads
- Fixed setting Downloads folder from Dashboard
- Redesigned the mod details
- Removed Imported Mods feature
- Backup Files has changed to Backup File Manager
- Reduced hitting the GitHub API rate limit
- More strings are supported by translations
- Database files have been split by category types
- Moved database files to its own git repository
- Improvements to user interface design

Note: Sorting Packages by file size doesn't work correctly. I'm working on a fix for this.

## Beta v2.1.2
- Fixed bug when navigating pages
- Other minor bug fixes and improvements

## Beta v2.1.1
- Added Paths tab to Settings
- Fixed crash when starting application (#62)
- Fixed showing previous language after restart
- Improvements to design style

## Beta v2.1.0
- Updated FluentFTP package to 37.0.2
- Updated Humanizer package to 2.14.1
- Updated NLog package to 4.7.15
- Added Discord Rich Presence option
- Added Game Cheats page for RTM
- Added Swedish language (Thanks goldug!)
- Added delete buttons to Installed Mods page
- Added status to the footer
- Added connection status to the footer
- Added extra details when viewing scripts
- Added FAQ help for using packages
- Added hyperlink support for descriptions
- Changed DPI awareness to system
- Fixed webMAN package detection
- Fixed dismissing announcements
- Removed Custom Lists, use Favorites
- Removed Chat Room, might be a separate project
- Updated messages for more clarification
- Only one instance of the application can be open
- Installed Mods now saved to current console profile
- Other improvements to code and design

Note: Sorting Packages by file size doesn't work correctly. I'm working on a fix for this.

## Beta v2.0.2
- Minor improvements to interface (#52)
- Added FAQ dialog for using Packages

## Beta v2.0.1
A small update to fix some bugs.

- Fixed sorting game saves by platform
- Fixed sorting game saves by category
- Fixed templates for reporting mods

## Beta v2.0.0
- Upgraded DevExpress to v21.1
- Upgraded FluentFTP package to v35.0.5
- Upgraded NLog package to v4.7.11
- Added CodeHollow.FeedReader package
- Added Profanity.Detector package
- Added Humanizer package
- Added navigation side menu for pages
- Added Dashboard page
- Added Setup section
- Added Tools section
- Added Announcements section
- Added News Feed via RSS section
- Added Credits/Contributors section
- Added Downloads page
- Added Installed Mods page
- Added File Manager page
- Added Settings page
- Added Mods page
- Added Packages page
- Added Plugins page
- Added Game Saves page
- Added Transfer Files Dialog
- Added Game Save Resigner for Xbox
- Added Game Launcher for Xbox
- Added Chat Room for general discussions
- Added base support for other Languages
- Added filtering options for all columns
- Added sorting options for all columns
- Added option to backup all games files at once
- Added option to use relative date times
- Added option to install mods to local USB device
- Added option to enable hardware acceleration
- Added option to set packages install path
- Added option to set downloads folder
- Removed Settings Dialog
- Removed all redundant resources
- Fixed issue when clicking cancel in the connection details
- Fixed issue with certificates when fetching release data
- Replaced InputTextDialog with XtraInputBox
- Improved overall performance using async functions
- Improved installing and uninstalling files
- Main menu is now in the title bar
- Backup file's data are now saved separately to Settings
- Game titles are now extracted from PARAM.SFO file
- Google Forms are now used for requesting mods
- Lots of bug fixes and improvements

## Beta v1.5.0
- Optimized parts of the application
- Improved code readability
- Improved parsing of the database files
- Moved database files to GitHub
- Moved log files to Documents\ModioX\Logs
- Upgraded application to .NET Framework 4.8
- Upgraded application to DevExpress Forms
- Removed redundant and unused dependencies
- Removed Applications menu
- Added an auto-updater instead of using the installer
- Added splash screen for loading application
- Added Request Mods form
- Added support for Xbox RGH/JTAG consoles
- Added images for all PS3 and Xbox models
- Added ability to create and add mods to your own lists
- Added Package Manager for PS3 to Tools menu
- Added Mount/Unmount Games for PS3 to Tools menu
- Added File Manager for Xbox to Tools menu
- Added Launch File Editor for Xbox to Tools menu
- Added XBDM Controls for Xbox to Tools menu
- Added Skin Manager to Options menu
- Added Settings to Options menu
- Added View Log button to Help menu
- Added Open Log Folder button to Help menu
- Added What's New button to Help menu
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

- Added ability to navigate through local and console directory listings
- Added ability to create and manage game file backups
- Added ability to backup original game files
- Added ability to detect uploads of USB files, and prompt the user of so
- Added attribute _Submitted by_ to mods for submitters
- Added modding resources menu, includes popular forum sites, etc.
- Added applications menu, including external installed applications, e.g. CCAPI
- Added context-menu's for more options 
- Added the ability to favorite mods id's
- Added ability to filter mods by firmware
- Added ability to select random mods from library
- Added ability to query and search mods library
- Settings data is now saved to JSON file, instead of application settings
- Removed many unnecessary controls and code

Notes:
- Loading console files in the file explorer with huge directories can sometimes result in a few files not returning file sizes. Not sure what's causing this, seems like it's a timeout issue for large files.

## Beta v1.0.0
- Initial Release
