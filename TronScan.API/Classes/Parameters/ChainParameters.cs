using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ChainParameter
{
    [JsonPropertyName("key")]
    public string Key { get; set; } = "";
    [JsonPropertyName("value")]
    public string Value { get; set; } = "";
}

public class ChainParameters
{
    [JsonPropertyName("tronParameters")]
    public List<ChainParameter> TronParameters { get; set; } = [];
}