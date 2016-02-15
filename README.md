#Windows Authenticator

*WinAuth is a portable, open-source Authenticator for Windows that provides counter or time-based RFC 6238 authenticators and common implementations, such as the Google Authenticator. WinAuth can be used with many Bitcoin trading websites as well as games, supporting Battle.net (World of Warcraft, Hearthstone, Heroes of the Storm, Diablo), Guild Wars 2, Glyph (Rift and ArcheAge), WildStar, RuneScape, SWTOR and Steam.*

----

##Download Latest Version

The latest stable version is WinAuth 3.3 and is available to download from this source repository, or as a pre-compiled binary from [WinAuth downloads](https://winauth.com/download).

----

##WinAuth 3.4 BETA (latest development)

Please download 3.3. if you are just looking for WinAuth and not wanting to test the latest features.

This version adds support for Steam trading confirmations, importing from Android files and SteamDesktopAuthenticator.

[WinAuth-3.4.15 BETA](https://winauth.com/downloads/3.x/WinAuth-3.4.15.zip)

<img src="https://winauth.com/wp-content/uploads/2013/07/steamconf1.png" alt="WinAuth 3.4 Steam Trading">

###Portable Version (Windows 7 / .Net 3.5)

There is now also a .Net 3.5 build of WinAuth, which can be run on Windows 7 installations "out of the box".

[WinAuth-3.4.15 BETA for .NET 3.5](https://winauth.com/downloads/3.x/WinAuth-3.4.15-NET35.zip)

##WinAuth 3.3 (latest stable)

WinAuth provides an alternative solution to combine various two-factor authenticator services in one convenient place.

[Latest Version (WinAuth-3.3.7)](https://winauth.com/downloads/3.x/WinAuth-3.3.7.zip)

<img src="https://winauth.com/images/winauth3-preview.png" alt="WinAuth3 Preview" />

Updates:

  * 3.3.7 - Issue [257](https://github.com/winauth/winauth/issues/257): Fix Steam change causing crash when creating new Steam authenticator. Added view of complete Steam data for exporting.

Features include:

  * Support for time-based RFC 6238 authenticators (e.g. Google Authenticator) and HOTP counter-based authenticators
  * Supports Battle.net (World of Warcraft, Hearthstone, Heroes of the Storm, Diablo III), GuildWars 2, Trion / Glyph (Rift, ArcheAge), RuneScape, WildStar, SWTOR and Steam
  * Supports many Bitcoin trading websites such as Coinbase, Gemini, Circle, Bitstamp, BTC-e, Cryptsy
  * Displays multiple authenticators simultaneously
  * Codes displayed and refreshed automatically or on demand
  * Data is protected with your password, locked to Windows machine or account, or a YubiKey
  * Additional password protection per authenticator
  * Restore features for supported authenticators, e.g. Battle.net and Rift
  * Selection of standard or custom icons
  * Hot-key binding with standard or custom actions, such as code notification, keyboard input, and copy to clipboard
  * Portable mode preventing changes to other files or registry settings
  * Import and export in UriKeyFormat and from Authenticator Plus for Android 

Visit [WinAuth.com](https://winauth.com) for more information.

###How To Use

Use the following link to download the latest version of WinAuth, or go to the [downloads](https://winauth.com/download) page on winauth.com.

Requires [Microsoft .Net 4.5](http://www.microsoft.com/en-us/download/details.aspx?id=30653)

To use:
  * Download the latest stable version of WinAuth
  * There is no installation required, just open the zip file and extract the WinAuth.exe file to anywhere on your computer
  * Double-click or run WinAuth.exe
  * Click the Add button to add or import an authenticator
  * Right-click any authenticator to bring up context menu
  * Click the icon on the right to show the current code, if auto-refresh is not enabled
  * Click cog/options icon for program options

To compile and build from source:
  * Download source code file or clone project
  * Requires Microsoft Visual Studio 2012 (previous versions will work, but you will need to create your own solution/project files)
  * nuget is used for dependencies
  * any other dependencies are included in the source tree in the 3rd Party folder
  * Use [ILMerge](http://research.microsoft.com/en-us/people/mbarnett/ilmerge.aspx ) to combine assemblies into one single exe file

###New Features

Version 3.3 includes the new SteamGuard Mobile Authenticator, integration with YubiKey to enhance your authenticator security and a HOTP implementation.

####Steam Guard

WinAuth can be registered as a new mobile device to create a Steam authenticator and displays the appropriate 5 character codes.

<img src="https://winauth.com/wp-content/uploads/2013/07/steam.png" alt="WinAuth Supports Steam" />

You MUST attach an SMS-capable phone number to your account before your activate your Steam authenticator, since the confirmation code are no longer sent by email, only over SMS.

Please read about the [Steam Guard Mobile Authenticator](https://winauth.com/2015/06/11/steam-guard-mobile/) for more information.

####YubiKey

WinAuth can now be used with a YubiKey to further protect the data. This will help ensure the authenticators’ secret keys cannot be read by anyone even when they have physical access to your computer.

<img src="https://winauth.com/wp-content/uploads/2013/07/yubi1.png" alt="Using YubiKey with WinAuth" />

Clicking the options (cog) icon, and choosing "Change Protection...", has a new option to "Lock with a YubiKey". Ticking this will check your system for a compatible YubiKey and walk you through setting it up. You can either use an existing slot's configuration or have WinAuth generate a random secret to store on the YubiKey.

You must keep your YubiKey plugged in while using WinAuth. There will be no way to recover your authenticator data if your YubiKey is lost or damaged without programming another YubiKey with the same secret, or restoring from backups.

*YubiKey Standard / NEO 2.2.x or later is required.*

----

##COMMON QUESTIONS

####Is it secure? Is it safe?

All authenticators just provide another layer of security. None are 100% effective.

A physical/keychain device is by far the best protection. Although still subject to any man-in-the-middle attack, there is no way to get at the secret key stored within it. If you are at all concerned, get one of these.

An iPhone app or app on a non-rooted Android device is also secure. There is no way to get at the secret key stored on the device, however, some apps provides way to export the key that could compromise your authenticator if you do not physically protect your phone. Also if those apps backup their data elsewhere, that data could be vulnerable.

A rooted-Android phone can have your secret key read off it by an app with access. Some apps also do not encrypt the keys and so this should be considered risky.

WinAuth stores you secret key in an encrypted file on your computer. Whilst it cannot therefore provide the same security as a separate physical device, as much as possible has been done to protect the key on your machine. As above, physical access to your machine would be the only way to compromise any authenticator.

####I'm concerned this might be a virus / malware / keylogger

WinAuth has been around and used since mid-2010 and has been downloaded by thousands of users.

It has always been open-source allowing everyone to inspect and review the code. A binary is provided, but the source code is always released simultaneously so that you can review the code and build it yourself.

No personal information is sent out to any other 3rd party servers. It never even sees your account information, only your authenticator details.

There are no other executables installed on your machine. There is no installer doing things you are unable to monitor. WinAuth is portable so you can just run it from anywhere.

####I found WinAuth on another website, is it the same thing?

WinAuth source code is uploaded to GitHub at http://github.com/winauth/winauth and pre-built binaries and installers are on [winauth.com](https://winauth.com). It had been hosted using Google Code at https://code.google.com/p/winauth, but has been moved to GiHub since Google Code is being closed down. It is not published anywhere else, so please do not download any other programs claiming to be WinAuth.

####Where does WinAuth save my authenticator information?

Unlike some other authenticator applications, WinAuth does not store/send your information to any 3rd party servers. Your authenticator information is saved by default in your account roaming profile, i.e. c:\Users\<username>\AppData\Roaming\WinAuth. However, this file can be moved anywhere and passed into WinAuth when run.

----

##More Information

All trademarks are recognised, including but not limited to:

  * Blizzard, Battle.net, World of Warcraft, Starcraft, Diablo
  * ArenaNet, Guild Wars 2
  * Trion, Rift
  * Google
  * Microsoft
  * Steam

----

##Author

WinAuth was written by Colin Mackie. Copyright (C) 2010-2015.

Bitcoin donations can be sent to `1C4bMkMATViiWYsmJSDUx2MruWM785C36Y`

----

##License

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License  along with this program.  If not, see http://www.gnu.org/licenses/.
