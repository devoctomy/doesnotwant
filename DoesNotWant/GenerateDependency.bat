@echo off
set SOLUTIONDIR=%1
set OUTPUTFILE=%2
echo Starting Dependency check...
echo ^<?xml version="1.0" encoding="UTF-8"?^> > %OUTPUTFILE%
echo ^<Wix xmlns="http://schemas.microsoft.com/wix/2006/wi"^> >> %OUTPUTFILE%
echo   ^<Fragment^> >> %OUTPUTFILE%
echo     ^<ComponentGroup Id="MesDependance" Directory="INSTALLFOLDER"^> >> %OUTPUTFILE%

for %%F in (%SOLUTIONDIR%DoesNotWant\bin\Debug\*.dll) do (
   echo "-- Adding %%~nxF" 
    echo       ^<Component Id="%%~nxF"^> >> %OUTPUTFILE%
    echo                     ^<File  Id="%%~nxF" Name="%%~nxF" Source="%%~dpnxF" Vital="yes" KeyPath="yes" DiskId="1"/^> >> %OUTPUTFILE%
    echo       ^</Component^> >> %OUTPUTFILE%
)

for %%F in (%SOLUTIONDIR%DoesNotWant\*.json) do (
   echo "-- Adding %%~nxF" 
    echo       ^<Component Id="%%~nxF"^> >> %OUTPUTFILE%
    echo                     ^<File  Id="%%~nxF" Name="%%~nxF" Source="%%~dpnxF" Vital="yes" KeyPath="yes" DiskId="1"/^> >> %OUTPUTFILE%
    echo       ^</Component^> >> %OUTPUTFILE%
)

echo     ^</ComponentGroup^> >> %OUTPUTFILE%
echo   ^</Fragment^> >> %OUTPUTFILE%
echo ^</Wix^> >> %OUTPUTFILE%
echo Dependency check done.