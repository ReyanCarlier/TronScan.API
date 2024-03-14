using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class TransactionContractCost
{
    [JsonPropertyName("net_fee")]
    public long NetFee { get; set; } = 0;
    [JsonPropertyName("energy_penalty_total")]
    public long EnergyPenaltyTotal { get; set; } = 0;
    [JsonPropertyName("energy_usage")]
    public long EnergyUsage { get; set; } = 0;
    [JsonPropertyName("fee")]
    public long Fee { get; set; } = 0;
    [JsonPropertyName("energy_fee")]
    public long EnergyFee { get; set; } = 0;
    [JsonPropertyName("energy_usage_total")]
    public long EnergyUsageTotal { get; set; } = 0;
    [JsonPropertyName("origin_energy_usage")]
    public long OriginEnergyUsage { get; set; } = 0;
    [JsonPropertyName("net_usage")]
    public long NetUsage { get; set; } = 0;
}