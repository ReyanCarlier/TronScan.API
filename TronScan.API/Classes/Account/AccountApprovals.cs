using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class AccountApprovals
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("contractMap")]
    public Dictionary<string, bool> ContractMap { get; set; } = [];
    [JsonPropertyName("rangeTotal")]
    public long RangeTotal { get; set; } = 0;
    [JsonPropertyName("contractInfo")]
    public Dictionary<string, ContractInfo> ContractInfo { get; set; } = [];
}