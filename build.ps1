# Build script for Malaysia Radio FM Windows Application

Write-Host "====================================" -ForegroundColor Cyan
Write-Host "Malaysia Radio FM Build Script" -ForegroundColor Cyan
Write-Host "====================================" -ForegroundColor Cyan
Write-Host ""

# Check if .NET SDK is installed
try {
    $dotnetVersion = dotnet --version
    Write-Host ".NET SDK $dotnetVersion found!" -ForegroundColor Green
    Write-Host ""
} catch {
    Write-Host "ERROR: .NET SDK not found!" -ForegroundColor Red
    Write-Host "Please install .NET 8.0 SDK from https://dotnet.microsoft.com/download" -ForegroundColor Yellow
    Read-Host "Press Enter to exit"
    exit 1
}

# Navigate to project directory
Set-Location MalaysiaRadioFM

# Restore dependencies
Write-Host "Restoring dependencies..." -ForegroundColor Yellow
dotnet restore
if ($LASTEXITCODE -ne 0) {
    Write-Host "ERROR: Failed to restore dependencies" -ForegroundColor Red
    Read-Host "Press Enter to exit"
    exit 1
}

Write-Host ""

# Build application
Write-Host "Building application..." -ForegroundColor Yellow
dotnet build -c Release
if ($LASTEXITCODE -ne 0) {
    Write-Host "ERROR: Build failed" -ForegroundColor Red
    Read-Host "Press Enter to exit"
    exit 1
}

Write-Host ""
Write-Host "====================================" -ForegroundColor Green
Write-Host "Build completed successfully!" -ForegroundColor Green
Write-Host "====================================" -ForegroundColor Green
Write-Host ""
Write-Host "The application can be found at:" -ForegroundColor Cyan
Write-Host "MalaysiaRadioFM\bin\Release\net8.0-windows\" -ForegroundColor White
Write-Host ""
Write-Host "To run the application:" -ForegroundColor Cyan
Write-Host "  cd MalaysiaRadioFM" -ForegroundColor White
Write-Host "  dotnet run" -ForegroundColor White
Write-Host ""
Write-Host "To create a standalone executable:" -ForegroundColor Cyan
Write-Host "  dotnet publish -c Release -r win-x64 --self-contained" -ForegroundColor White
Write-Host ""

Read-Host "Press Enter to exit"
