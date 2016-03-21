using System.Collections.Generic;

namespace Syroot.Windows.IO
{
    /// <summary>
    /// A collection of properties to retrieve specific file system paths for the current user.
    /// </summary>
    public static class KnownFolders
    {
        // ---- MEMBERS ------------------------------------------------------------------------------------------------

        private static Dictionary<KnownFolderType, KnownFolder> _knownFolderInstances;

        // ---- PROPERTIES ---------------------------------------------------------------------------------------------

        #region ---- Typed KnownFolder Instances ----
        /// <summary>
        /// The per-user Account Pictures folder. Introduced in Windows 8.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\AccountPictures&quot;.
        /// </summary>
        public static KnownFolder AccountPictures
        {
            get { return GetInstance(KnownFolderType.AccountPictures); }
        }

        /// <summary>
        /// The per-user Administrative Tools folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu\Programs\Administrative Tools&quot;.
        /// </summary>
        public static KnownFolder AdminTools
        {
            get { return GetInstance(KnownFolderType.AdminTools); }
        }

        /// <summary>
        /// The per-user Application Shortcuts folder. Introduced in Windows 8.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Application Shortcuts&quot;.
        /// </summary>
        public static KnownFolder ApplicationShortcuts
        {
            get { return GetInstance(KnownFolderType.ApplicationShortcuts); }
        }

        /// <summary>
        /// The per-user Camera Roll folder. Introduced in Windows 8.1.
        /// Defaults to &quot;.%USERPROFILE%\Pictures\Camera Roll&quot;.
        /// </summary>
        public static KnownFolder CameraRoll
        {
            get { return GetInstance(KnownFolderType.CameraRoll); }
        }

        /// <summary>
        /// The per-user Temporary Burn Folder.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Burn\Burn&quot;.
        /// </summary>
        public static KnownFolder CDBurning
        {
            get { return GetInstance(KnownFolderType.CDBurning); }
        }

        /// <summary>
        /// The common Administrative Tools folder.
        /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\Administrative Tools&quot;.
        /// </summary>
        public static KnownFolder CommonAdminTools
        {
            get { return GetInstance(KnownFolderType.CommonAdminTools); }
        }

        /// <summary>
        /// The common OEM Links folder.
        /// Defaults to &quot;%ALLUSERSPROFILE%\OEM Links&quot;.
        /// </summary>
        public static KnownFolder CommonOemLinks
        {
            get { return GetInstance(KnownFolderType.CommonOemLinks); }
        }

        /// <summary>
        /// The common Programs folder.
        /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs&quot;.
        /// </summary>
        public static KnownFolder CommonPrograms
        {
            get { return GetInstance(KnownFolderType.CommonPrograms); }
        }

        /// <summary>
        /// The common Start Menu folder.
        /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu&quot;.
        /// </summary>
        public static KnownFolder CommonStartMenu
        {
            get { return GetInstance(KnownFolderType.CommonStartMenu); }
        }

        /// <summary>
        /// The common Startup folder.
        /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\StartUp&quot;.
        /// </summary>
        public static KnownFolder CommonStartup
        {
            get { return GetInstance(KnownFolderType.CommonStartup); }
        }

        /// <summary>
        /// The common Templates folder.
        /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Templates&quot;.
        /// </summary>
        public static KnownFolder CommonTemplates
        {
            get { return GetInstance(KnownFolderType.CommonTemplates); }
        }

        /// <summary>
        /// The per-user Contacts folder. Introduced in Windows Vista.
        /// Defaults to &quot;%USERPROFILE%\Contacts&quot;.
        /// </summary>
        public static KnownFolder Contacts
        {
            get { return GetInstance(KnownFolderType.Contacts); }
        }

        /// <summary>
        /// The per-user Cookies folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Cookies&quot;.
        /// </summary>
        public static KnownFolder Cookies
        {
            get { return GetInstance(KnownFolderType.Cookies); }
        }

        /// <summary>
        /// The per-user Desktop folder.
        /// Defaults to &quot;%USERPROFILE%\Desktop&quot;.
        /// </summary>
        public static KnownFolder Desktop
        {
            get { return GetInstance(KnownFolderType.Desktop); }
        }

        /// <summary>
        /// The common DeviceMetadataStore folder. Introduced in Windows 7.
        /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\DeviceMetadataStore&quot;.
        /// </summary>
        public static KnownFolder DeviceMetadataStore
        {
            get { return GetInstance(KnownFolderType.DeviceMetadataStore); }
        }

        /// <summary>
        /// The per-user Documents folder.
        /// Defaults to &quot;%USERPROFILE%\Documents&quot;.
        /// </summary>
        public static KnownFolder Documents
        {
            get { return GetInstance(KnownFolderType.Documents); }
        }

        /// <summary>
        /// The per-user Documents library. Introduced in Windows 7.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Documents.library-ms&quot;.
        /// </summary>
        public static KnownFolder DocumentsLibrary
        {
            get { return GetInstance(KnownFolderType.DocumentsLibrary); }
        }

        /// <summary>
        /// The per-user Downloads folder.
        /// Defaults to &quot;%USERPROFILE%\Downloads&quot;.
        /// </summary>
        public static KnownFolder Downloads
        {
            get { return GetInstance(KnownFolderType.Downloads); }
        }

        /// <summary>
        /// The per-user Favorites folder.
        /// Defaults to &quot;%USERPROFILE%\Favorites&quot;.
        /// </summary>
        public static KnownFolder Favorites
        {
            get { return GetInstance(KnownFolderType.Favorites); }
        }

        /// <summary>
        /// The fixed Fonts folder.
        /// Points to &quot;%WINDIR%\Fonts&quot;.
        /// </summary>
        public static KnownFolder Fonts
        {
            get { return GetInstance(KnownFolderType.Fonts); }
        }

        /// <summary>
        /// The per-user GameExplorer folder. Introduced in Windows Vista.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\GameExplorer&quot;.
        /// </summary>
        public static KnownFolder GameTasks
        {
            get { return GetInstance(KnownFolderType.GameTasks); }
        }

        /// <summary>
        /// The per-user History folder.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\History&quot;.
        /// </summary>
        public static KnownFolder History
        {
            get { return GetInstance(KnownFolderType.History); }
        }

        /// <summary>
        /// The per-user ImplicitAppShortcuts folder. Introduced in Windows 7.
        /// Defaults to &quot;%APPDATA%\Microsoft\Internet Explorer\Quick Launch\User Pinned\ImplicitAppShortcuts&quot;.
        /// </summary>
        public static KnownFolder ImplicitAppShortcuts
        {
            get { return GetInstance(KnownFolderType.ImplicitAppShortcuts); }
        }

        /// <summary>
        /// The per-user Temporary Internet Files folder.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Temporary Internet Files&quot;.
        /// </summary>
        public static KnownFolder InternetCache
        {
            get { return GetInstance(KnownFolderType.InternetCache); }
        }

        /// <summary>
        /// The per-user Libraries folder. Introduced in Windows 7.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries&quot;.
        /// </summary>
        public static KnownFolder Libraries
        {
            get { return GetInstance(KnownFolderType.Libraries); }
        }

        /// <summary>
        /// The per-user Links folder.
        /// Defaults to &quot;%USERPROFILE%\Links&quot;.
        /// </summary>
        public static KnownFolder Links
        {
            get { return GetInstance(KnownFolderType.Links); }
        }

        /// <summary>
        /// The per-user Local folder.
        /// Defaults to &quot;%LOCALAPPDATA%&quot; (&quot;%USERPROFILE%\AppData\Local&quot;)&quot;.
        /// </summary>
        public static KnownFolder LocalAppData
        {
            get { return GetInstance(KnownFolderType.LocalAppData); }
        }

        /// <summary>
        /// The per-user LocalLow folder.
        /// Defaults to &quot;%USERPROFILE%\AppData\LocalLow&quot;.
        /// </summary>
        public static KnownFolder LocalAppDataLow
        {
            get { return GetInstance(KnownFolderType.LocalAppDataLow); }
        }

        /// <summary>
        /// The fixed LocalizedResourcesDir folder.
        /// Points to &quot;%WINDIR%\resources\0409&quot; (code page).
        /// </summary>
        public static KnownFolder LocalizedResourcesDir
        {
            get { return GetInstance(KnownFolderType.LocalizedResourcesDir); }
        }

        /// <summary>
        /// The per-user Music folder.
        /// Defaults to &quot;%USERPROFILE%\Music&quot;.
        /// </summary>
        public static KnownFolder Music
        {
            get { return GetInstance(KnownFolderType.Music); }
        }

        /// <summary>
        /// The per-user Music library. Introduced in Windows 7.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Music.library-ms&quot;.
        /// </summary>
        public static KnownFolder MusicLibrary
        {
            get { return GetInstance(KnownFolderType.MusicLibrary); }
        }

        /// <summary>
        /// The per-user Network Shortcuts folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Network Shortcuts&quot;.
        /// </summary>
        public static KnownFolder NetHood
        {
            get { return GetInstance(KnownFolderType.NetHood); }
        }

        /// <summary>
        /// The per-user Original Images folder. Introduced in Windows Vista.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows Photo Gallery\Original Images&quot;.
        /// </summary>
        public static KnownFolder OriginalImages
        {
            get { return GetInstance(KnownFolderType.OriginalImages); }
        }

        /// <summary>
        /// The per-user Slide Shows folder. Introduced in Windows Vista.
        /// Defaults to &quot;%USERPROFILE%\Pictures\Slide Shows&quot;.
        /// </summary>
        public static KnownFolder PhotoAlbums
        {
            get { return GetInstance(KnownFolderType.PhotoAlbums); }
        }

        /// <summary>
        /// The per-user Pictures library. Introduced in Windows 7.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Pictures.library-ms&quot;.
        /// </summary>
        public static KnownFolder PicturesLibrary
        {
            get { return GetInstance(KnownFolderType.PicturesLibrary); }
        }

        /// <summary>
        /// The per-user Pictures folder.
        /// Defaults to &quot;%USERPROFILE%\Pictures&quot;.
        /// </summary>
        public static KnownFolder Pictures
        {
            get { return GetInstance(KnownFolderType.Pictures); }
        }

        /// <summary>
        /// The per-user Playlists folder.
        /// Defaults to &quot;%USERPROFILE%\Music\Playlists&quot;.
        /// </summary>
        public static KnownFolder Playlists
        {
            get { return GetInstance(KnownFolderType.Playlists); }
        }

        /// <summary>
        /// The per-user Printer Shortcuts folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Printer Shortcuts&quot;.
        /// </summary>
        public static KnownFolder PrintHood
        {
            get { return GetInstance(KnownFolderType.PrintHood); }
        }

        /// <summary>
        /// The fixed user profile folder.
        /// Defaults to &quot;%USERPROFILE%&quot; (&quot;%SYSTEMDRIVE%\USERS\%USERNAME%&quot;)&quot;.
        /// </summary>
        public static KnownFolder Profile
        {
            get { return GetInstance(KnownFolderType.Profile); }
        }

        /// <summary>
        /// The fixed ProgramData folder.
        /// Points to &quot;%ALLUSERSPROFILE%&quot; (&quot;%PROGRAMDATA%&quot;, &quot;%SYSTEMDRIVE%\ProgramData&quot;).
        /// </summary>
        public static KnownFolder ProgramData
        {
            get { return GetInstance(KnownFolderType.ProgramData); }
        }

        /// <summary>
        /// The fixed Program Files folder.
        /// This is the same as the <see cref="ProgramFilesX86"/> known folder in 32-bit applications or the
        /// <see cref="ProgramFilesX64"/> known folder in 64-bit applications.
        /// Points to %SYSTEMDRIVE%\Program Files on a 32-bit operating system or in 64-bit applications on a 64-bit
        /// operating system and to %SYSTEMDRIVE%\Program Files (x86) in 32-bit applications on a 64-bit operating
        /// system.
        /// </summary>
        public static KnownFolder ProgramFiles
        {
            get { return GetInstance(KnownFolderType.ProgramFiles); }
        }

        /// <summary>
        /// The fixed Program Files folder (64-bit forced).
        /// This known folder is unsupported in 32-bit applications.
        /// Points to %SYSTEMDRIVE%\Program Files.
        /// </summary>
        public static KnownFolder ProgramFilesX64
        {
            get { return GetInstance(KnownFolderType.ProgramFilesX64); }
        }

        /// <summary>
        /// The fixed Program Files folder (32-bit forced).
        /// This is the same as the <see cref="ProgramFiles"/> known folder in 32-bit applications.
        /// Points to &quot;%SYSTEMDRIVE%\Program Files&quot; on a 32-bit operating system and to
        /// &quot;%SYSTEMDRIVE%\Program Files (x86)&quot; on a 64-bit operating system.
        /// </summary>
        public static KnownFolder ProgramFilesX86
        {
            get { return GetInstance(KnownFolderType.ProgramFilesX86); }
        }

        /// <summary>
        /// The fixed Common Files folder.
        /// This is the same as the <see cref="ProgramFilesCommonX86"/> known folder in 32-bit applications or the
        /// <see cref="ProgramFilesCommonX64"/> known folder in 64-bit applications.
        /// Points to&quot; %PROGRAMFILES%\Common Files&quot; on a 32-bit operating system or in 64-bit applications on
        /// a 64-bit operating system and to &quot;%PROGRAMFILES(X86)%\Common Files&quot; in 32-bit applications on a
        /// 64-bit operating system.
        /// </summary>
        public static KnownFolder ProgramFilesCommon
        {
            get { return GetInstance(KnownFolderType.ProgramFilesCommon); }
        }

        /// <summary>
        /// The fixed Common Files folder (64-bit forced).
        /// This known folder is unsupported in 32-bit applications.
        /// Points to &quot;%PROGRAMFILES%\Common Files&quot;.
        /// </summary>
        public static KnownFolder ProgramFilesCommonX64
        {
            get { return GetInstance(KnownFolderType.ProgramFilesCommonX64); }
        }

        /// <summary>
        /// The fixed Common Files folder (32-bit forced).
        /// This is the same as the <see cref="ProgramFilesCommon"/> known folder in 32-bit applications.
        /// Points to &quot;%PROGRAMFILES%\Common Files&quot; on a 32-bit operating system and to
        /// &quot;%PROGRAMFILES(X86)%\Common Files&quot; on a 64-bit operating system.
        /// </summary>
        public static KnownFolder ProgramFilesCommonX86
        {
            get { return GetInstance(KnownFolderType.ProgramFilesCommonX86); }
        }

        /// <summary>
        /// The per-user Programs folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu\Programs&quot;.
        /// </summary>
        public static KnownFolder Programs
        {
            get { return GetInstance(KnownFolderType.Programs); }
        }

        /// <summary>
        /// The fixed Public folder. Introduced in Windows Vista.
        /// Defaults to &quot;%PUBLIC%&quot; (&quot;%SYSTEMDRIVE%\Users\Public)&quot;.
        /// </summary>
        public static KnownFolder Public
        {
            get { return GetInstance(KnownFolderType.Public); }
        }

        /// <summary>
        /// The common Public Desktop folder.
        /// Defaults to &quot;%PUBLIC%\Desktop&quot;.
        /// </summary>
        public static KnownFolder PublicDesktop
        {
            get { return GetInstance(KnownFolderType.PublicDesktop); }
        }

        /// <summary>
        /// The common Public Documents folder.
        /// Defaults to &quot;%PUBLIC%\Documents&quot;.
        /// </summary>
        public static KnownFolder PublicDocuments
        {
            get { return GetInstance(KnownFolderType.PublicDocuments); }
        }

        /// <summary>
        /// The common Public Downloads folder. Introduced in Windows Vista.
        /// Defaults to &quot;%PUBLIC%\Downloads&quot;.
        /// </summary>
        public static KnownFolder PublicDownloads
        {
            get { return GetInstance(KnownFolderType.PublicDownloads); }
        }

        /// <summary>
        /// The common GameExplorer folder. Introduced in Windows Vista.
        /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\GameExplorer&quot;.
        /// </summary>
        public static KnownFolder PublicGameTasks
        {
            get { return GetInstance(KnownFolderType.PublicGameTasks); }
        }

        /// <summary>
        /// The common Libraries folder. Introduced in Windows 7.
        /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Libraries&quot;.
        /// </summary>
        public static KnownFolder PublicLibraries
        {
            get { return GetInstance(KnownFolderType.PublicLibraries); }
        }

        /// <summary>
        /// The common Public Music folder.
        /// Defaults to &quot;%PUBLIC%\Music&quot;.
        /// </summary>
        public static KnownFolder PublicMusic
        {
            get { return GetInstance(KnownFolderType.PublicMusic); }
        }

        /// <summary>
        /// The common Public Pictures folder.
        /// Defaults to &quot;%PUBLIC%\Pictures&quot;.
        /// </summary>
        public static KnownFolder PublicPictures
        {
            get { return GetInstance(KnownFolderType.PublicPictures); }
        }

        /// <summary>
        /// The common Ringtones folder. Introduced in Windows 7.
        /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Ringtones&quot;.
        /// </summary>
        public static KnownFolder PublicRingtones
        {
            get { return GetInstance(KnownFolderType.PublicRingtones); }
        }

        /// <summary>
        /// The common Public Account Pictures folder. Introduced in Windows 8.
        /// Defaults to &quot;%PUBLIC%\AccountPictures&quot;.
        /// </summary>
        public static KnownFolder PublicUserTiles
        {
            get { return GetInstance(KnownFolderType.PublicUserTiles); }
        }

        /// <summary>
        /// The common Public Videos folder.
        /// Defaults to &quot;%PUBLIC%\Videos&quot;.
        /// </summary>
        public static KnownFolder PublicVideos
        {
            get { return GetInstance(KnownFolderType.PublicVideos); }
        }

        /// <summary>
        /// The per-user Quick Launch folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Internet Explorer\Quick Launch&quot;.
        /// </summary>
        public static KnownFolder QuickLaunch
        {
            get { return GetInstance(KnownFolderType.QuickLaunch); }
        }

        /// <summary>
        /// The per-user Recent Items folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Recent&quot;.
        /// </summary>
        public static KnownFolder Recent
        {
            get { return GetInstance(KnownFolderType.Recent); }
        }

        /// <summary>
        /// The common Recorded TV library. Introduced in Windows 7.
        /// Defaults to &quot;%PUBLIC%\RecordedTV.library-ms&quot;.
        /// </summary>
        public static KnownFolder RecordedTVLibrary
        {
            get { return GetInstance(KnownFolderType.RecordedTVLibrary); }
        }

        /// <summary>
        /// The fixed Resources folder.
        /// Points to &quot;%WINDIR%\Resources&quot;.
        /// </summary>
        public static KnownFolder ResourceDir
        {
            get { return GetInstance(KnownFolderType.ResourceDir); }
        }

        /// <summary>
        /// The per-user Ringtones folder. Introduced in Windows 7.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Ringtones&quot;.
        /// </summary>
        public static KnownFolder Ringtones
        {
            get { return GetInstance(KnownFolderType.Ringtones); }
        }

        /// <summary>
        /// The per-user Roaming folder.
        /// Defaults to &quot;%APPDATA%&quot; (&quot;%USERPROFILE%\AppData\Roaming&quot;).
        /// </summary>
        public static KnownFolder RoamingAppData
        {
            get { return GetInstance(KnownFolderType.RoamingAppData); }
        }

        /// <summary>
        /// The per-user RoamedTileImages folder. Introduced in Windows 8.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\RoamedTileImages&quot;.
        /// </summary>
        public static KnownFolder RoamedTileImages
        {
            get { return GetInstance(KnownFolderType.RoamedTileImages); }
        }

        /// <summary>
        /// The per-user RoamingTiles folder. Introduced in Windows 8.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\RoamingTiles&quot;.
        /// </summary>
        public static KnownFolder RoamingTiles
        {
            get { return GetInstance(KnownFolderType.RoamingTiles); }
        }

        /// <summary>
        /// The common Sample Music folder.
        /// Defaults to &quot;%PUBLIC%\Music\Sample Music&quot;.
        /// </summary>
        public static KnownFolder SampleMusic
        {
            get { return GetInstance(KnownFolderType.SampleMusic); }
        }

        /// <summary>
        /// The common Sample Pictures folder.
        /// Defaults to &quot;%PUBLIC%\Pictures\Sample Pictures&quot;.
        /// </summary>
        public static KnownFolder SamplePictures
        {
            get { return GetInstance(KnownFolderType.SamplePictures); }
        }

        /// <summary>
        /// The common Sample Playlists folder. Introduced in Windows Vista.
        /// Defaults to &quot;%PUBLIC%\Music\Sample Playlists&quot;.
        /// </summary>
        public static KnownFolder SamplePlaylists
        {
            get { return GetInstance(KnownFolderType.SamplePlaylists); }
        }

        /// <summary>
        /// The common Sample Videos folder.
        /// Defaults to &quot;%PUBLIC%\Videos\Sample Videos&quot;.
        /// </summary>
        public static KnownFolder SampleVideos
        {
            get { return GetInstance(KnownFolderType.SampleVideos); }
        }

        /// <summary>
        /// The per-user Saved Games folder. Introduced in Windows Vista.
        /// Defaults to &quot;%USERPROFILE%\Saved Games&quot;.
        /// </summary>
        public static KnownFolder SavedGames
        {
            get { return GetInstance(KnownFolderType.SavedGames); }
        }

        /// <summary>
        /// The per-user Searches folder.
        /// Defaults to &quot;%USERPROFILE%\Searches&quot;.
        /// </summary>
        public static KnownFolder SavedSearches
        {
            get { return GetInstance(KnownFolderType.SavedSearches); }
        }

        /// <summary>
        /// The per-user Screenshots folder. Introduced in Windows 8.
        /// Defaults to &quot;%USERPROFILE%\Pictures\Screenshots&quot;.
        /// </summary>
        public static KnownFolder Screenshots
        {
            get { return GetInstance(KnownFolderType.Screenshots); }
        }

        /// <summary>
        /// The per-user History folder. Introduced in Windows 8.1.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\ConnectedSearch\History&quot;.
        /// </summary>
        public static KnownFolder SearchHistory
        {
            get { return GetInstance(KnownFolderType.SearchHistory); }
        }

        /// <summary>
        /// The per-user Templates folder. Introduced in Windows 8.1.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\ConnectedSearch\Templates&quot;.
        /// </summary>
        public static KnownFolder SearchTemplates
        {
            get { return GetInstance(KnownFolderType.SearchTemplates); }
        }

        /// <summary>
        /// The per-user SendTo folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\SendTo&quot;.
        /// </summary>
        public static KnownFolder SendTo
        {
            get { return GetInstance(KnownFolderType.SendTo); }
        }

        /// <summary>
        /// The common Gadgets folder. Introduced in Windows 7.
        /// Defaults to &quot;%ProgramFiles%\Windows Sidebar\Gadgets&quot;.
        /// </summary>
        public static KnownFolder SidebarDefaultParts
        {
            get { return GetInstance(KnownFolderType.SidebarDefaultParts); }
        }

        /// <summary>
        /// The per-user Gadgets folder. Introduced in Windows 7.
        /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows Sidebar\Gadgets&quot;.
        /// </summary>
        public static KnownFolder SidebarParts
        {
            get { return GetInstance(KnownFolderType.SidebarParts); }
        }

        /// <summary>
        /// The per-user OneDrive folder. Introduced in Windows 8.1.
        /// Defaults to &quot;%USERPROFILE%\OneDrive&quot;.
        /// </summary>
        public static KnownFolder SkyDrive
        {
            get { return GetInstance(KnownFolderType.SkyDrive); }
        }

        /// <summary>
        /// The per-user OneDrive Camera Roll folder. Introduced in Windows 8.1.
        /// Defaults to &quot;%USERPROFILE%\OneDrive\Pictures\Camera Roll&quot;.
        /// </summary>
        public static KnownFolder SkyDriveCameraRoll
        {
            get { return GetInstance(KnownFolderType.SkyDriveCameraRoll); }
        }

        /// <summary>
        /// The per-user OneDrive Documents folder. Introduced in Windows 8.1.
        /// Defaults to &quot;%USERPROFILE%\OneDrive\Documents&quot;.
        /// </summary>
        public static KnownFolder SkyDriveDocuments
        {
            get { return GetInstance(KnownFolderType.SkyDriveDocuments); }
        }

        /// <summary>
        /// The per-user OneDrive Pictures folder. Introduced in Windows 8.1.
        /// Defaults to &quot;%USERPROFILE%\OneDrive\Pictures&quot;.
        /// </summary>
        public static KnownFolder SkyDrivePictures
        {
            get { return GetInstance(KnownFolderType.SkyDrivePictures); }
        }

        /// <summary>
        /// The per-user Start Menu folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu&quot;.
        /// </summary>
        public static KnownFolder StartMenu
        {
            get { return GetInstance(KnownFolderType.StartMenu); }
        }

        /// <summary>
        /// The per-user Startup folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu\Programs\StartUp&quot;.
        /// </summary>
        public static KnownFolder Startup
        {
            get { return GetInstance(KnownFolderType.Startup); }
        }

        /// <summary>
        /// The fixed System32 folder.
        /// This is the same as the <see cref="SystemX86"/> known folder in 32-bit applications.
        /// Points to &quot;%WINDIR%\system32&quot; on 32-bit operating systems or in 64-bit applications on a 64-bit
        /// operating system and to &quot;%WINDIR%\syswow64&quot; in 32-bit applications on a 64-bit operating system.
        /// </summary>
        public static KnownFolder System
        {
            get { return GetInstance(KnownFolderType.System); }
        }

        /// <summary>
        /// The fixed System32 folder (32-bit forced).
        /// This is the same as the <see cref="System"/> known folder in 32-bit applications.
        /// Points to &quot;%WINDIR%\syswow64&quot; in 64-bit applications or in 32-bit applications on a 64-bit
        /// operating system and to &quot;%WINDIR%\system32&quot; on 32-bit operating systems.
        /// </summary>
        public static KnownFolder SystemX86
        {
            get { return GetInstance(KnownFolderType.SystemX86); }
        }

        /// <summary>
        /// The per-user Templates folder.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Templates&quot;.
        /// </summary>
        public static KnownFolder Templates
        {
            get { return GetInstance(KnownFolderType.Templates); }
        }

        /// <summary>
        /// The per-user User Pinned folder. Introduced in Windows 7.
        /// Defaults to &quot;%APPDATA%\Microsoft\Internet Explorer\Quick Launch\User Pinned&quot;.
        /// </summary>
        public static KnownFolder UserPinned
        {
            get { return GetInstance(KnownFolderType.UserPinned); }
        }

        /// <summary>
        /// The fixed Users folder. Introduced in Windows Vista.
        /// Points to &quot;%SYSTEMDRIVE%\Users&quot;.
        /// </summary>
        public static KnownFolder UserProfiles
        {
            get { return GetInstance(KnownFolderType.UserProfiles); }
        }

        /// <summary>
        /// The per-user Programs folder. Introduced in Windows 7.
        /// Defaults to &quot;%LOCALAPPDATA%\Programs.&quot;.
        /// </summary>
        public static KnownFolder UserProgramFiles
        {
            get { return GetInstance(KnownFolderType.UserProgramFiles); }
        }

        /// <summary>
        /// The per-user common Programs folder. INtroduced in Windows 7.
        /// Defaults to &quot;%LOCALAPPDATA%\Programs\Common&quot;.
        /// </summary>
        public static KnownFolder UserProgramFilesCommon
        {
            get { return GetInstance(KnownFolderType.UserProgramFilesCommon); }
        }

        /// <summary>
        /// The per-user Videos folder.
        /// Defaults to &quot;%USERPROFILE%\Videos&quot;.
        /// </summary>
        public static KnownFolder Videos
        {
            get { return GetInstance(KnownFolderType.Videos); }
        }

        /// <summary>
        /// The per-user Videos library. Introduced in Windows 7.
        /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Videos.library-ms&quot;.
        /// </summary>
        public static KnownFolder VideosLibrary
        {
            get { return GetInstance(KnownFolderType.VideosLibrary); }
        }

        /// <summary>
        /// The fixed Windows folder.
        /// Points to &quot;%WINDIR%&quot;.
        /// </summary>
        public static KnownFolder Windows
        {
            get { return GetInstance(KnownFolderType.Windows); }
        }
        #endregion

        // ---- METHODS (PRIVATE) --------------------------------------------------------------------------------------

        private static KnownFolder GetInstance(KnownFolderType type)
        {
            // Check if the caching directory exists yet.
            if (_knownFolderInstances == null)
            {
                _knownFolderInstances = new Dictionary<KnownFolderType, KnownFolder>();
            }

            // Get a KnownFolder instance out of the cache dictionary or create it when not cached yet.
            KnownFolder knownFolder;
            if (!_knownFolderInstances.TryGetValue(type, out knownFolder))
            {
                knownFolder = new KnownFolder(type);
                _knownFolderInstances.Add(type, knownFolder);
            }
            return knownFolder;
        }
    }
}
