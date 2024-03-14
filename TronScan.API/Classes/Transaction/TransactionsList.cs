using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class TransactionsList
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("rangeTotal")]
    public long RangeTotal { get; set; } = 0;
    [JsonPropertyName("data")]
    public List<Transaction> Data { get; set; } = [];
    [JsonPropertyName("wholeChainTxCount")]
    public long WholeChainTxCount { get; set; } = 0;
    [JsonPropertyName("contractMap")]
    public Dictionary<string, bool> ContractMap { get; set; } = new();
    [JsonPropertyName("contractInfo")]
    public Dictionary<string, ContractInfo> ContractInfo { get; set; } = new();
}
