using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class TransactionContractData
{
    [JsonPropertyName("amount")]
    public long Amount { get; set; } = 0;
    [JsonPropertyName("owner_address")]
    public string OwnerAddress { get; set; } = "";
    [JsonPropertyName("to_address")]
    public string ToAddress { get; set; } = "";
}