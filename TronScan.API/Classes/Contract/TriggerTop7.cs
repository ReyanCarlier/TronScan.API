using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class TriggerTop7
{
    [JsonPropertyName("tag1")]
    public string Tag1 { get; set; } = "";
    [JsonPropertyName("tag1Url")]
    public string Tag1Url { get; set; } = "";
    [JsonPropertyName("contract")]
    public string Contract { get; set; } = "";
    [JsonPropertyName("percentage")]
    public double Percentage { get; set; } = 0;
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("triggers")]
    public long Triggers { get; set; } = 0;
}