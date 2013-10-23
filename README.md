# EHR App Launcher
==============

VB.net application to launch IHS programs independently of platform.

This application loads an XML configuration file of applications to be launched. Each entry has an Application Name, Alias, 32bit path and 64bit path. 

When the application is run with command line arguments, it detects the architecture of the system it is running on, and runs the configured application from the appropriate path.

When the application is run without command line argumnets, it displays the configuration window to add / edit / deleete configured applications.

## Typical Configuration for site.
The application is intended to be installed on each workstation, and point to a common XML configuration file. When all workstations point to a common configuration file, you will only have to change the configuration one time for all workstations to accept the change.

Put the common XML configuration on a server where everyone has read access. i.e. \\fileserver\share\eal.xml.

## Installation
1. Unzip the release (

###
