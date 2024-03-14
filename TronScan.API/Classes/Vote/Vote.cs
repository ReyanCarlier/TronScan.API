using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Vote
{
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; } = 0;
    [JsonPropertyName("voterAddress")]
    public string VoterAddress { get; set; } = "";
    [JsonPropertyName("candidateAddress")]
    public string CandidateAddress { get; set; } = "";
    [JsonPropertyName("votes")]
    public long Votes { get; set; } = 0;
    [JsonPropertyName("candidateUrl")]
    public string CandidateUrl { get; set; } = "";
    [JsonPropertyName("candidateName")]
    public string CandidateName { get; set; } = "";
    [JsonPropertyName("candidateTotalVotes")]
    public long CandidateTotalVotes { get; set; } = 0;
    [JsonPropertyName("voterAvailableVotes")]
    public long VoterAvailableVotes { get; set; } = 0;
}