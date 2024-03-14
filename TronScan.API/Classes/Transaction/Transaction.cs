using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Transaction
{
    [JsonPropertyName("block")]
    public long Block { get; set; } = 0;
    [JsonPropertyName("hash")]
    public string Hash { get; set; } = "";
    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; } = 0;
    [JsonPropertyName("owner_address")]
    public string OwnerAddress { get; set; } = "";
    [JsonPropertyName("toAddressList")]
    public List<string> ToAddressList { get; set; } = [];
    [JsonPropertyName("toAddress")]
    public string ToAddress { get; set; } = "";
    [JsonPropertyName("contractType")]
    public string ContractType { get; set; } = "";
    [JsonPropertyName("confirmed")]
    public bool Confirmed { get; set; } = false;
    [JsonPropertyName("revert")]
    public bool Revert { get; set; } = false;
    [JsonPropertyName("contractData")]
    public TransactionContractData ContractData { get; set; } = new TransactionContractData();
    [JsonPropertyName("SmartCalls")]
    public string SmartCalls { get; set; } = "";
    [JsonPropertyName("Events")]
    public string Events { get; set; } = "";
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
    [JsonPropertyName("data")]
    public string Data { get; set; } = "";
    [JsonPropertyName("fee")]
    public long Fee { get; set; } = 0;
    [JsonPropertyName("contractRet")]
    public string ContractRet { get; set; } = "";
    [JsonPropertyName("result")]
    public string Result { get; set; } = "";
    [JsonPropertyName("amount")]
    public long Amount { get; set; } = 0;
    [JsonPropertyName("cost")]
    public TransactionContractCost Cost { get; set; } = new ();
    [JsonPropertyName("tokenInfo")]
    public TokenInfo TokenInfo { get; set; } = new();
    [JsonPropertyName("tokenType")]
    public string TokenType { get; set; } = "";
}