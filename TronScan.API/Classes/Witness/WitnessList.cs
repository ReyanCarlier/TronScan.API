using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class WitnessList
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("lastBlock")]
    public Block LastBlock { get; set; } = new();
    [JsonPropertyName("data")]
    public List<Witness> Data { get; set; } = new();
}