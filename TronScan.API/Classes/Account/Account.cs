using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class AccountData
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";

    [JsonPropertyName("addressTagLogo")]
    public string AddressTagLogo { get; set; } = "";

    [JsonPropertyName("balance")]
    public long Balance { get; set; }

    [JsonPropertyName("power")]
    public int Power { get; set; }

    [JsonPropertyName("totalTransactionCount")]
    public int TotalTransactionCount { get; set; }

    [JsonPropertyName("latestOperationTime")]
    public long LatestOperationTime { get; set; }

    [JsonPropertyName("updateTime")]
    public long UpdateTime { get; set; }
}

public class Account
{
    [JsonPropertyName("account_number")]
    public int AccountNumber { get; set; }

    [JsonPropertyName("last_24h_account_change")]
    public int Last24HAccountChange { get; set; } = 0;

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("data")]
    public List<AccountData> Data { get; set; } = [];

    [JsonPropertyName("contractMap")]
    public Dictionary<string, bool> ContractMap { get; set; } = [];

    [JsonPropertyName("rangeTotal")]
    public int RangeTotal { get; set; } = 0;

    [JsonPropertyName("contractInfo")]
    public Dictionary<string, ContractInfo> ContractInfo { get; set; } = [];
    
    public AccountDetails Details { get; set; } = new();
    
    public AccountResourceList ResourceList { get; set; } = new();
    
    public AccountApprovals Approvals { get; set; } = new();
}