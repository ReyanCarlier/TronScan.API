using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ProposalTypeApprovals
{
    [JsonPropertyName("candidate")]
    public List<Witness> Candidate { get; set; } = [];
    [JsonPropertyName("partner")]
    public List<Witness> Partner { get; set; } = [];
    [JsonPropertyName("sr")]
    public List<Witness> Sr { get; set; } = [];
}