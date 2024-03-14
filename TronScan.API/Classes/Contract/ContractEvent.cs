using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class Item
{
    [JsonPropertyName("param")]
    public string Param { get; set; } = "";

    [JsonPropertyName("value")]
    public string Value { get; set; } = "";
}

public class ResultWithTopic
{
    [JsonPropertyName("index")]
    public List<Item> Index { get; set; } = [];

    [JsonPropertyName("topic")]
    public string Topic { get; set; } = "";

    [JsonPropertyName("dataInArr")]
    public List<Item> Data { get; set; } = [];
}

public class EventResult
{
    [JsonPropertyName("0")]
    public string Zero { get; set; } = "";
    [JsonPropertyName("1")]
    public string One { get; set; } = "";
    [JsonPropertyName("2")]
    public string Two { get; set; } = "";
    [JsonPropertyName("from")]
    public string From { get; set; } = "";
    [JsonPropertyName("to")]
    public string To { get; set; } = "";
    [JsonPropertyName("value")]
    public string Value { get; set; } = "";
}

public class EventResultType
{
    [JsonPropertyName("from")]
    public string From { get; set; } = "";
    [JsonPropertyName("to")]
    public string To { get; set; } = "";
    [JsonPropertyName("value")]
    public string Value { get; set; } = "";
}

public class EventResultListItem
{
    [JsonPropertyName("owner_address")]
    public string OwnerAddress { get; set; } = "";
    [JsonPropertyName("block")]
    public long Block { get; set; } = 0;
    [JsonPropertyName("hash")]
    public string Hash { get; set; } = "";
    [JsonPropertyName("date_created")]
    public long DateCreated { get; set; } = 0;
    [JsonPropertyName("contract_address")]
    public string ContractAddress { get; set; } = "";
    [JsonPropertyName("token_id")]
    public int TokenId { get; set; } = 0;
    [JsonPropertyName("token_value")]
    public int TokenValue { get; set; } = 0;
    [JsonPropertyName("call_value")]
    public int CallValue { get; set; } = 0;
    [JsonPropertyName("data")]
    public string Data { get; set; } = "";
    [JsonPropertyName("confirmed")]
    public bool Confirmed { get; set; } = false;
    [JsonPropertyName("method")]
    public string Method { get; set; } = "";
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; } = "";
    [JsonPropertyName("day")]
    public string Day { get; set; } = "";
}

public class ContractEvent
{
    [JsonPropertyName("block_number")]
    public long BlockNumber { get; set; } = 0;
    [JsonPropertyName("block_timestamp")]
    public long BlockTimestamp { get; set; } = 0;
    [JsonPropertyName("caller_contract_address")]
    public string CallerContractAddress { get; set; } = "";
    [JsonPropertyName("contract_address")]
    public string ContractAddress { get; set; } = "";
    [JsonPropertyName("event_index")]
    public int Index { get; set; } = 0;
    [JsonPropertyName("event_name")]
    public string Name { get; set; } = "";
    [JsonPropertyName("result_with_topic")]
    public ResultWithTopic ResultWithTopic { get; set; } = new();
    [JsonPropertyName("result")]
    public EventResult Result { get; set; } = new();
    [JsonPropertyName("result_type")]
    public EventResultType ResultType { get; set; } = new();
    [JsonPropertyName("event")]
    public string Event { get; set; } = "";
    [JsonPropertyName("transaction_id")]
    public string TransactionId { get; set; } = "";
    [JsonPropertyName("list")]
    public List<EventResultListItem> List { get; set; } = [];
}