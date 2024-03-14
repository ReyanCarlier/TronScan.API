using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Proposer
{
    [JsonPropertyName("producedTotal")]
    public long ProducedTotal { get; set; } = 0;
    [JsonPropertyName("producedPercentage")]
    public double ProducedPercentage { get; set; } = 0;
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";
    [JsonPropertyName("latestSlotNumber")]
    public long LatestSlotNumber { get; set; } = 0;
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("votes")]
    public long Votes { get; set; } = 0;
    [JsonPropertyName("missedTotal")]
    public long MissedTotal { get; set; } = 0;
    [JsonPropertyName("producedTrx")]
    public long ProducedTrx { get; set; } = 0;
    [JsonPropertyName("votesPercentage")]
    public double VotesPercentage { get; set; } = 0;
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
    [JsonPropertyName("latestBlockNumber")]
    public long LatestBlockNumber { get; set; } = 0;
}