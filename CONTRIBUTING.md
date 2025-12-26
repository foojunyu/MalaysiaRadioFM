# Contributing to Malaysia Radio FM

Thank you for your interest in contributing to Malaysia Radio FM! This document provides guidelines and instructions for contributing.

## How to Contribute

### Reporting Bugs

If you find a bug, please create an issue on GitHub with:

1. **Clear title** - Briefly describe the issue
2. **Description** - Detailed explanation of the problem
3. **Steps to reproduce** - How to recreate the issue
4. **Expected behavior** - What should happen
5. **Actual behavior** - What actually happens
6. **Environment** - Your Windows version and .NET version
7. **Screenshots** - If applicable

### Suggesting Enhancements

Enhancement suggestions are welcome! Please create an issue with:

1. **Clear title** - Briefly describe the enhancement
2. **Use case** - Why this enhancement would be useful
3. **Proposed solution** - How you envision it working
4. **Alternatives** - Other solutions you've considered

### Adding New Radio Stations

To add a new Malaysian radio station:

1. Find the stream URL (usually ends in .mp3, .aac, or similar)
2. Test the stream URL in a media player to ensure it works
3. Fork the repository
4. Edit `MalaysiaRadioFM/MainWindow.xaml.cs`
5. Add a new `RadioStation` entry in the `InitializeRadioStations()` method:
   ```csharp
   radioStations.Add(new RadioStation(
       "Station Name", 
       "https://stream.url/here", 
       "Brief description of the station"
   ));
   ```
6. Build and test the application
7. Submit a pull request

### Code Contributions

#### Getting Started

1. Fork the repository
2. Clone your fork:
   ```bash
   git clone https://github.com/YOUR-USERNAME/MalaysiaRadioFM.git
   ```
3. Create a new branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```

#### Development Setup

1. Install .NET 8.0 SDK
2. Open the solution in Visual Studio 2022 or later
3. Restore NuGet packages
4. Build the solution

#### Code Style

- Follow C# coding conventions
- Use meaningful variable and method names
- Add comments for complex logic
- Keep methods focused and concise
- Use async/await for I/O operations

#### Testing Your Changes

1. Build the solution without errors or warnings
2. Run the application and test your changes
3. Test multiple radio stations
4. Verify UI responsiveness
5. Check for memory leaks (especially when switching stations)

#### Submitting Changes

1. Commit your changes with clear, descriptive messages:
   ```bash
   git commit -m "Add feature: brief description"
   ```
2. Push to your fork:
   ```bash
   git push origin feature/your-feature-name
   ```
3. Create a Pull Request on GitHub
4. Provide a clear description of your changes
5. Reference any related issues

### Pull Request Guidelines

- **One feature per PR** - Keep pull requests focused
- **Clear description** - Explain what and why
- **Test thoroughly** - Ensure your changes work
- **Update documentation** - If you change functionality
- **No breaking changes** - Unless absolutely necessary

## Development Guidelines

### Architecture

The application follows a simple MVVM-like pattern:
- **Models** - `RadioStation.cs` - Data models
- **Views** - `MainWindow.xaml` - UI definition
- **Logic** - `MainWindow.xaml.cs` - UI logic and event handlers
- **Services** - `AudioPlayer.cs` - Audio streaming service

### Adding Features

When adding new features, consider:
- **User experience** - Keep the UI simple and intuitive
- **Performance** - Minimize resource usage
- **Error handling** - Handle failures gracefully
- **Cross-compatibility** - Test on different Windows versions

### Code Review Process

1. Maintainers will review your PR
2. Address any requested changes
3. Once approved, your PR will be merged
4. Your contribution will be credited in the commit

## Questions?

If you have questions about contributing:
- Open an issue on GitHub
- Check existing issues and pull requests
- Review the README.md for technical details

## Code of Conduct

- Be respectful and inclusive
- Provide constructive feedback
- Help others learn and grow
- Focus on what's best for the community

## License

By contributing, you agree that your contributions will be licensed under the same license as the project.

---

Thank you for contributing to Malaysia Radio FM! 🎵
