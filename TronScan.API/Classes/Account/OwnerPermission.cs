using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class OwnerPermission
{
    [JsonPropertyName("keys")]
    public List<Key> Keys { get; set; } = [];

    [JsonPropertyName("threshold")]
    public int Threshold { get; set; } = 0;

    [JsonPropertyName("permission_name")]
    public string PermissionName { get; set; } = "";
}