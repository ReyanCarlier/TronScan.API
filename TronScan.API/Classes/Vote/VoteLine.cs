using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class VoteLine
{
    [JsonPropertyName("time")]
    public long Time { get; set; } = 0;
    [JsonPropertyName("vote")]
    public long Vote { get; set; } = 0;
}