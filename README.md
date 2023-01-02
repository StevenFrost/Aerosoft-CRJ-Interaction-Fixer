# Aerosoft CRJ Interaction Fixer
A small utility to generate a package which fixes various knobs with a secondary push interaction on the MSFS Aerosoft CRJ.

Overview
--------
After Sim Update 5 was released for Microsoft Flight Simulator, interactions on some of the Aerosoft CRJ knobs ceased to work correctly. Building a package to override the model behaviors and fix the issues was relatively simple, but unfortunately I was unable to obtain permission from Aerosoft to distribute modified versions of their model behavior XML files.

This console application generates the package directly on the end user's computer, avoiding the need to distribute the original files.

Fixed Elements
--------------
- CRS 1 & 2 PUSH DIRECT button
- SPEED IAS/MACH button
- HDG PUSH SYNC button
- ALT PUSH CANCEL button
- NAV SOURCE PUSH X-SIDE button
- BARO PUSH STD button

System Requirements
-------------------
- Aerosoft CRJ
- .NET Core 3.1 Runtime (download [here](https://dotnet.microsoft.com/download))

Usage
-----
1. Download the latest release
2. Extract the zip archive to a location of your choice
3. Run the extracted executable `AerosoftCRJInteractionFixer.exe`
4. Proceed through the application until it exits

If you wish to uninstall the fix at any point, simply delete the `aerosoft-crj-interaction-fix` package from your community folder.

Known Issues
------------
- The weather radar `GCS` button on the `GAIN` knob is not interactable
- The weather radar `Push Auto` button on the `TILT` knob is not interactable

Notes
-----
I am not associated with Aerosoft in any way and can't provide support for their products. Visit the Aerosoft forums and support portal for assistance with issues beyond the scope of this patch.

Please **do not** redistribute the package generated by this tool. It is intended only for use on the computer it was generated.
