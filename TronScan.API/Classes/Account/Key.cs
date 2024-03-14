using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Key
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";

    [JsonPropertyName("weight")]
    public int Weight { get; set; } = 0;
}