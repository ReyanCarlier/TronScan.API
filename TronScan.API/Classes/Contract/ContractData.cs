using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ContractData
{
    [JsonPropertyName("amount")]
    public int Amount { get; set; } = 0;

    [JsonPropertyName("asset_name")]
    public string AssetName { get; set; } = "";

    [JsonPropertyName("owner_address")]
    public string OwnerAddress { get; set; } = "";

    [JsonPropertyName("to_address")]
    public string ToAddress { get; set; } = "";

    [JsonPropertyName("tokenInfo")]
    public TokenInfo TokenInfo { get; set; } = new();
}