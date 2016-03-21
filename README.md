# KnownFolders
.NET classes to retrieving and change all special Windows folders

## Introduction
Since many years, back to Windows 98 as far as I remember, users have special folders in their home directory, called "My Documents", "My Music", "My Pictures" or "My Videos". These were kept relatively untouched up to XP, and their path was retrieved easily: Simply calling the `System.Environment.GetFolderPath()` function and passing an enumeration value of `System.Environment.SpecialFolder` was enough, since the enumeration contains entries for `MyDocuments`, `MyMusic`, `MyPictures` and so on.

However, the newer folders which exist since Windows Vista, are not listed in the enumeration and cannot be retrieved that way. The reason for this is that the .NET framework was not updated to mirror the changes in the user home directory, and people started to use hacky and even wrong solutions to get the folder paths to the other folders. The correct way to retrieve (and even set) these paths are wrapped in this NuGet package, in an object oriented way you would expect from .NET.

To read more about why most of the "lazy" solutions are wrong, have a look at my [CodeProject article](http://www.codeproject.com/Articles/878605/Getting-All-Special-Folders-in-NET), which was the motivation to create this NGet package.

## Usage

Needless to say, install the NuGet package from the [NuGet gallery](https://www.nuget.org/packages/Syroot.Windows.IO.KnownFolders/1.0.0) first.

The starting point is a `KnownFolder` instance, which represents exactly one special folder. It offers access to the following:

  - `string Path { get; set; }`: The current path (which might already be customized by the user). This is what you want in most cases.
  - `string DefaultPath { get; set; }`: The default path the folder has if it would not have been redirected.
  - `string ExpandedPath { get; set; }`: Same as `Path`, but with all environment variables expanded.
  - `Create()`: This method creates and initializes the known folder, e.g. creates the folder at the current path and writes the corresponding `Desktop.ini` (to set up the icon and localized name).

To retrieve a `KnownFolder` instance, there are two ways, depending on what you want to do:

  1. The easiest way is to use one of the many properties in the static `KnownFolders` class, which contains one property for each special folder.
  2. If you want to get the paths of another user than the current one (required rights assumed), you have to use the constructor of the `KnownFolder` class. You pass in a value of the `KnownFolderType` enumeration (which contains one member for each special folder) and the `WindowsIdentity` instance of the user to impersonate.

The test application included in the source shows how to enumerate all known folders of the Windows system.

Please note that the CodeProject article linked above shows a different API, I polished it for this NuGet to be more object-oriented as it also provides more features.

## License

<a href="http://www.wtfpl.net/"><img src="http://www.wtfpl.net/wp-content/uploads/2012/12/wtfpl.svg" height="20" alt="WTFPL" /></a> WTFPL

    Copyright © 2016 syroot.com <admin@syroot.com>
    This work is free. You can redistribute it and/or modify it under the
    terms of the Do What The Fuck You Want To Public License, Version 2,
    as published by Sam Hocevar. See the COPYING file for more details.
