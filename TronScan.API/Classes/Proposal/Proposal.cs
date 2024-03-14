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

public class Proposal
{
    [JsonPropertyName("proposalId")]
    public long Id { get; set; } = 0;
    [JsonPropertyName("proposer")]
    public Proposer Proposer { get; set; } = new();
    [JsonPropertyName("proposalHash")]
    public string Hash { get; set; } = "";
    [JsonPropertyName("paramters")]
    public List<Key> Parameters { get; set; } = [];
    [JsonPropertyName("expirationTime")]
    public long ExpirationTime { get; set; } = 0;
    [JsonPropertyName("createTime")]
    public long CreateTime { get; set; } = 0;
    [JsonPropertyName("approveSelf")]
    public bool ApproveSelf { get; set; } = false;
    [JsonPropertyName("typeApprovals")]
    public ProposalTypeApprovals TypeApprovals { get; set; } = new();
    [JsonPropertyName("approvals")]
    public List<Approval> Approvals { get; set; } = [];
    [JsonPropertyName("veto")]
    public bool Veto { get; set; } = false;
}