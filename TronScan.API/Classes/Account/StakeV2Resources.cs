using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class NormalAddressInfo
{
    [JsonPropertyName("risk")]
    public bool Risk { get; set; } = false;
}

public class StakeV2Resources
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("data")]
    public List<TransactionData> Data { get; set; } = [];

    [JsonPropertyName("contractMap")]
    public Dictionary<string, bool> ContractMap { get; set; } = new();

    [JsonPropertyName("rangeTotal")]
    public int RangeTotal { get; set; }

    [JsonPropertyName("contractInfo")]
    public Dictionary<string, ContractInfo> ContractInfo { get; set; } = new();

    [JsonPropertyName("normalAddressInfo")]
    public Dictionary<string, NormalAddressInfo> NormalAddressInfo { get; set; } = new();
}