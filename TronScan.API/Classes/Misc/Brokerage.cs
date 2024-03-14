using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Brokerage
{
    [JsonPropertyName("from")]
    public long From { get; set; } = 0;
    [JsonPropertyName("to")]
    public long To { get; set; } = 0;
    [JsonPropertyName("time")]
    public long Time { get; set; } = 0;
    [JsonPropertyName("hash")]
    public string Hash { get; set; } = "";
}