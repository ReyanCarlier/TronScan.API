using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class WitnessStatistics
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("increaseOf30Day")]
    public long IncreaseOf30Day { get; set; } = 0;
    [JsonPropertyName("totalRealTimeVotes")]
    public long TotalRealTimeVotes { get; set; } = 0;
    [JsonPropertyName("minBlocksCount")]
    public BlockMinimalDetails MinBlocksCount { get; set; } = new();
    [JsonPropertyName("highestEfficiency")]
    public BlockMinimalDetails HighestEfficiency { get; set; } = new();
    [JsonPropertyName("lowestEfficiency")]
    public BlockMinimalDetails LowestEfficiency { get; set; } = new();
    [JsonPropertyName("maxBlocksCount")]
    public BlockMinimalDetails MaxBlocksCount { get; set; } = new();
}