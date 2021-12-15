using System.ComponentModel;

namespace ModioX
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
    public enum PlatformPrefix
    {
        [Description("PlayStation 3")]
        PS3,

        [Description("Xbox 360")]
        XBOX
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
        Resource
    }

    public enum TransferType
    {
        InstallMods,
        UninstallMods,
        DownloadMods,

        InstallPackage,
        UninstallPackage,
        DownloadPackage,

        InstallGameSave,
        DownloadGameSave,
    }

    public enum ChatNotificationType
    {
        AllMessages,
        Mentioned,
        None
    }
}