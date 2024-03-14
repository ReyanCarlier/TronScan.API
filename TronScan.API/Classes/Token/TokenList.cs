using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class TokenList
{
    [JsonPropertyName("all")]
    public long All { get; set; } = 0;
    [JsonPropertyName("currentWeekAll")]
    public long CurrentWeekAll { get; set; } = 0;
    [JsonPropertyName("currentWeekTotalAll")]
    public long CurrentWeekTotalAll { get; set; } = 0;
    [JsonPropertyName("tokens")]
    public List<Token> Tokens { get; set; } = [];
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("total10")]
    public long Total10 { get; set; } = 0;
    [JsonPropertyName("total1155")]
    public long Total1155 { get; set; } = 0;
    [JsonPropertyName("total20")]
    public long Total20 { get; set; } = 0;
    [JsonPropertyName("total721")]
    public long Total721 { get; set; } = 0;
    [JsonPropertyName("totalAll")]
    public long TotalAll { get; set; } = 0;
    [JsonPropertyName("totalAllCount")]
    public long TotalAllCount { get; set; } = 0;
    [JsonPropertyName("updateTime")]
    public long UpdateTime { get; set; } = 0;
    [JsonPropertyName("valueAtLeast")]
    public long ValueAtLeast { get; set; } = 0;
}