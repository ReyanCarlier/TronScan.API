using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class AccountResource
{
    [JsonPropertyName("hash")]
    public string Hash { get; set; } = "";
    [JsonPropertyName("block")]
    public long Block { get; set; } = 0;
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; } = 0;
    [JsonPropertyName("ownerAddress")]
    public string OwnerAddress { get; set; } = "";
    [JsonPropertyName("receiverAddress")]
    public string ReceiverAddress { get; set; } = "";
    [JsonPropertyName("resource")]
    public string Resource { get; set; } = "";
    [JsonPropertyName("frozenBalance")]
    public long FrozenBalance { get; set; } = 0;
    [JsonPropertyName("expireTime")]
    public long ExpireTime { get; set; } = 0;
    [JsonPropertyName("resourceValue")]
    public long ResourceValue { get; set; } = 0;
}

public class AccountResourceList
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("data")]
    public List<AccountResource> Resources { get; set; } = [];
    [JsonPropertyName("rangeTotal")]
    public long RangeTotal { get; set; } = 0;
}