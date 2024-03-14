using System.Text.Json.Serialization;

namespace TronScan.API.Classes;

public class TokenDetails
{
    [JsonPropertyName("amount")]
    public string Amount { get; set; } = "";

    [JsonPropertyName("tokenPriceInTrx")]
    public int TokenPriceInTrx { get; set; } = 0;

    [JsonPropertyName("tokenId")]
    public string TokenId { get; set; } = "";

    [JsonPropertyName("balance")]
    public string Balance { get; set; } = "";

    [JsonPropertyName("tokenName")]
    public string TokenName { get; set; } = "";

    [JsonPropertyName("tokenDecimal")]
    public int TokenDecimal { get; set; } = 0;

    [JsonPropertyName("tokenAbbr")]
    public string TokenAbbr { get; set; } = "";

    [JsonPropertyName("tokenCanShow")]
    public int TokenCanShow { get; set; } = 0;

    [JsonPropertyName("tokenType")]
    public string TokenType { get; set; } = "";

    [JsonPropertyName("vip")]
    public bool Vip { get; set; } = false;

    [JsonPropertyName("tokenLogo")]
    public string TokenLogo { get; set; } = "";
}

public class Asset
{
    // Define properties according to your JSON structure
}

public class Bandwidth
{
    // Define properties according to your JSON structure
}

public class ActivePermission
{
    // Define properties according to your JSON structure
}

public class AccountDetails
{
    [JsonPropertyName("transactions_out")]
    public int TransactionsOut { get; set; } = 0;

    [JsonPropertyName("acquiredDelegateFrozenForBandWidth")]
    public int AcquiredDelegateFrozenForBandWidth { get; set; } = 0;

    [JsonPropertyName("rewardNum")]
    public int RewardNum { get; set; } = 0;

    [JsonPropertyName("greyTag")]
    public string GreyTag { get; set; } = "";

    [JsonPropertyName("ownerPermission")]
    public OwnerPermission OwnerPermission { get; set; } = new();

    [JsonPropertyName("redTag")]
    public string RedTag { get; set; } = "";

    [JsonPropertyName("publicTag")]
    public string PublicTag { get; set; } = "";

    [JsonPropertyName("withPriceTokens")]
    public List<TokenDetails> WithPriceTokens { get; set; } = new();

    [JsonPropertyName("delegateFrozenForEnergy")]
    public int DelegateFrozenForEnergy { get; set; } = 0;

    [JsonPropertyName("balance")]
    public int Balance { get; set; } = 0;

    [JsonPropertyName("feedbackRisk")]
    public bool FeedbackRisk { get; set; } = false;

    [JsonPropertyName("voteTotal")]
    public int VoteTotal { get; set; } = 0;

    [JsonPropertyName("totalFrozen")]
    public int TotalFrozen { get; set; } = 0;

    [JsonPropertyName("delegated")]
    public Dictionary<string, object> Delegated { get; set; } = new();

    [JsonPropertyName("transactions_in")]
    public int TransactionsIn { get; set; } = 0;

    [JsonPropertyName("latest_operation_time")]
    public long LatestOperationTime { get; set; } = 0;

    [JsonPropertyName("totalTransactionCount")]
    public int TotalTransactionCount { get; set; } = 0;

    [JsonPropertyName("representative")]
    public Representative Representative { get; set; } = new();

    [JsonPropertyName("frozenForBandWidth")]
    public int FrozenForBandWidth { get; set; } = 0;

    [JsonPropertyName("announcement")]
    public string Announcement { get; set; } = "";

    [JsonPropertyName("reward")]
    public int Reward { get; set; } = 0;

    [JsonPropertyName("addressTagLogo")]
    public string AddressTagLogo { get; set; } = "";

    [JsonPropertyName("allowExchange")]
    public List<object> AllowExchange { get; set; } = [];

    [JsonPropertyName("address")]
    public string Address { get; set; } = "";

    [JsonPropertyName("frozen_supply")]
    public List<object> FrozenSupply { get; set; } = [];

    [JsonPropertyName("bandwidth")]
    public Bandwidth Bandwidth { get; set; } = new();

    [JsonPropertyName("date_created")]
    public long DateCreated { get; set; } = 0;

    [JsonPropertyName("accountType")]
    public int AccountType { get; set; } = 0;

    [JsonPropertyName("exchanges")]
    public List<object> Exchanges { get; set; } = [];

    [JsonPropertyName("frozen")]
    public Dictionary<string, object> Frozen { get; set; } = new();

    [JsonPropertyName("accountResource")]
    public AccountResource AccountResource { get; set; } = new();

    [JsonPropertyName("transactions")]
    public int Transactions { get; set; } = 0;

    [JsonPropertyName("blueTag")]
    public string BlueTag { get; set; } = "";

    [JsonPropertyName("witness")]
    public int Witness { get; set; } = 0;

    [JsonPropertyName("delegateFrozenForBandWidth")]
    public int DelegateFrozenForBandWidth { get; set; } = 0;

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("frozenForEnergy")]
    public int FrozenForEnergy { get; set; } = 0;

    [JsonPropertyName("activated")]
    public bool Activated { get; set; } = false;

    [JsonPropertyName("acquiredDelegateFrozenForEnergy")]
    public int AcquiredDelegateFrozenForEnergy { get; set; } = 0;

    [JsonPropertyName("activePermissions")]
    public List<ActivePermission> ActivePermissions { get; set; } = [];
}

public class Representative
{
    [JsonPropertyName("lastWithDrawTime")]
    public int LastWithDrawTime { get; set; } = 0;

    [JsonPropertyName("allowance")]
    public int Allowance { get; set; } = 0;

    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; } = false;

    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
}
