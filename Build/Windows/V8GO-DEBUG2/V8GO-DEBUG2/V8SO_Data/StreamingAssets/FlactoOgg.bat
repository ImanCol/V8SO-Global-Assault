@echo off
setlocal enabledelayedexpansion

IF "%~1"=="" (
    echo No se ha arrastrado ninguna carpeta.
    pause
    exit
)

set "folderPath=%~1"

set "folderPath=%folderPath:"=""%"

for /r "%folderPath%" %%F in (*.flac) do (
    oggenc2.exe "%%F" -o "%%~dpnF.ogg"
)

echo Conversión completada.
pause
