using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class SrConfirmList
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = "";

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("block")]
    public int Block { get; set; } = 0;

    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
}

public class TransactionCost
{
    [JsonPropertyName("net_fee_cost")]
    public int NetFeeCost { get; set; }

    [JsonPropertyName("fee")]
    public int Fee { get; set; }

    [JsonPropertyName("energy_fee_cost")]
    public int EnergyFeeCost { get; set; }

    [JsonPropertyName("net_usage")]
    public int NetUsage { get; set; }

    [JsonPropertyName("multi_sign_fee")]
    public int MultiSignFee { get; set; }

    [JsonPropertyName("net_fee")]
    public int NetFee { get; set; }

    [JsonPropertyName("energy_penalty_total")]
    public int EnergyPenaltyTotal { get; set; }

    [JsonPropertyName("energy_usage")]
    public int EnergyUsage { get; set; }

    [JsonPropertyName("energy_fee")]
    public int EnergyFee { get; set; }

    [JsonPropertyName("energy_usage_total")]
    public int EnergyUsageTotal { get; set; }

    [JsonPropertyName("memoFee")]
    public int MemoFee { get; set; }

    [JsonPropertyName("origin_energy_usage")]
    public int OriginEnergyUsage { get; set; }

    [JsonPropertyName("account_create_fee")]
    public int AccountCreateFee { get; set; }
}

public class TransactionDetail
{
    [JsonPropertyName("contract_map")]
    public Dictionary<string, bool> ContractMap { get; set; } = new();

    [JsonPropertyName("contractRet")]
    public string ContractRet { get; set; } = "";

    [JsonPropertyName("cost")]
    public TransactionCost Cost { get; set; } = new();

    [JsonPropertyName("data")]
    public string Data { get; set; } = "";

    [JsonPropertyName("contractInfo")]
    public Dictionary<string, object> ContractInfo { get; set; } = new();

    [JsonPropertyName("contractType")]
    public int ContractType { get; set; } = 0;

    [JsonPropertyName("addressTag")]
    public Dictionary<string, object> AddressTag { get; set; } = new();

    [JsonPropertyName("revert")]
    public bool Revert { get; set; } = false;

    [JsonPropertyName("confirmations")]
    public int Confirmations { get; set; } = 0;

    [JsonPropertyName("toAddress")]
    public string ToAddress { get; set; } = "";

    [JsonPropertyName("confirmed")]
    public bool Confirmed { get; set; } = false;

    [JsonPropertyName("trigger_info")]
    public Dictionary<string, object> TriggerInfo { get; set; } = new();

    [JsonPropertyName("block")]
    public int Block { get; set; } = 0;

    [JsonPropertyName("signature_addresses")]
    public List<object> SignatureAddresses { get; set; } = new();

    [JsonPropertyName("ownerAddress")]
    public string OwnerAddress { get; set; } = "";

    [JsonPropertyName("srConfirmList")]
    public List<SrConfirmList> SrConfirmList { get; set; } = new();

    [JsonPropertyName("riskTransaction")]
    public bool RiskTransaction { get; set; } = false;

    [JsonPropertyName("hash")]
    public string Hash { get; set; } = "";

    [JsonPropertyName("contractData")]
    public ContractData ContractData { get; set; } = new();

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; } = 0;

    [JsonPropertyName("internal_transactions")]
    public Dictionary<string, object> InternalTransactions { get; set; } = new();

    [JsonPropertyName("info")]
    public Dictionary<string, object> Info { get; set; } = new();

    [JsonPropertyName("normalAddressInfo")]
    public Dictionary<string, NormalAddressInfo> NormalAddressInfo { get; set; } = new();
}