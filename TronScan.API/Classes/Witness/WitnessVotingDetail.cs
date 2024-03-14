using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class WitnessVotingDetailData
{
    [JsonPropertyName("lastRanking")]
    public long LastRanking { get; set; } = 0;
    [JsonPropertyName("realTimeRanking")]
    public long RealTimeRanking { get; set; } = 0;
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
    [JsonPropertyName("hasPage")]
    public bool HasPage { get; set; } = false;
    [JsonPropertyName("lastCycleVotes")]
    public long LastCycleVotes { get; set; } = 0;
    [JsonPropertyName("realTimeVotes")]
    public long RealTimeVotes { get; set; } = 0;
    [JsonPropertyName("changeVotes")]
    public long ChangeVotes { get; set; } = 0;
    [JsonPropertyName("brokerage")]
    public double Brokerage { get; set; } = 0;
    [JsonPropertyName("votesPercentage")]
    public double VotesPercentage { get; set; } = 0;
    [JsonPropertyName("lastCycleVotesPercentage")]
    public double LastCycleVotesPercentage { get; set; } = 0;
    [JsonPropertyName("change_cycle")]
    public long ChangeCycle { get; set; } = 0;
    [JsonPropertyName("witnessType")]
    public int WitnessType { get; set; } = 0;
    [JsonPropertyName("annualizedRate")]
    public double AnnualizedRate { get; set; } = 0;
    [JsonPropertyName("producedTotal")]
    public long ProducedTotal { get; set; } = 0;
    [JsonPropertyName("producedEfficiency")]
    public double ProducedEfficiency { get; set; } = 0;
    [JsonPropertyName("blockReward")]
    public long BlockReward { get; set; } = 0;
    [JsonPropertyName("version")]
    public int Version { get; set; } = 0;
    [JsonPropertyName("totalOutOfTimeTrans")]
    public long TotalOutOfTimeTrans { get; set; } = 0;
    [JsonPropertyName("lastWeekOutTimeTrans")]
    public long LastWeekOutTimeTrans { get; set; } = 0;
    [JsonPropertyName("changedBrokerage")]
    public double ChangedBrokerage { get; set; } = 0;
    [JsonPropertyName("lowestBrokerage")]
    public double LowestBrokerage { get; set; } = 0;
    [JsonPropertyName("realtimeVoteLine")]
    public List<VoteLine> RealtimeVoteLine { get; set; } = [];
    [JsonPropertyName("totalWitness")]
    public long TotalWitness { get; set; } = 0;
}

public class WitnessVotingDetail
{
    [JsonPropertyName("success")]
    public bool Success { get; set; } = false;
    [JsonPropertyName("data")]
    public WitnessVotingDetailData Data { get; set; } = new();
    [JsonPropertyName("totalWitness")]
    public long TotalWitness { get; set; } = 0;
    [JsonPropertyName("changedBrokerage")]
    public bool ChangedBrokerage { get; set; } = false;
    [JsonPropertyName("lowestBrokerage")]
    public bool LowestBrokerage { get; set; } = false;
    [JsonPropertyName("brokerageHistory")]
    public List<Brokerage> BrokerageHistory { get; set; } = [];
    [JsonPropertyName("brokerageChangeNum")]
    public long BrokerageChangeNum { get; set; } = 0;
}