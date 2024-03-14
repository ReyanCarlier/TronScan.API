using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class BlockStatistics
{
    [JsonPropertyName("last_day_pay")]
    public long LastDayPay { get; set; } = 0;
    [JsonPropertyName("last_day_block_count")]
    public long LastDayBlockCount { get; set; } = 0;
    [JsonPropertyName("last_day_total_burn")]
    public long LastDayTotalBurn { get; set; } = 0;
    [JsonPropertyName("whole_block_count")]
    public long WholeBlockCount { get; set; } = 0;
    [JsonPropertyName("whole_pay")]
    public long WholePay { get; set; } = 0;
    [JsonPropertyName("last_day_burn")]
    public long LastDayBurn { get; set; } = 0;
}