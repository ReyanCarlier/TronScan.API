using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ContractDetails
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "";

    [JsonPropertyName("count")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("status")]
    public ContractStatus Status { get; set; } = new ContractStatus();

    [JsonPropertyName("data")]
    public List<ContractDetailsData> Data { get; set; } = [];
}