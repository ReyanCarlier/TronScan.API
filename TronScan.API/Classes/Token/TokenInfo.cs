using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Data
{
    [JsonPropertyName("amount")]
    public string Amount { get; set; } = "";

    [JsonPropertyName("quantity")]
    public string Quantity { get; set; } = "";

    [JsonPropertyName("tokenId")]
    public string TokenId { get; set; } = "";

    [JsonPropertyName("tokenPriceInUsd")]
    public double TokenPriceInUsd { get; set; } = 0;

    [JsonPropertyName("tokenName")]
    public string TokenName { get; set; } = "";

    [JsonPropertyName("tokenAbbr")]
    public string TokenAbbr { get; set; } = "";

    [JsonPropertyName("tokenCanShow")]
    public int TokenCanShow { get; set; } = 0;

    [JsonPropertyName("tokenLogo")]
    public string TokenLogo { get; set; } = "";

    [JsonPropertyName("tokenPriceInTrx")]
    public int TokenPriceInTrx { get; set; } = 0;

    [JsonPropertyName("amountInUsd")]
    public int AmountInUsd { get; set; } = 0;

    [JsonPropertyName("balance")]
    public string Balance { get; set; } = "";

    [JsonPropertyName("tokenDecimal")]
    public int TokenDecimal { get; set; } = 0;

    [JsonPropertyName("tokenType")]
    public string TokenType { get; set; } = "";

    [JsonPropertyName("vip")]
    public bool Vip { get; set; } = false;

    [JsonPropertyName("owner_address")]
    public string OwnerAddress { get; set; } = "";

    [JsonPropertyName("transferCount")]
    public int TransferCount { get; set; } = 0;

    [JsonPropertyName("nrOfTokenHolders")]
    public int HolderCount { get; set; } = 0;

    [JsonPropertyName("project")]
    public string Project { get; set; } = "";
}

public class TokenInfo
{
    [JsonPropertyName("total")]
    public int Total { get; set; } = 0;

    [JsonPropertyName("data")]
    public List<Data> Data { get; set; } = [];

    [JsonPropertyName("contractMap")]
    public Dictionary<string, bool> ContractMap { get; set; } = new();

    [JsonPropertyName("contractInfo")]
    public Dictionary<string, ContractInfo> ContractInfo { get; set; } = new();
}
