using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Creator
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";

    [JsonPropertyName("address_is_contract")]
    public bool AddressIsContract { get; set; } = false;

    [JsonPropertyName("txHash")]
    public string TxHash { get; set; } = "";

    [JsonPropertyName("token_balance")]
    public int TokenBalance { get; set; } = 0;

    [JsonPropertyName("consume_user_resource_percent")]
    public int ConsumeUserResourcePercent { get; set; } = 0;

    [JsonPropertyName("energy_remaining")]
    public int EnergyRemaining { get; set; } = 0;
}