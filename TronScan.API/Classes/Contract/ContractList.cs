using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ContractStatus
{
    [JsonPropertyName("code")]
    public long Code { get; set; } = 0;
    [JsonPropertyName("message")]
    public string Message { get; set; } = "";
}

public class ContractList
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("triggerTop7")]
    public List<TriggerTop7> TriggerTop7 { get; set; } = [];
    [JsonPropertyName("data")]
    public List<Contract> Data { get; set; } = [];
    [JsonPropertyName("contractCount")]
    public long ContractCount { get; set; } = 0;
    [JsonPropertyName("rangeTotal")]
    public long RangeTotal { get; set; } = 0;
    [JsonPropertyName("contractCount24h")]
    public long ContractCount24H { get; set; } = 0;
    [JsonPropertyName("updateTime")]
    public long UpdateTime { get; set; } = 0;
    [JsonPropertyName("totalTrigger")]
    public long TotalTrigger { get; set; } = 0;
    [JsonPropertyName("verifyContractCount")]
    public long VerifyContractCount { get; set; } = 0;
    [JsonPropertyName("verifyContractCount24h")]
    public long VerifyContractCount24H { get; set; } = 0;
    [JsonPropertyName("status")]
    public ContractStatus Status { get; set; } = new();
}