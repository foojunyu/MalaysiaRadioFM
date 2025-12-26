namespace MalaysiaRadioFM;

public class RadioStation
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Frequency { get; set; }

    public RadioStation(string name, string frequency, string url)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Station name cannot be empty", nameof(name));
        if (string.IsNullOrWhiteSpace(frequency))
            throw new ArgumentException("Frequency cannot be empty", nameof(frequency));
        if (string.IsNullOrWhiteSpace(url))
            throw new ArgumentException("Stream URL cannot be empty", nameof(url));

        Name = name;
        Frequency = frequency;
        Url = url;
    }

    public override string ToString()
    {
        return $"{Name} - {Frequency}";
    }
}
