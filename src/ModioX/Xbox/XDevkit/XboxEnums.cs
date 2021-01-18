namespace XDevkit
{
    #region Xbox Enums
    public enum XMessageBoxIcons
    {
        XBM_NOICON,
        XMB_ERRORICON,
        XMB_WARNINGICON,
        XMB_ALERTICON
    }
    public enum XboxConsoleFeatures
    {
        Debugging = 1,
        SecondaryNIC = 2,
        GB_RAM = 4
    }
    /// <summary>
    /// Xbox response type.
    /// </summary>
    public enum ResponseType
    {
        // Success
        SingleResponse = 200,  //OK
        Connected = 201,
        MultiResponse = 202,  //terminates with period
        BinaryResponse = 203,
        ReadyForBinary = 204,
        NowNotifySession = 205,  // notificaiton channel/ dedicated connection

        // Errors
        UndefinedError = 400,
        MaxConnectionsExceeded = 401,
        FileNotFound = 402,
        NoSuchModule = 403,
        MemoryNotMapped = 404,  //setzerobytes or setmem failed
        NoSuchThread = 405,
        ClockNotSet = 406,  //linetoolong or clocknotset
        UnknownCommand = 407,
        NotStopped = 408,
        FileMustBeCopied = 409,
        FileAlreadyExists = 410,
        DirectoryNotEmpty = 411,
        BadFileName = 412,
        FileCannotBeCreated = 413,
        AccessDenied = 414,
        NoRoomOnDevice = 415,
        NotDebuggable = 416,
        TypeInvalid = 417,
        DataNotAvailable = 418,
        BoxIsNotLocked = 420,
        KeyExchangeRequired = 421,
        DedicatedConnectionRequired = 422,
        InvalidArgument = 423,
        ProfileNotStarted = 424,
        ProfileAlreadyStarted = 425,
        D3DDebugCommandNotImplemented = 480,
        D3DInvalidSurface = 481,
        VxTaskPending = 496,
        VxTooManySessions = 497,
    };
    /// <summary>
    /// Receive wait type.
    /// </summary>
    public enum WaitType
    {
        /// <summary>
        /// Does not wait.
        /// </summary>
        None,

        /// <summary>
        /// Waits for data to start being received.
        /// </summary>
        Partial,

        /// <summary>
        /// Waits for data to start and then stop being received.
        /// </summary>
        Full,

        /// <summary>
        /// Waits for data to stop being received.
        /// </summary>
        Idle
    };
    public enum XboxFunctionType
    {
        NoPData = -1,
        SaveMillicode = 0,
        NoHandler = 1,
        RestoreMillicode = 2,
        Handler = 3
    }
    public enum XboxSwitch
    {
        True,
        False
    }
    public enum XboxExecutionState
    {
        Pending,
        Rebooting,
        Running,
        Stopped,
        TitlePending,
        TitleRebooting,
        Unknown,

    }
    /// <summary>
    /// Used to Get Version Information And Console Type
    /// </summary>
    public enum Info
    {
        HDD,
        Type,
        Platform,
        System,
        BaseKrnlVersion,
        KrnlVersion,
        XDKVersion,
    }
    public enum TRAY_STATE
    {
        OPEN,
        UNKNOWN,
        CLOSED,
        OPENING,
        CLOSING
    }
    public enum XboxDrive
    {
        HDD,
        INTUSB,
        USB0,
        CdRom0,
        DVD,
        GAME,
        D,
        DASHUSER,
        media,
        SysCache0,
        SysCache1,
    }
    public enum XboxChars
    {
        a = 4,
        aa = 0x2d,
        b = 5,
        bb = 0x2e,
        c = 6,
        Caps = 0x39,
        cc = 0x2f,
        d = 7,
        dd = 0x30,
        Delete = 0x4c,
        e = 8,
        ee = 0x31,
        eight = 0x25,
        f = 9,
        ff = 0x33,
        five = 0x22,
        four = 0x21,
        g = 10,
        gg = 0x34,
        h = 11,
        hh = 0x35,
        i = 12,
        ii = 0x36,
        j = 13,
        jj = 0x37,
        k = 14,
        kk = 0x38,
        l = 15,
        m = 0x10,
        n = 0x11,
        nine = 0x26,
        o = 0x12,
        one = 30,
        p = 0x13,
        q = 20,
        r = 0x15,
        s = 0x16,
        seven = 0x24,
        six = 0x23,
        Space = 0x2c,
        t = 0x17,
        three = 0x20,
        two = 0x1f,
        u = 0x18,
        v = 0x19,
        w = 0x1a,
        x = 0x1b,
        y = 0x1c,
        z = 0x1d,
        zero = 0x27
    }
    public enum XboxColor
    {
        Black,
        Blue,
        BlueGray,
        White,
    };
    public enum XboxReboot
    {
        Cold = 2,
        Warm = 4,
    }
    /// <summary>
    /// Party System
    /// </summary>
    public enum Xbox_Party_Options
    {
        CreateParty = 0xafc,
        PartySettings = 0xb08,
        InviteOnly = 1,
        Kick = 0xb02,
        OpenParty = 0,
        JoinParty = 0xb01,
        AltJoinParty = 0xb1b,
        LeaveParty = 0xafd,
        InvitePlayer = 0xb15,

    }
    /// <summary>
    /// Guide Shortcuts
    /// </summary>
    public enum XboxShortcuts : int
    {
        //Main Shortcut
        Recent = 0x2C8,
        Guide_Button = 0x506,
        //End Of Main Shortcut

        //Games And Apps Tab
        Achievements = 0x2D0,
        Awards = 0x03C6,
        My_Games,
        Active_Downloads = 0x02E7,
        Redeem_Code,
        //End Of Games And Apps Tab

        //Main Guide
        XboxHome,
        Friends = 0x2BF,
        Party = 0x0305,
        Messages = 0x2C0,
        Beacons_And_Activiy = 0xB39,
        Private_Chat = 0x2C2,
        Open_Tray = 0x60,
        Close_Tray = 0x62,
        //End Of Main Guide

        //Media
        System_Video_Player = 2,
        System_Music_Player = 1,
        Picture_Viewer,
        Windows_Media_Center,
        Select_Music = 0,
        //End Of Media

        //settings
        Profile = 0x2c4,
        Preferences,
        Family_Settings,
        System_Settings,
        Account_Management = 4,
        Turn_Off_Console = 0x0295,
        AvatarEditor = 0xB3A
        //End Of settings

    };

    public enum XboxExceptionFlags
    {
        Noncontinuable = 1,
        FirstChance = 2
    }
    public enum XboxEventDeferFlags
    {
        CanDeferExecutionBreak = 1,
        CanDeferDebugString = 2,
        CanDeferSingleStep = 4,
        CanDeferAssertionFailed = 8,
        CanDeferAssertionFailedEx = 16,
        CanDeferDataBreak = 32,
        CanDeferRIP = 64
    }
    public enum XboxDumpReportFlags
    {
        FormatFullHeap = 0,
        LocalDestination = 0,
        PromptToReport = 0,
        AlwaysReport = 1,
        NeverReport = 2,
        DestinationGroup = 15,
        ReportGroup = 15,
        RemoteDestination = 16,
        FormatPartialHeap = 256,
        FormatNoHeap = 512,
        FormatRetail = 1024,
        FormatGroup = 3840
    }
    public enum XboxCreateDisposition
    {
        CreateNew = 1,
        CreateAlways = 2,
        OpenExisting = 3,
        OpenAlways = 4
    }
    public enum XboxConsoleType
    {
        DevelopmentKit,
        TestKit,
        ReviewerKit
    }
    public enum XboxBreakpointType
    {
        OnWrite,
        NoBreakpoint,
        OnRead,
        OnExecuteHW,
        OnExecute
    }
    public enum XboxDumpMode
    {
        Smart,
        Enabled,
        Disabled
    }
    public enum XboxDumpFlags
    {
        Normal = 0,
        WithDataSegs = 1,
        WithFullMemory = 2,
        WithHandleData = 4,
        FilterMemory = 8,
        ScanMemory = 16,
        WithUnloadedModules = 32,
        WithIndirectlyReferencedMemory = 64,
        FilterModulePaths = 128,
        WithProcessThreadData = 256,
        WithPrivateReadWriteMemory = 512
    }
    public enum XboxDebugEventType
    {
        NoEvent,
        ExecutionBreak,
        DebugString,
        ExecStateChange,
        SingleStep,
        ModuleLoad,
        ModuleUnload,
        ThreadCreate,
        ThreadDestroy,
        Exception,
        AssertionFailed,
        AssertionFailedEx,
        DataBreak,
        RIP,
        SectionLoad,
        SectionUnload,
        StackTrace,
        FiberCreate,
        FiberDestroy,
        BugCheck,
        PgoModuleStartup
    }
    public enum XboxStopOnFlags
    {
        OnThreadCreate = 1,
        OnFirstChanceException = 2,
        OnDebugString = 4,
        OnStackTrace = 8,
        OnModuleLoad = 16,
        OnTitleLaunch = 32,
        OnPgoModuleStartup = 64
    }
    public enum XboxAutomationButtonFlags
    {
        DPadUp = 1,
        DPadDown = 2,
        DPadLeft = 4,
        DPadRight = 8,
        StartButton = 16,
        BackButton = 32,
        LeftThumbButton = 64,
        RightThumbButton = 128,
        LeftShoulderButton = 256,
        RightShoulderButton = 512,
        Xbox360_Button = 1024,
        Bind_Button = 2048,
        A_Button = 4096,
        B_Button = 8192,
        X_Button = 16384,
        Y_Button = 32768
    }
    public enum XboxAccessFlags
    {
        Read = 1,
        Write = 2,
        Control = 4,
        Configure = 8,
        Manage = 16
    }
    public enum XboxShareMode
    {
        ShareNone = 0,
        ShareRead = 1,
        ShareWrite = 2,
        ShareDelete = 4
    }
    public enum XboxSelectConsoleFlags
    {
        NoPromptIfDefaultExists,
        NoPromptIfOnlyOne,
        FilterByAccess
    }
    public enum XboxSectionInfoFlags
    {
        Loaded = 1,
        Readable = 2,
        Writeable = 4,
        Executable = 8,
        Uninitialized = 16
    }
    public enum XboxRegistersVector
    {
        v0,
        v1,
        v2,
        v3,
        v4,
        v5,
        v6,
        v7,
        v8,
        v9,
        v10,
        v11,
        v12,
        v13,
        v14,
        v15,
        v16,
        v17,
        v18,
        v19,
        v20,
        v21,
        v22,
        v23,
        v24,
        v25,
        v26,
        v27,
        v28,
        v29,
        v30,
        v31,
        v32,
        v33,
        v34,
        v35,
        v36,
        v37,
        v38,
        v39,
        v40,
        v41,
        v42,
        v43,
        v44,
        v45,
        v46,
        v47,
        v48,
        v49,
        v50,
        v51,
        v52,
        v53,
        v54,
        v55,
        v56,
        v57,
        v58,
        v59,
        v60,
        v61,
        v62,
        v63,
        v64,
        v65,
        v66,
        v67,
        v68,
        v69,
        v70,
        v71,
        v72,
        v73,
        v74,
        v75,
        v76,
        v77,
        v78,
        v79,
        v80,
        v81,
        v82,
        v83,
        v84,
        v85,
        v86,
        v87,
        v88,
        v89,
        v90,
        v91,
        v92,
        v93,
        v94,
        v95,
        v96,
        v97,
        v98,
        v99,
        v100,
        v101,
        v102,
        v103,
        v104,
        v105,
        v106,
        v107,
        v108,
        v109,
        v110,
        v111,
        v112,
        v113,
        v114,
        v115,
        v116,
        v117,
        v118,
        v119,
        v120,
        v121,
        v122,
        v123,
        v124,
        v125,
        v126,
        v127,
        vscr
    }
    public enum XboxRegisters64
    {
        ctr,
        r0,
        r1,
        r2,
        r3,
        r4,
        r5,
        r6,
        r7,
        r8,
        r9,
        r10,
        r11,
        r12,
        r13,
        r14,
        r15,
        r16,
        r17,
        r18,
        r19,
        r20,
        r21,
        r22,
        r23,
        r24,
        r25,
        r26,
        r27,
        r28,
        r29,
        r30,
        r31
    }
    public enum XboxDebugConnectFlags
    {
        Force = 1,
        MonitorOnly = 2
    }
    public enum XboxMemoryRegionFlags
    {
        NoAccess = 1,
        ReadOnly = 2,
        ReadWrite = 4,
        WriteCopy = 8,
        Execute = 16,
        ExecuteRead = 32,
        ExecuteReadWrite = 64,
        ExecuteWriteCopy = 128,
        Guard = 256,
        NoCache = 512,
        WriteCombine = 1024,
        UserReadOnly = 4096,
        UserReadWrite = 8192
    }
    public enum XboxRebootFlags
    {
        Title = 0,
        Wait = 1,
        Cold = 2,
        Warm = 4,
        Stop = 8
    }
    public enum XboxModuleInfoFlags
    {
        Main = 1,
        Tls = 2,
        Dll = 4
    }
    public enum XboxRegisters32
    {
        msr,
        iar,
        lr,
        cr,
        xer
    }
    public enum XboxRegistersDouble
    {
        fp0,
        fp1,
        fp2,
        fp3,
        fp4,
        fp5,
        fp6,
        fp7,
        fp8,
        fp9,
        fp10,
        fp11,
        fp12,
        fp13,
        fp14,
        fp15,
        fp16,
        fp17,
        fp18,
        fp19,
        fp20,
        fp21,
        fp22,
        fp23,
        fp24,
        fp25,
        fp26,
        fp27,
        fp28,
        fp29,
        fp30,
        fp31,
        fpscr
    }
    public enum LEDState
    {
        OFF = 0,
        RED = 8,
        GREEN = 128,
        ORANGE = 136
    }

    public enum TemperatureFlag
    {
        CPU,
        GPU,
        EDRAM,
        MotherBoard
    }

    public enum ThreadType
    {
        System,
        Title
    }
    public enum XNotiyLogo : int
    {
        XBOX_LOGO = 0,
        NEW_MESSAGE_LOGO = 1,
        FRIEND_REQUEST_LOGO = 2,
        NEW_MESSAGE = 3,
        FLASHING_XBOX_LOGO = 4,
        GAMERTAG_SENT_YOU_A_MESSAGE = 5,
        GAMERTAG_SINGED_OUT = 6,
        GAMERTAG_SIGNEDIN = 7,
        GAMERTAG_SIGNED_INTO_XBOX_LIVE = 8,
        GAMERTAG_SIGNED_IN_OFFLINE = 9,
        GAMERTAG_WANTS_TO_CHAT = 10,
        DISCONNECTED_FROM_XBOX_LIVE = 11,
        DOWNLOAD = 12,
        FLASHING_MUSIC_SYMBOL = 13,
        FLASHING_HAPPY_FACE = 14,
        FLASHING_FROWNING_FACE = 15,
        FLASHING_DOUBLE_SIDED_HAMMER = 16,
        GAMERTAG_WANTS_TO_CHAT_2 = 17,
        PLEASE_REINSERT_MEMORY_UNIT = 18,
        PLEASE_RECONNECT_CONTROLLERM = 19,
        GAMERTAG_HAS_JOINED_CHAT = 20,
        GAMERTAG_HAS_LEFT_CHAT = 21,
        GAME_INVITE_SENT = 22,
        FLASH_LOGO = 23,
        PAGE_SENT_TO = 24,
        FOUR_2 = 25,
        FOUR_3 = 26,
        ACHIEVEMENT_UNLOCKED = 27,
        FOUR_9 = 28,
        GAMERTAG_WANTS_TO_TALK_IN_VIDEO_KINECT = 29,
        VIDEO_CHAT_INVITE_SENT = 30,
        READY_TO_PLAY = 31,
        CANT_DOWNLOAD_X = 32,
        DOWNLOAD_STOPPED_FOR_X = 33,
        FLASHING_XBOX_CONSOLE = 34,
        X_SENT_YOU_A_GAME_MESSAGE = 35,
        DEVICE_FULL = 36,
        FOUR_7 = 37,
        FLASHING_CHAT_ICON = 38,
        ACHIEVEMENTS_UNLOCKED = 39,
        X_HAS_SENT_YOU_A_NUDGE = 40,
        MESSENGER_DISCONNECTED = 41,
        BLANK = 42,
        CANT_SIGN_IN_MESSENGER = 43,
        MISSED_MESSENGER_CONVERSATION = 44,
        FAMILY_TIMER_X_TIME_REMAINING = 45,
        DISCONNECTED_XBOX_LIVE_11_MINUTES_REMAINING = 46,
        KINECT_HEALTH_EFFECTS = 47,
        FOUR_5 = 48,
        GAMERTAG_WANTS_YOU_TO_JOIN_AN_XBOX_LIVE_PARTY = 49,
        PARTY_INVITE_SENT = 50,
        GAME_INVITE_SENT_TO_XBOX_LIVE_PARTY = 51,
        KICKED_FROM_XBOX_LIVE_PARTY = 52,
        NULLED = 53,
        DISCONNECTED_XBOX_LIVE_PARTY = 54,
        DOWNLOADED = 55,
        CANT_CONNECT_XBL_PARTY = 56,
        GAMERTAG_HAS_JOINED_XBL_PARTY = 57,
        GAMERTAG_HAS_LEFT_XBL_PARTY = 58,
        GAMER_PICTURE_UNLOCKED = 59,
        AVATAR_AWARD_UNLOCKED = 60,
        JOINED_XBL_PARTY = 61,
        PLEASE_REINSERT_USB_STORAGE_DEVICE = 62,
        PLAYER_MUTED = 63,
        PLAYER_UNMUTED = 64,
        FLASHING_CHAT_SYMBOL = 65,
        UPDATING = 76,
    }
    #endregion
}
