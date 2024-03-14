using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class TransactionData
{
    [JsonPropertyName("receiverAddress")]
    public string ReceiverAddress { get; set; } = "";

    [JsonPropertyName("expireTime")]
    public long ExpireTime { get; set; } = 0;

    [JsonPropertyName("balance")]
    public int Balance { get; set; } = 0;

    [JsonPropertyName("resource")]
    public int Resource { get; set; } = 0;

    [JsonPropertyName("lockBalance")]
    public int LockBalance { get; set; } = 0;

    [JsonPropertyName("lockResourceValue")]
    public double LockResourceValue { get; set; } = 0;

    [JsonPropertyName("ownerAddress")]
    public string OwnerAddress { get; set; } = "";

    [JsonPropertyName("resourceValue")]
    public double ResourceValue { get; set; } = 0;

    [JsonPropertyName("operationTime")]
    public long OperationTime { get; set; } = 0;
}