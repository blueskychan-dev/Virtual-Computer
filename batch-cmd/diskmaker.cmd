@echo off
echo Creating Folder C:\VCDISK
mkdir C:\VCDISK
echo Welcome to Disk Maker!
echo M = MB G = GB
set /p size=Size Of Disk eg. 1G: 
echo Type of disk Helper: If you need Dynamically Allocated please type qcow2 but if you need fixed size please SELECT raw.
set /p type=type of disk: 
set /p name=Name of disk: 
echo Creating Disk to location C:\VCDISK\%name%.img
qemu-img create -f %type% C:\VCDISK\%name%.img %size%