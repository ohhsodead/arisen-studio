# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/), and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## Beta v3.2.1
- Added Romanian language translations
- Fixed "425" connection issues when installing files
- Fixed buttons being translated when its unnecessary
- Fixed conflicts with Homebrew and Game Mods pages
- Fixed wrong console image in Connections dialog
- Fixed HTML tags in Setup Wizard and Dialogs
- Removed "Passive Mode" as causes issues with connection

## Beta v3.2.0
- Updated DevExpress library to 24.1
- Updated AutoUpdater.NET package to 1.9.2
- Updated FluentFTP package to 51.1.0
- Updated HtmlAgilityPack package to 1.11.65
- Updated WebView2 package to 1.0.2651.64
- Updated NLog package to 5.3.4
- Added new language Portuguese (Brazilian)
- Added simple cache for database files to improve startup
- Added partial support for PS4 connections
- Added support for PS4 database files
- Added Applications page for PS4 apps
- Added Games page for PS4 games
- Added Trainers page for Xbox 360 games
- Added Setup Wizard for first time use
- Added progress bar status when transferring files
- Added shortcut actions for library pages
- Added a better Screenshot Tool for PS3
- Added button to copy download link for mods
- Added options to change Neighborhood console name and icon
- Added option to ignore supported regions when installing
- Added an Easter egg somewhere in the app, try find it ;)
- Fixed no internet being detected when using a VPN
- Fixed sizing issues with users on different scaling settings
- Fixed creating console profile on start-up not working
- Fixed some strings not being translated at all
- Fixed images for directory listings in File Manager
- Fixed automatic scan for Xbox consoles
- Fixed some filters not working for Installed Files page
- Fixed discord rich presence with newer AppID
- Fixed Boot Plugins Editor not loading correct console file
- Fixed some minor issues found in modding tools
- Removed Console Manager for Xbox 360 due to multiple issues
- App updates aren't forced anymore except for major versions
- Game Cheats (RTE) is enabled for testing (beta)
- Game Save Resigner is always enabled now
- Improved consistency for the Settings Page
- Improved configuration for setting file locations
- Improved functionality for some of the tools for PS3 and Xbox
- Redesign the layout of controls and content for dialogs
- Moved all database files to @goldug's web server
- Optimized lots of code, removed redundant resources
- Major and minor quality of life improvements (QoL)

## Beta v3.1.2
- Improved overall design and layout
- Updated project with new coding standards
- Updated icons to fit current themes
- Updated AutoUpdater.NET library to 1.8.6
- Updated DevExpress library to 23.2
- Updated FluentFTP package to 50.0.1
- Updated HtmlAgilityPack package to 1.11.61
- Updated WebView2 package to 1.0.2478.35
- Updated NLog package to 5.3.2
- Updated Tomlyn package to 0.17.0
- About page is easier to manage, less buggy
- Added Our Favorite Games section
- Added Current Poll section
- Added option to install PKG after uploading
- Added missing icons from File Manager

## Beta v3.1.1
- Fixed wrong language for installer
- Hotfix for resource files issue

## Beta v3.1.0
- Updated DevExpress library to 23.1
- Updated AutoUpdater.NET package to 1.8.4
- Updated DiscordRichPresence package to 1.2.1.24
- Updated FluentFTP package to 48.0.3
- Updated HtmlAgilityPack package to 1.11.54
- Updated WebView2 package to 1.0.2151.40
- Updated NLog package to 5.2.6
- Updated to the new domain
- Fixed possible issue when trying to connect to Xbox
- Fixed issue when transferring Xbox files (by Huawei)
- Fixed default paths when installing not working
- Fixed paths being limited to only 16 characters
- Fixed game saves being downloaded as PKG type
- Removed Hardware Acceleration from Settings
- Other minor fixes and improvements

## Beta v3.0.4
- Updated AutoUpdater.NET package to 1.8.1
- Updated WebView2 package to 1.0.1722.45
- Updated NLog package to 5.1.4
- Added Game Launcher GUI for PS3
- Added option to launch game for PS3
- Added ignore overwrite for homebrew
- Fixed "Code 425" when connecting (#75)

## Beta v3.0.3
- Updated CodeHollow.FeedReader package to 1.2.6
- Updated FluentFTP package to 46.0.2
- Updated SharpZipLib package to 1.4.2
- Added prompt with requirements/usage on startup
- Added better configurations for when using FTP
- Fixed creating Guest profile on startup
- Fixed opening external link for submit mods form
- Fixed refresh button in submit mods dialog
- Fixed timeout when using file manager
- Fixed and updated the Xbox 360 libraries


## Beta v3.0.2
- Updated AutoUpdater.NET package to 1.7.6
- Updated DiscordRichPresence package to 1.1.3.18
- Updated FluentFTP package to 44.0.1
- Updated HtmlAgilityPack package to 1.11.46
- Updated Newtonsoft.Json package to 13.0.2
- Updated NLog package to 5.1.1
- Updated SharpZipLib package to 1.4.1
- Updated Tomlyn package to 0.16.2
- Updated WebView2 package to 1.0.1518.46
- Added Always Show Game Playing to Settings
- Added delay in searching packages
- Fixed install buttons enabling for correct category
- Fixed detecting if webMAN is installed on PS3
- Fixed returning null if no backup file exists
- Fixed wrong values under Tools in Settings
- Fixed package downloads crashing Downloads tab
- Packages will not show in the Downloads tab
- Game Cheats tab disabled/hidden until complete
- Game title returns zero if unable to get title ID
- Changed Request Mods form to allow uploading files

## Beta v3.0.1
- Updated AutoUpdater.NET package to 1.7.5
- Updated FluentFTP package to 39.4.0
- Updated HtmlAgilityPack package to 1.11.45
- Updated NLog package to 5.0.2
- Added option to show/hide game playing
- Fixed showing current game playing
- Fixed installing files to USB device
- Fixed installing files when no backup files exist

## Beta v3.0.0
- Updated AutoUpdater.NET package to 1.7.4
- Updated FluentFTP package to 39.1.0
- Updated WebView2 package to 1.0.1293.44
- Application data is now saved to "\AppData\Roaming\"
- Added prompt when creating a profile for the first time
- Added option to create a "guest" profile
- Added Imgur.API package
- Added project social icons to about page
- Added application description to about page
- Added Current Game to status bar
- Added Take Screenshot dialog for Xbox 360
- Added option to give screenshot file name
- Added preview of the screenshot image
- Added option to upload screenshot to Imgur.com
- Added XboxHDKey for Xbox 360
- Moved help menu to the ribbon menu
- Fixed tools not changing when switching platforms
- Fixed sections not changing when switching platforms
- Fixed download files to correct paths
- Fixed details dialog not showing full values
- Fixed categories being shown when don't have any results
- Fixed Resources being shown in Game Saves tab
- Fixed Resources details dialog cutting off values
- Fixed Resources not filtering by status
- Fixed Packages showing results without URL
- Fixed sorting Packages by file size
- Fixed filtering by Modified Date for Packages
- Fixed clearing the Modified Date filter in Packages
- Fixed issues with creating backups when installing files
- Fixed creating and saving backup files data
- Fixed line breaks formatting
- Fixed clearing discord rich presence when disabling
- Improved startup screen to show application faster

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
