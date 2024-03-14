using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class BlockMinimalDetails
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
    [JsonPropertyName("missedTotal")]
    public long MissedTotal { get; set; } = 0;
    [JsonPropertyName("producedTotal")]
    public long ProducedTotal { get; set; } = 0;
    [JsonPropertyName("producedPercentage")]
    public double ProducedPercentage { get; set; } = 0;
}