using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class TokenData
{
    [JsonPropertyName("amount")]
    public long Amount { get; set; } = 0;
    [JsonPropertyName("quantity")]
    public long Quantity { get; set; } = 0;
    [JsonPropertyName("tokenId")]
    public string TokenId { get; set; } = "";
    [JsonPropertyName("tokenPriceInUsd")]
    public double TokenPriceInUsd { get; set; } = 0;
    [JsonPropertyName("tokenName")] 
    public string TokenName { get; set; } = "";
    [JsonPropertyName("tokenAbbr")]
    public string TokenAbbr { get; set; } = "";
    [JsonPropertyName("tokenLogo")]
    public string TokenLogo { get; set; } = "";
    [JsonPropertyName("tokenPriceInTrx")]
    public double TokenPriceInTrx { get; set; } = 0;
    [JsonPropertyName("amountInUsd")]
    public double AmountInUsd { get; set; } = 0;
    [JsonPropertyName("balance")]
    public long Balance { get; set; } = 0;
    [JsonPropertyName("tokenDecimal")]
    public int TokenDecimal { get; set; } = 0;
}