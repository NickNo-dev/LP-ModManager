LifePlay Launcher / Mod-Manager ReadMe, Change Log and TODO List
==================================================================

ReadMe
********

Thanks for downloading the LifePlay Launcher and Module Manager (LPLauncher).
This file is intended to explain the basic functionality and usage of LPLauncher.

Content of this file:
- System Requirements & Installation
- How to use the launcher?
- How do I get my own mod / content into the repository?


System Requirements & Installation
************************************

LPLauncher requires Windows 7, 8 or 10 and .NET 4.0 Framework.
You need to put the LPLauncher.exe next to the "LifePlay.exe".

(Pro Tip: You can also supply the path to the life play installation 
as the first command line argument.)


How to use the launcher?
**************************

After double clicking on the "LPLauncher.exe" you will see the Launcher's main window.

It is separated into two areas: 

The repository on the left side. This is the place where all downloadable 
modules and addons (character packs, room presets etc.) are listed.

The local installation on the right side. This is your LifePlay installation 
with all mods that are currently installed.

To launch LifePlay click the green "Launch game" button in the bottom left corner.


Installing mods and addons
~~~~~~~~~~~~~~~~~~~~~~~~~~~~

To install or update a module/addon from the repository just double click it. 
LPLauncher will download the file and automatically install it into your local 
game folder.

New mods are enabled by default. They will be added to the bottom of the local 
installation list. (Alas they have highest priority, read on...)


Module priority
~~~~~~~~~~~~~~~~~

The priority order in LifePlay is bottom up, so everything that is at the end 
of the module list, has the higher priority. (This is just important for modules 
that overwrite base game or other module's functionality.)

To move a module to a higher / lower priority just drag & drop it to the desired position 
in the local list.


Disabling / Enabling modules
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Installed modules can be disabled by double clicking them. They will get a [disabled] tag.
Double click again to enable them again.

You cannot disable addons (character packs and room presets) - the in game editors will 
always "see" presets supplied by these addons unless you delete the addon.


Deleting modules
~~~~~~~~~~~~~~~~~~

After selecting a module you can click on the "Delete selected module" button located in
the middle of the LPLauncher window.

The module will be erased permanently. 
(THERE IS NO TRASHCAN AND NO UNDO!)


Updating modules
~~~~~~~~~~~~~~~~~~

If there is an update available in the repository the updated module will get an [updated] 
tag in the repository list (left pane).

Double click it, to install the update.

If you do not want to install all updates manually you can click the "Update all installed 
modules" button in the bottom left corner of the LPLauncher window.

The "Update All" function will display a list of all updated modules and after your 
confirmation the updates will be downloaded and installed automatically.


Locating modules 
~~~~~~~~~~~~~~~~~~

If you click on a module (left or right pane) the counterpart (if any) will automatically 
be selected in the opposite list. This will help you to find the respective module.


How do I get my own mod / content into the repository?
********************************************************

To add your own LifePlay content you will have to upload it to the repository 
(https://github.com/NickNo-dev/LP-Mods) or send it to NickNo (F95 forum or 
LifePlay discord) somehow.

To supply a mod it needs a lpmod file with the following information:

MODULE_UNIQUEID: your_mods_unique_id
MODULE_NAME: Some fancy module name
MODULE_AUTHOR: Who Are you?
MODULE_LINK: http://link.to.your.facebook.profile
MODULE_DESCRIPTION: A description of what your module actually does...
MODULE_REQUIREMENTS: EMPTY or any dependencies
MODULE_VERSION: YOUR MODULE's VERSION

So you see, the MODULE_VERSION tag is required in addition to normal LPMods.
The LPLauncher only checks if the locally installed version is different from 
the repo version. If so, it will flag the module as updated.

If you are just adding character or room presets, an lpaddon file is required instead.
The structure is the same, the only real difference is, that LifePlay will not load them
as real modules.

What is the difference between a MODULE (lpmod) and an ADDON (lpaddon)?
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Addons just add some presets (and maybe later something else) to the game, 
but do nod modify or extend gameplay (like stories etc.). 
They don't have actions or new scenes.

Modules on the other hand do modify or extend the game. Every module will be 
loaded and parsed by LifePlay if enabled.




...



..



.



Well, this is the end of the ReadMe.txt. Thanks your reading up here! ;-) 
If you miss any information please ask on the F95 forum or in LifePlay discord.

Links:

LPLauncher home: https://github.com/NickNo-dev/LP-ModManager
LifePlay F95 thread: https://f95zone.to/threads/lifeplay-v2-17-vinfamy.11321
LifePlay discord: https://discord.gg/n3aS5b


-- Cu, NickNo
