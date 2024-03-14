using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class ContractDetailsData
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";

    [JsonPropertyName("balance")]
    public long Balance { get; set; } = 0;

    [JsonPropertyName("verify_status")]
    public int VerifyStatus { get; set; } = 0;

    [JsonPropertyName("is_proxy")]
    public bool IsProxy { get; set; } = false;

    [JsonPropertyName("proxy_implementation")]
    public string ProxyImplementation { get; set; } = "";

    [JsonPropertyName("old_proxy_implementation")]
    public string OldProxyImplementation { get; set; } = "";

    [JsonPropertyName("balanceInUsd")]
    public int BalanceInUsd { get; set; }

    [JsonPropertyName("trxCount")]
    public int TrxCount { get; set; } = 0;

    [JsonPropertyName("date_created")]
    public long DateCreated { get; set; } = 0;

    [JsonPropertyName("call_value")]
    public int CallValue { get; set; } = 0;

    [JsonPropertyName("call_token_value")]
    public int CallTokenValue { get; set; } = 0;

    [JsonPropertyName("call_token_id")]
    public int CallTokenId { get; set; } = 0;

    [JsonPropertyName("call_token_info")]
    public TokenInfo CallTokenInfo { get; set; } = new();

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("description")]
    public string Description { get; set; } = "";

    [JsonPropertyName("tag1")]
    public string Tag1 { get; set; } = "";

    [JsonPropertyName("tag1Url")]
    public string Tag1Url { get; set; } = "";

    [JsonPropertyName("vip")]
    public bool Vip { get; set; } = false;

    [JsonPropertyName("feedbackRisk")]
    public bool FeedbackRisk { get; set; } = false;

    [JsonPropertyName("announcement")]
    public string Announcement { get; set; } = "";

    [JsonPropertyName("blueTag")]
    public string BlueTag { get; set; } = "";

    [JsonPropertyName("blueTagUrl")]
    public string BlueTagUrl { get; set; } = "";

    [JsonPropertyName("greyTag")]
    public string GreyTag { get; set; } = "";

    [JsonPropertyName("redTag")]
    public string RedTag { get; set; } = "";

    [JsonPropertyName("publicTag")]
    public string PublicTag { get; set; } = "";

    [JsonPropertyName("creator")]
    public Creator Creator { get; set; } = new();

    [JsonPropertyName("auditReportUrl")]
    public string AuditReportUrl { get; set; } = "";

    [JsonPropertyName("auditDep")]
    public string AuditDep { get; set; } = "";

    [JsonPropertyName("auditDate")]
    public string AuditDate { get; set; } = "";
 
    [JsonPropertyName("methodMap")]
    public Dictionary<string, string> MethodMap { get; set; } = new();

    [JsonPropertyName("energy_factor")]
    public int EnergyFactor { get; set; } = 0;

    [JsonPropertyName("tokenInfo")]
    public TokenInfo TokenInfo { get; set; } = new();

    [JsonPropertyName("balanceWithTokens")]
    public double BalanceWithTokens { get; set; } = 0;

    [JsonPropertyName("balanceWithTokensInUsd")]
    public double BalanceWithTokensInUsd { get; set; } = 0;
}