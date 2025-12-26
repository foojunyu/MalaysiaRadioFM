@echo off
REM Build script for Malaysia Radio FM Windows Application

echo ====================================
echo Malaysia Radio FM Build Script
echo ====================================
echo.

REM Check if .NET SDK is installed
dotnet --version >nul 2>&1
if %errorlevel% neq 0 (
    echo ERROR: .NET SDK not found!
    echo Please install .NET 8.0 SDK from https://dotnet.microsoft.com/download
    pause
    exit /b 1
)

echo .NET SDK found!
echo.

REM Navigate to project directory
cd MalaysiaRadioFM

echo Restoring dependencies...
dotnet restore
if %errorlevel% neq 0 (
    echo ERROR: Failed to restore dependencies
    pause
    exit /b 1
)

echo.
echo Building application...
dotnet build -c Release
if %errorlevel% neq 0 (
    echo ERROR: Build failed
    pause
    exit /b 1
)

echo.
echo ====================================
echo Build completed successfully!
echo ====================================
echo.
echo The application can be found at:
echo MalaysiaRadioFM\bin\Release\net8.0-windows\
echo.
echo To run the application:
echo   cd MalaysiaRadioFM
echo   dotnet run
echo.
echo To create a standalone executable:
echo   dotnet publish -c Release -r win-x64 --self-contained
echo.

pause
