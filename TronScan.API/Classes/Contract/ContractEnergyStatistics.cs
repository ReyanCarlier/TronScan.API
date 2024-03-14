using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ContractEnergyStatistic
{
    [JsonPropertyName("day")]
    public long Day { get; set; } = 0;
    [JsonPropertyName("total_energy")]
    public long TotalEnergy { get; set; } = 0;
    [JsonPropertyName("energy")]
    public long Energy { get; set; } = 0;
    [JsonPropertyName("contract_supplied")]
    public long ContractSuppliedCount { get; set; } = 0;
    [JsonPropertyName("trx")]
    public long TransactionsCount { get; set; } = 0;
}

public class ContractEnergyStatistics
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("totalEnergy")]
    public long TotalEnergy { get; set; } = 0;
    [JsonPropertyName("data")]
    public List<ContractEnergyStatistic> Data { get; set; } = [];
}