# Malaysia Radio FM - Application Guide

## Application Overview

The Malaysia Radio FM application is a Windows desktop application that allows users to listen to popular Malaysian FM radio stations through an easy-to-use interface.

## User Interface Layout

```
┌─────────────────────────────────────────┐
│  Malaysia Radio FM                      │
├─────────────────────────────────────────┤
│                                         │
│  ┌────────────────────────────────┐    │
│  │  Radio Stations List           │    │
│  ├────────────────────────────────┤    │
│  │  Hot FM - 97.6 FM              │    │
│  │  Sinar FM - 96.7 FM            │    │
│  │  Fly FM - 95.8 FM              │    │
│  │  Era FM - 101.8 FM             │    │
│  │  Hitz FM - 92.9 FM             │    │
│  │  Mix FM - 94.5 FM              │    │
│  │  Lite FM - 105.7 FM            │    │
│  │  My FM - 101.8 FM              │    │
│  │  THR Raaga - 100.3 FM          │    │
│  │  BFM 89.9 - 89.9 FM            │    │
│  └────────────────────────────────┘    │
│                                         │
│  [  Play  ]  [  Stop  ]  Status: ...   │
│                                         │
│  Volume: 50%                            │
│  ├────────○──────────────────────┤     │
│                                         │
└─────────────────────────────────────────┘
```

## Features

### 1. Radio Station List
- Displays all available Malaysian FM radio stations
- Shows station name and frequency
- Click to select a station

### 2. Playback Controls
- **Play Button**: Start streaming the selected radio station
- **Stop Button**: Stop the current playback

### 3. Volume Control
- Slider to adjust playback volume (0-100%)
- Real-time volume adjustment while playing
- Volume percentage displayed above the slider

### 4. Status Display
- Shows current playback status
- Indicates which station is currently playing
- Displays error messages if stream fails

## How to Use

### Starting the Application
1. Double-click `MalaysiaRadioFM.exe` to launch
2. The main window will open with a list of radio stations

### Playing a Radio Station
1. Click on a station name in the list to select it
2. Click the "Play" button
3. Wait for the stream to load (status will show "Loading...")
4. Once connected, status will show "Playing [Station Name]"

### Adjusting Volume
1. Move the volume slider left (decrease) or right (increase)
2. The volume percentage will update in real-time
3. Volume changes take effect immediately

### Stopping Playback
1. Click the "Stop" button
2. Status will change to "Not playing"

## Technical Details

### Supported Audio Formats
- AAC (Advanced Audio Coding)
- MP3 (MPEG Audio Layer 3)
- Other formats supported by Windows Media Foundation

### Network Requirements
- Stable internet connection (recommended: 1 Mbps or higher)
- Outbound HTTP/HTTPS access on standard ports
- No firewall blocking of audio streaming domains

### System Requirements
- **OS**: Windows 10 or later (64-bit or 32-bit)
- **Framework**: .NET 8.0 Runtime
- **RAM**: Minimum 100 MB available
- **Storage**: Minimum 50 MB free space
- **Audio**: Windows audio device (speakers/headphones)

## Troubleshooting

### Problem: "Error playing stream" message
**Solution**: 
- Check internet connection
- Try a different radio station
- Ensure Windows Media Foundation is installed
- Check if audio device is working

### Problem: No sound output
**Solution**:
- Check volume slider is not at 0%
- Verify Windows system volume is not muted
- Check audio device is properly connected
- Restart the application

### Problem: Application won't start
**Solution**:
- Install .NET 8.0 Runtime from Microsoft
- Run as Administrator
- Check Windows compatibility settings

### Problem: Choppy or buffering audio
**Solution**:
- Close other bandwidth-intensive applications
- Move closer to WiFi router or use wired connection
- Lower volume (sometimes helps with buffer issues)

## Radio Station Information

| Station Name | Frequency | Type |
|--------------|-----------|------|
| Hot FM | 97.6 FM | Malay Contemporary |
| Sinar FM | 96.7 FM | Malay Gold |
| Fly FM | 95.8 FM | English Contemporary |
| Era FM | 101.8 FM | Malay Contemporary |
| Hitz FM | 92.9 FM | English Contemporary |
| Mix FM | 94.5 FM | English Gold |
| Lite FM | 105.7 FM | Easy Listening |
| My FM | 101.8 FM | Chinese Contemporary |
| THR Raaga | 100.3 FM | Tamil Contemporary |
| BFM 89.9 | 89.9 FM | Business & News |

## Keyboard Shortcuts

Currently, the application does not support keyboard shortcuts. All interactions must be done through mouse clicks.

## Future Enhancements (Potential)

- Add favorites/bookmarks feature
- Include search functionality
- Support for custom station URLs
- Minimize to system tray
- Recent stations history
- Station metadata display (song info, artist)
- Recording capability
- Sleep timer
- Equalizer settings

## Support

For issues or suggestions, please visit the project repository on GitHub.

---

**Note**: This application requires an active internet connection to stream radio. Data usage depends on stream quality and listening duration (typically 64-128 kbps for radio streams).
