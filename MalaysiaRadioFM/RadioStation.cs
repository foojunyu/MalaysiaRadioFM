namespace MalaysiaRadioFM;

public class RadioStation
{
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public RadioStation(string name, string url, string description = "")
    {
        Name = name;
        Url = url;
        Description = description;
    }

    public override string ToString()
    {
        return Name;
    }
}
