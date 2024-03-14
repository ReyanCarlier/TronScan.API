using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class AccountList
{
    [JsonPropertyName("account_number")]
    public long AccountNumber { get; set; } = 0;
    [JsonPropertyName("last_24h_account_change")]
    public long Last24HAccountChange { get; set; } = 0;
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("data")]
    public List<AccountData> Data { get; set; } = [];
    [JsonPropertyName("contractMap")]
    public Dictionary<string, bool> ContractMap { get; set; } = [];
    [JsonPropertyName("rangeTotal")]
    public long RangeTotal { get; set; } = 0;
    [JsonPropertyName("contractInfo")]
    public Dictionary<string, ContractInfo> ContractInfo { get; set; } = [];
}