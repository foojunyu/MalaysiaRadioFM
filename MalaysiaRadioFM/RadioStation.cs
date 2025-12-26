namespace MalaysiaRadioFM;

public class RadioStation
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Frequency { get; set; }

    public RadioStation(string name, string frequency, string url)
    {
        Name = name;
        Frequency = frequency;
        Url = url;
    }

    public override string ToString()
    {
        return $"{Name} - {Frequency}";
    }
}
