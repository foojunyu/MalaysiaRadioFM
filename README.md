# MalaysiaRadioFM

A Windows desktop application for broadcasting and listening to Malaysia FM radio stations.

## Features

- 🎵 Listen to popular Malaysian FM radio stations
- 🔊 Volume control
- 🎛️ Simple and intuitive user interface
- 📻 Pre-configured list of Malaysian radio stations including:
  - Hot FM (97.6 FM)
  - Sinar FM (96.7 FM)
  - Fly FM (95.8 FM)
  - Era FM (101.8 FM)
  - Hitz FM (92.9 FM)
  - Mix FM (94.5 FM)
  - Lite FM (105.7 FM)
  - My FM (101.8 FM)
  - THR Raaga (100.3 FM)
  - BFM 89.9 (89.9 FM)

## Requirements

- Windows 10 or later
- .NET 8.0 Runtime or SDK
- Internet connection for streaming

## Building from Source

### Prerequisites

1. Install [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
2. Clone this repository

### Build Instructions

```bash
# Navigate to the project directory
cd MalaysiaRadioFM

# Restore dependencies
dotnet restore

# Build the application
dotnet build

# Run the application
dotnet run
```

### Publishing the Application

To create a standalone executable:

```bash
# For Windows x64
dotnet publish -c Release -r win-x64 --self-contained

# For Windows x86
dotnet publish -c Release -r win-x86 --self-contained
```

The executable will be available in:
`bin/Release/net8.0-windows/win-x64/publish/` or `bin/Release/net8.0-windows/win-x86/publish/`

## Usage

1. Launch the application
2. Select a radio station from the list
3. Click the "Play" button to start streaming
4. Adjust volume using the slider
5. Click "Stop" to stop playback

## Technology Stack

- **Framework**: .NET 8.0 Windows Forms
- **Audio Library**: NAudio 2.2.1
- **Language**: C# 12.0

## Project Structure

```
MalaysiaRadioFM/
├── Form1.cs              # Main form implementation
├── Form1.Designer.cs     # Form UI designer code
├── RadioStation.cs       # Radio station data model
├── Program.cs            # Application entry point
└── MalaysiaRadioFM.csproj # Project configuration
```

## Contributing

Contributions are welcome! Feel free to:
- Add more radio stations
- Improve the UI/UX
- Add new features (favorites, search, etc.)
- Fix bugs

## License

This project is open source and available for educational purposes.

## Troubleshooting

### Cannot play radio stream
- Check your internet connection
- Some streams may be temporarily unavailable
- Try a different radio station

### Audio quality issues
- Check your internet speed
- Adjust your system volume along with the application volume

## Disclaimer

This application streams publicly available radio station streams. All radio station names, frequencies, and content are the property of their respective owners.

