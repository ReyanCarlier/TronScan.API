using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Witness
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
    [JsonPropertyName("producer")]
    public bool Producer { get; set; } = false;
    [JsonPropertyName("latestBlockNumber")]
    public long LatestBlockNumber { get; set; } = 0;
    [JsonPropertyName("latestSlotNumber")]
    public long LatestSlotNumber { get; set; } = 0;
    [JsonPropertyName("MissedTotal")]
    public long MissedTotal { get; set; } = 0;
    [JsonPropertyName("producedTotal")]
    public long ProducedTotal { get; set; } = 0;
    [JsonPropertyName("producedTrx")]
    public long ProducedTrx { get; set; } = 0;
    [JsonPropertyName("votes")]
    public long Votes { get; set; } = 0;
    [JsonPropertyName("changeVotes")]
    public long ChangeVotes { get; set; } = 0;
    [JsonPropertyName("realTimeVotes")]
    public long RealTimeVotes { get; set; } = 0;
    [JsonPropertyName("brokerage")]
    public long Brokerage { get; set; } = 0;
    [JsonPropertyName("annualizedRate")]
    public double AnnualizedRate { get; set; } = 0;
    [JsonPropertyName("producePercentage")]
    public double ProducePercentage { get; set; } = 0;
    [JsonPropertyName("version")]
    public string Version { get; set; } = "";
    [JsonPropertyName("witnessType")]
    public int WitnessType { get; set; } = 0;
    [JsonPropertyName("index")]
    public int Index { get; set; } = 0;
    [JsonPropertyName("totalOutOfTimeTrans")]
    public long TotalOutOfTimeTrans { get; set; } = 0;
    [JsonPropertyName("lastWeekOutOfTimeTrans")]
    public long LastWeekOutOfTimeTrans { get; set; } = 0;
    [JsonPropertyName("changedBrokerage")]
    public bool ChangedBrokerage { get; set; } = false;
    [JsonPropertyName("lowestBrokerage")]
    public long LowestBrokerage { get; set; } = 0;
    [JsonPropertyName("votesPercentage")]
    public double VotesPercentage { get; set; } = 0;
    
}