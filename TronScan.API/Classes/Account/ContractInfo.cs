using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ContractInfo
{
    [JsonPropertyName("tag1")]
    public string Tag1 { get; set; } = "";
    [JsonPropertyName("tag1Url")]
    public string Tag1Url { get; set; } = "";
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("vip")]
    public bool Vip { get; set; } = false;
}