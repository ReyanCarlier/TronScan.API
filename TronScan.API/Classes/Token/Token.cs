using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Token
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("data")]
    public List<TokenData> Data { get; set; } = [];
    [JsonPropertyName("contractMap")]
    public Dictionary<string, string> ContractMap { get; set; } = [];
    [JsonPropertyName("contractInfo")]
    public Dictionary<string, ContractInfo> ContractInfo { get; set; } = [];
}