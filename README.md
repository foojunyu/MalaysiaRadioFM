# MalaysiaRadioFM

A Windows desktop application for streaming popular Malaysian FM radio stations. Built with .NET 8 and WPF (Windows Presentation Foundation).

## Features

- 🎵 Stream popular Malaysian radio stations
- 🎚️ Volume control
- ▶️ Simple play/stop controls
- 📻 Pre-configured with popular stations including:
  - Hot FM - Malaysia's hottest hits station
  - Fly FM - Today's best music
  - One FM - Feel good music
  - Hitz FM - International & Malaysian hits
  - My FM - 华语流行音乐 (Chinese pop music)
  - Sinar FM - Muzik hit Melayu (Malay hit music)
  - Mix FM - Easy listening & classics
  - Lite FM - Your easy listening companion
  - THR Raaga - Tamil hits & entertainment
  - BFM 89.9 - The business station
  - Traxx FM - The sound of the nation
  - AI FM - Your information station

## Requirements

- Windows 10 or later
- .NET 8.0 Runtime (Desktop) or SDK

## Building from Source

### Prerequisites

- .NET 8.0 SDK or later
- Windows operating system (for running the application)

### Build Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/foojunyu/MalaysiaRadioFM.git
   cd MalaysiaRadioFM
   ```

2. Restore dependencies:
   ```bash
   cd MalaysiaRadioFM
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

### Creating a Standalone Executable

To create a standalone Windows executable:

```bash
cd MalaysiaRadioFM
dotnet publish -c Release -r win-x64 --self-contained
```

The executable will be located in:
```
MalaysiaRadioFM/bin/Release/net8.0-windows/win-x64/publish/MalaysiaRadioFM.exe
```

## Usage

1. Launch the application
2. Select a radio station from the list
3. Click the **Play** button to start streaming
4. Adjust the volume using the slider
5. Click the **Stop** button to stop playback

## Technology Stack

- **Framework**: .NET 8.0
- **UI Framework**: WPF (Windows Presentation Foundation)
- **Audio Library**: NAudio 2.2.1
- **Language**: C# 12

## Project Structure

```
MalaysiaRadioFM/
├── MalaysiaRadioFM/          # Main application project
│   ├── App.xaml              # Application entry point
│   ├── MainWindow.xaml       # Main window UI definition
│   ├── MainWindow.xaml.cs    # Main window code-behind
│   ├── AudioPlayer.cs        # Audio streaming handler
│   ├── RadioStation.cs       # Radio station model
│   └── MalaysiaRadioFM.csproj # Project file
└── README.md                 # This file
```

## License

This project is provided as-is for educational and personal use.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Troubleshooting

### Application won't start
- Ensure you have .NET 8.0 Desktop Runtime installed
- Check that your Windows version is 10 or later

### No audio playing
- Check your internet connection
- Verify that the radio station stream is available
- Ensure your system audio is not muted
- Try selecting a different radio station

### Build errors
- Ensure .NET 8.0 SDK is installed
- Run `dotnet restore` to restore all dependencies
- Check that you're building on a Windows machine or have EnableWindowsTargeting set

## Notes

- This application requires an active internet connection to stream radio stations
- Some radio stations may not be available at all times due to maintenance or licensing
- The application uses MediaFoundation for audio streaming, which is built into Windows

