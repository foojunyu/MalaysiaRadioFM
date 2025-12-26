using NAudio.Wave;

namespace MalaysiaRadioFM;

public partial class Form1 : Form
{
    private IWavePlayer? waveOut;
    private MediaFoundationReader? reader;
    private List<RadioStation> radioStations = new();

    public Form1()
    {
        InitializeComponent();
        InitializeRadioStations();
        LoadRadioStations();
    }

    private void InitializeRadioStations()
    {
        radioStations = new List<RadioStation>
        {
            new RadioStation("Hot FM", "97.6 FM", "https://mediaprima.rastream.com/mediaprima-hotfm"),
            new RadioStation("Sinar FM", "96.7 FM", "https://mediaprima.rastream.com/mediaprima-sinarfm"),
            new RadioStation("Fly FM", "95.8 FM", "https://mediaprima.rastream.com/mediaprima-flyfm"),
            new RadioStation("Era FM", "101.8 FM", "https://mediaprima.rastream.com/mediaprima-erafm"),
            new RadioStation("Hitz FM", "92.9 FM", "https://astro1.rastream.com/hitz"),
            new RadioStation("Mix FM", "94.5 FM", "https://astro2.rastream.com/mix"),
            new RadioStation("Lite FM", "105.7 FM", "https://astro3.rastream.com/lite"),
            new RadioStation("My FM", "101.8 FM", "https://astro4.rastream.com/myfm"),
            new RadioStation("THR Raaga", "100.3 FM", "https://astro5.rastream.com/raaga"),
            new RadioStation("BFM 89.9", "89.9 FM", "https://24353.live.streamtheworld.com/BFMAAC.aac")
        };
    }

    private void LoadRadioStations()
    {
        listBoxStations.DataSource = radioStations;
    }

    private void BtnPlay_Click(object? sender, EventArgs e)
    {
        if (listBoxStations.SelectedItem == null)
        {
            MessageBox.Show("Please select a radio station first.", "No Station Selected", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            StopPlayback();

            var selectedStation = (RadioStation)listBoxStations.SelectedItem;
            labelStatus.Text = $"Status: Loading {selectedStation.Name}...";
            Application.DoEvents();

            reader = new MediaFoundationReader(selectedStation.Url);
            waveOut = new WaveOutEvent();
            waveOut.Init(reader);
            waveOut.Volume = trackBarVolume.Value / 100f;
            waveOut.Play();

            labelStatus.Text = $"Status: Playing {selectedStation.Name}";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error playing stream: {ex.Message}", "Playback Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            labelStatus.Text = "Status: Error";
        }
    }

    private void BtnStop_Click(object? sender, EventArgs e)
    {
        StopPlayback();
        labelStatus.Text = "Status: Not playing";
    }

    private void StopPlayback()
    {
        waveOut?.Stop();
        waveOut?.Dispose();
        waveOut = null;
        reader?.Dispose();
        reader = null;
    }

    private void TrackBarVolume_Scroll(object? sender, EventArgs e)
    {
        labelVolume.Text = $"Volume: {trackBarVolume.Value}%";
        if (waveOut != null)
        {
            waveOut.Volume = trackBarVolume.Value / 100f;
        }
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        StopPlayback();
    }
}
