using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Block
{
    [JsonPropertyName("number")]
    public long Number { get; set; } = 0;
    [JsonPropertyName("hash")]
    public string Hash { get; set; } = "";
    [JsonPropertyName("size")]
    public long Size { get; set; } = 0;
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; } = 0;
    [JsonPropertyName("txTrieRoot")]
    public string TxTrieRoot { get; set; } = "";
    [JsonPropertyName("parentHash")]
    public string ParentHash { get; set; } = "";
    [JsonPropertyName("witnessId")]
    public long WitnessId { get; set; } = 0;
    [JsonPropertyName("witnessAddress")]
    public string WitnessAddress { get; set; } = "";
    [JsonPropertyName("nrOfTrx")]
    public long NrOfTrx { get; set; } = 0;
    [JsonPropertyName("witnessName")]
    public string WitnessName { get; set; } = "";
    [JsonPropertyName("version")]
    public long Version { get; set; } = 0;
    [JsonPropertyName("fee")]
    public decimal Fee { get; set; } = 0;
    [JsonPropertyName("confirmed")]
    public bool Confirmed { get; set; } = false;
    [JsonPropertyName("confirmations")]
    public long Confirmations { get; set; } = 0;
    [JsonPropertyName("netUsage")]
    public long NetUsage { get; set; } = 0;
    [JsonPropertyName("energyUsage")]
    public long EnergyUsage { get; set; } = 0;
    [JsonPropertyName("blockReward")]
    public long BlockReward { get; set; } = 0;
    [JsonPropertyName("voteReward")]
    public long VoteReward { get; set; } = 0;
    [JsonPropertyName("revert")]
    public bool Revert { get; set; } = false;
    
    public BlockStatistics Statistics { get; set; } = new();
}