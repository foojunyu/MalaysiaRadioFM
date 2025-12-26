using NAudio.Wave;

namespace MalaysiaRadioFM;

public class AudioPlayer : IDisposable
{
    private IWavePlayer? waveOut;
    private MediaFoundationReader? audioFileReader;
    private bool disposed = false;

    public event EventHandler<string>? StatusChanged;
    public event EventHandler<Exception>? ErrorOccurred;

    public bool IsPlaying => waveOut?.PlaybackState == PlaybackState.Playing;

    public float Volume
    {
        get => waveOut?.Volume ?? 1.0f;
        set
        {
            if (waveOut != null)
            {
                waveOut.Volume = Math.Clamp(value, 0.0f, 1.0f);
            }
        }
    }

    public void Play(string streamUrl)
    {
        try
        {
            Stop();

            StatusChanged?.Invoke(this, "Connecting...");

            audioFileReader = new MediaFoundationReader(streamUrl);
            waveOut = new WaveOutEvent();
            waveOut.Init(audioFileReader);
            waveOut.Play();

            StatusChanged?.Invoke(this, "Playing");
        }
        catch (Exception ex)
        {
            StatusChanged?.Invoke(this, "Error");
            ErrorOccurred?.Invoke(this, ex);
        }
    }

    public void Stop()
    {
        try
        {
            waveOut?.Stop();
            waveOut?.Dispose();
            waveOut = null;

            audioFileReader?.Dispose();
            audioFileReader = null;

            StatusChanged?.Invoke(this, "Stopped");
        }
        catch (Exception ex)
        {
            ErrorOccurred?.Invoke(this, ex);
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Stop();
            }
            disposed = true;
        }
    }
}
