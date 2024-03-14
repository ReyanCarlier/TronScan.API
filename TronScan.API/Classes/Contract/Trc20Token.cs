using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Trc20Token
{
    [JsonPropertyName("icon_url")]
    public string IconUrl { get; set; } = "";
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = "";
    [JsonPropertyName("TotalSupply")]
    public long TotalSupply { get; set; } = 0;
    [JsonPropertyName("level")]
    public int Level { get; set; } = 0;
    [JsonPropertyName("contract_address")]
    public string ContractAddress { get; set; } = "";
    [JsonPropertyName("issuer_address")]
    public string IssuerAddress { get; set; } = "";
    [JsonPropertyName("home_page")]
    public string HomePageUrl { get; set; } = "";
    [JsonPropertyName("token_desc")]
    public string Description { get; set; } = "";
    [JsonPropertyName("holders_count")]
    public int HoldersCount { get; set; } = 0;
    [JsonPropertyName("git_hub")]
    public string GitHubUrl { get; set; } = "";
    [JsonPropertyName("decimals")]
    public int Decimals { get; set; } = 0;
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("issue_time")]
    public DateTime IssueTime { get; set; } = DateTime.MinValue;
    [JsonPropertyName("white_paper")]
    public string WhitePaperUrl { get; set; } = "";
    [JsonPropertyName("email")]
    public string Email { get; set; } = "";
    [JsonPropertyName("social_media")]
    public string SocialMediaJson { get; set; } = "";
    [JsonPropertyName("status")]
    public int Status { get; set; } = 0;
    [JsonPropertyName("token_type")]
    public int Type { get; set; } = 0;
    
}