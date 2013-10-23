# EHR App Launcher
==============

VB.net application to launch IHS programs independently of platform.

This application loads an XML configuration file of applications to be launched. Each entry has an Application Name, Alias, 32bit path and 64bit path.

The reason this application is necessary, is that x32 & x64 systems have different paths for installed applications. EHR App Launcher works because it is always stored in the same on the workstation. It is hardcoded as c:\ehrAppLauncher\ . This directory must not be renamed, or located on any other drive than c:\ .

When the application is run with command line arguments, it detects the architecture of the system it is running on, and runs the configured application from the appropriate path.

When the application is run without command line argumnets, it displays the configuration window to add / edit / deleete configured applications.

## Typical Configuration for site.
The application is intended to be installed on each workstation, and point to a common XML configuration file. When all workstations point to a common configuration file, you will only have to change the configuration one time for all workstations to accept the change.

Put the common XML configuration on a server where everyone has read access. i.e. \\fileserver\share\eal.xml.

## Installation
1. Download latest .msi file from https://github.com/KalebClark/ehrAppLauncher/releases
2. Run the .msi file manually, or through Group Policy


## Configuration
Load the example eal.xml file located in c:\ehrAppLauncher. You may not need to change anything.

1. Make changes as necessary.
2. Save the configuration XML file to a network path (as described above)
3. Enter VuCentric EHR Design Mode.
4. Design->Desktop Properties
5. Click "Customize Menus"
6. Create new menu items for with the following action "c:\ehrAppLauncher\ehrAppLauncher.exe <alias>  $(patient.handle) $(PARAM.CPRS_HANDLE) <server IP Address> <server port>"

This software is copyright 2013 Kaleb Clark under the [GNU General Public License](http://www.gnu.org/licenses/gpl.html)
