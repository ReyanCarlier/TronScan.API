using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Contract
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("verify_status")]
    public int VerifyStatus { get; set; } = 0;
    [JsonPropertyName("balance")]
    public long Balance { get; set; } = 0;
    [JsonPropertyName("trxCount")]
    public int TrxCount { get; set; } = 0;
    [JsonPropertyName("date_created")]
    public long DateCreated { get; set; } = 0;
    [JsonPropertyName("license")]
    public string License { get; set; } = "";
    [JsonPropertyName("compile_version")]
    public string CompileVersion { get; set; } = "";
    [JsonPropertyName("compile_settings")]
    public string CompileSettings { get; set; } = "";
    [JsonPropertyName("verify_time")]
    public long VerifyTime { get; set; } = 0;
    [JsonPropertyName("tag1")]
    public string Tag1 { get; set; } = "";
    [JsonPropertyName("tag1Url")]
    public string Tag1Url { get; set; } = "";
    [JsonPropertyName("vip")]
    public bool Vip { get; set; } = false;
    [JsonPropertyName("trc20token")]
    public Trc20Token Trc20Token { get; set; } = new();
    
    public ContractDetails Details { get; set; } = new();
}