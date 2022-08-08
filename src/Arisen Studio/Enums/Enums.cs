using System.ComponentModel;

namespace ArisenStudio
{
    /// <summary>
    /// Determines the type of console.
    /// </summary>
    public enum PlatformType
    {
        [Description("PlayStation 3 (Fat)")]
        PlayStation3Fat,

        [Description("PlayStation 3 (Slim)")]
        PlayStation3Slim,

        [Description("PlayStation 3 (Super Slim)")]
        PlayStation3SuperSlim,

        [Description("Xbox 360 (Fat/White)")]
        Xbox360FatWhite,

        [Description("Xbox 360 Elite (Fat/Black)")]
        Xbox360EliteFatBlack,

        [Description("Xbox 360 S (Slim)")]
        Xbox360Slim,

        [Description("Xbox 360 E (Slim E)")]
        Xbox360SlimE
    }

    /// <summary>
    /// Get the prefix for the type of console.
    /// </summary>
    public enum Platform
    {
        [Description("PlayStation 3")]
        PS3,

        [Description("Xbox 360")]
        XBOX360
    }

    public enum FilterType
    {
        Equal,
        MoreThanOrEqual,
        LessThanOrEqual
    }

    /// <summary>
    /// Category options.
    /// </summary>
    public enum CategoryType
    {
        Game,
        Homebrew,
        Resource,
        Plugin,
        GameSave
    }

    public enum TransferType
    {
        [Description("INSTALLING_MODS")]
        InstallMods,

        [Description("UNINSTALLING_MODS")]
        UninstallMods,

        [Description("DOWNLOADING_MODS")]
        DownloadMods,

        [Description("INSTALLING_PACKAGE")]
        InstallPackage,

        [Description("UNINSTALLING_PACKAGE")]
        UninstallPackage,

        [Description("DOWNLOADING_PACKAGE")]
        DownloadPackage,

        [Description("INSTALLING_GAME_SAVE")]
        InstallGameSave,

        [Description("DOWNLOADING_GAME_SAVE")]
        DownloadGameSave
    }
}