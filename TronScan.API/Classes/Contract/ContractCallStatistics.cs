using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ContactCallStatisticsTopAddress
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";
    [JsonPropertyName("addressTag")]
    public string AddressTag { get; set; } = "";
    [JsonPropertyName("count")]
    public long Count { get; set; } = 0;
}

public class ContractCallStatisticsTopMethod
{
    [JsonPropertyName("times")]
    public string Times { get; set; } = "";
    [JsonPropertyName("methodId")]
    public long MethodId { get; set; } = 0;
}

public class ContractCallStatistics
{
    [JsonPropertyName("recentCallTimes")]
    public long RecentCallTimes { get; set; } = 0;
    [JsonPropertyName("timeLong")]
    public long TimeLong { get; set; } = 0;
    [JsonPropertyName("contractMap")]
    public Dictionary<string, long> ContractMap { get; set; } = [];
    [JsonPropertyName("contractInfo")]
    public ContractInfo ContractInfo { get; set; } = new();
    [JsonPropertyName("topAddress")]
    public List<ContactCallStatisticsTopAddress> TopAddress { get; set; } = [];
    [JsonPropertyName("totalAddress")]
    public long TotalAddress { get; set; } = 0;
    [JsonPropertyName("totalCallTimes")]
    public long TotalCallTimes { get; set; } = 0;
    [JsonPropertyName("topMethods")]
    public List<ContractCallStatisticsTopMethod> TopMethods { get; set; } = [];
}