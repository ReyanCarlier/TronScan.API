using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ProposalList
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("data")]
    public List<Proposal> Proposals { get; set; } = [];
}