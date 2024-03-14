using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class AuthorizationRecord
{
    [JsonPropertyName("date_created")]
    public long DateCreated { get; set; } = 0;

    [JsonPropertyName("unlimited")]
    public bool Unlimited { get; set; } = false;

    [JsonPropertyName("revert")]
    public bool Revert { get; set; } = false;

    [JsonPropertyName("owner_address")]
    public string OwnerAddress { get; set; } = "";

    [JsonPropertyName("to_address")]
    public string ToAddress { get; set; } = "";

    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    [JsonPropertyName("contract_address")]
    public string ContractAddress { get; set; } = "";

    [JsonPropertyName("confirmed")]
    public bool Confirmed { get; set; } = false;

    [JsonPropertyName("tokenInfo")]
    public TokenInfo TokenInfo { get; set; } = new TokenInfo();

    [JsonPropertyName("block")]
    public int Block { get; set; } = 0;

    [JsonPropertyName("contract_ret")]
    public string ContractRet { get; set; } = "";

    [JsonPropertyName("amount_str")]
    public string AmountStr { get; set; } = "";

    [JsonPropertyName("from_address")]
    public string FromAddress { get; set; } = "";

    [JsonPropertyName("hash")]
    public string Hash { get; set; } = "";
}

public class AccountAuthorizationRecords
{
    [JsonPropertyName("total")]
    public int Total { get; set; } = 0;

    [JsonPropertyName("contractMap")]
    public Dictionary<string, bool> ContractMap { get; set; } = new();

    [JsonPropertyName("data")]
    public List<AuthorizationRecord> Data { get; set; } = [];

    [JsonPropertyName("contractInfo")]
    public Dictionary<string, ContractInfo> ContractInfo { get; set; } = new();

    [JsonPropertyName("rangeTotal")]
    public int RangeTotal { get; set; } = 0;
}