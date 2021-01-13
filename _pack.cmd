set target=LPModManager.zip
set SEVENZIP=%programfiles%\7-Zip\7z.exe
IF EXIST %target% del %target%
"%SEVENZIP%" a %target% .\readme.txt .\bin\Release\LPLauncher.exe

