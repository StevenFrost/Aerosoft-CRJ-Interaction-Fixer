# Aerosoft CRJ Interaction Fixer
A small utility to generate a package which fixes various knobs with a secondary push interaction on the MSFS Aerosoft CRJ.

Overview
--------
After Sim Update 5 was released for Microsoft Flight Simulator, interactions on some of the Aerosoft CRJ knobs ceased to work correctly. Building a package to override the model behaviors and fix the issues was relatively simple, but unfortunately I was unable to obtain permission from Aerosoft to distribute modified versions of their model behavior XML files.

To overcome this hurdle, I built a simple console application which generates the package directly on the end user's computer, avoiding the need to distribute the original files.

Usage
-----
1. Download the latest release
2. Run AerosoftCRJInteractionFixer.exe
3. Proceed through the application until it exits

If you wish to uninstall the fix at any point, simply delete the `aerosoft-crj-interaction-fix` package from your community folder.
