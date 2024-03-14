using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class BlockList
{
    [JsonPropertyName("total")]
    public long Total { get; set; } = 0;
    [JsonPropertyName("rangeTotal")]
    public long RangeTotal { get; set; } = 0;
    [JsonPropertyName("data")]
    public List<Block> Data { get; set; } = [];
}