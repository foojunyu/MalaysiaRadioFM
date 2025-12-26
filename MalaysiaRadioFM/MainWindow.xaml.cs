using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace MalaysiaRadioFM;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private AudioPlayer audioPlayer;
    private ObservableCollection<RadioStation> radioStations = new();

    public MainWindow()
    {
        InitializeComponent();
        
        audioPlayer = new AudioPlayer();
        audioPlayer.StatusChanged += AudioPlayer_StatusChanged;
        audioPlayer.ErrorOccurred += AudioPlayer_ErrorOccurred;

        InitializeRadioStations();
        
        StationListBox.ItemsSource = radioStations;
        
        // Set default volume
        audioPlayer.Volume = 0.5f;
    }

    private void InitializeRadioStations()
    {
        radioStations.Clear();
        radioStations.Add(new RadioStation("Hot FM", "https://mediaprima.rastream.com/mediaprima-hotfm", "Malaysia's hottest hits station"));
        radioStations.Add(new RadioStation("Fly FM", "https://mediaprima.rastream.com/mediaprima-flyfm", "Today's best music"));
        radioStations.Add(new RadioStation("One FM", "https://mediaprima.rastream.com/mediaprima-onefm", "Feel good music"));
        radioStations.Add(new RadioStation("Hitz FM", "https://astro2.rastream.com/hitz", "International & Malaysian hits"));
        radioStations.Add(new RadioStation("My FM", "https://astro3.rastream.com/myfm", "华语流行音乐 (Chinese pop music)"));
        radioStations.Add(new RadioStation("Sinar FM", "https://astro4.rastream.com/sinar", "Muzik hit Melayu (Malay hit music)"));
        radioStations.Add(new RadioStation("Mix FM", "https://astro1.rastream.com/mix", "Easy listening & classics"));
        radioStations.Add(new RadioStation("Lite FM", "https://astro1.rastream.com/lite", "Your easy listening companion"));
        radioStations.Add(new RadioStation("THR Raaga", "https://astro4.rastream.com/raaga", "Tamil hits & entertainment"));
        radioStations.Add(new RadioStation("BFM 89.9", "http://playerservices.streamtheworld.com/api/livestream-redirect/BFMAAC.aac", "The business station"));
        radioStations.Add(new RadioStation("Traxx FM", "https://astro3.rastream.com/traxx", "The sound of the nation"));
        radioStations.Add(new RadioStation("AI FM", "http://ai.radio.fm:9000/listen.pls", "Your information station"));
    }

    private void PlayButton_Click(object sender, RoutedEventArgs e)
    {
        if (StationListBox.SelectedItem is RadioStation station)
        {
            try
            {
                audioPlayer.Play(station.Url);
                StatusLabel.Text = $"Playing: {station.Name}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing station: {ex.Message}", 
                              "Playback Error", 
                              MessageBoxButton.OK, 
                              MessageBoxImage.Error);
            }
        }
        else
        {
            MessageBox.Show("Please select a radio station first.", 
                          "No Station Selected", 
                          MessageBoxButton.OK, 
                          MessageBoxImage.Information);
        }
    }

    private void StopButton_Click(object sender, RoutedEventArgs e)
    {
        audioPlayer.Stop();
        StatusLabel.Text = "Stopped";
    }

    private void StationListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (StationListBox.SelectedItem is RadioStation station)
        {
            StatusLabel.Text = $"Selected: {station.Name}";
        }
    }

    private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        if (audioPlayer != null)
        {
            audioPlayer.Volume = (float)(e.NewValue / 100.0);
            VolumeLabel.Text = $"{(int)e.NewValue}%";
        }
    }

    private void AudioPlayer_StatusChanged(object? sender, string status)
    {
        Dispatcher.Invoke(() =>
        {
            StatusLabel.Text = status;
        });
    }

    private void AudioPlayer_ErrorOccurred(object? sender, Exception ex)
    {
        Dispatcher.Invoke(() =>
        {
            MessageBox.Show($"Audio error: {ex.Message}", 
                          "Error", 
                          MessageBoxButton.OK, 
                          MessageBoxImage.Error);
            StatusLabel.Text = "Error occurred";
        });
    }

    protected override void OnClosed(EventArgs e)
    {
        audioPlayer?.Dispose();
        base.OnClosed(e);
    }
}