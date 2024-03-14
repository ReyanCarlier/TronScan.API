using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class VoteList
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("totalVotes")]
    public long TotalVotes { get; set; } = 0;
    [JsonPropertyName("data")]
    public List<Vote> Votes { get; set; } = [];
}