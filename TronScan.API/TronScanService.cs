using System.Text.Json;
using TronScan.API.Classes;

namespace TronScan.API;

public class TronScanService : ITronScanService
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://apilist.tronscan.org/api/";
    
    public TronScanService(HttpClient httpClient, string? tronScanApiKey = null)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _httpClient.BaseAddress = new Uri(BaseUrl);
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "TronScan.API Blazor Client");
        _httpClient.DefaultRequestHeaders.Add("TRON-PRO-API-KEY", tronScanApiKey ?? "");
    }

    /// <summary>
    /// Base method for GET requests.
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    private async Task<Stream> GetRequestAsync(string url)
    {
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStreamAsync();
    }

    /// <summary>
    /// Base method for POST requests.
    /// </summary>
    /// <param name="url"></param>
    /// <param name="content"></param>
    /// <returns></returns>
    private async Task<Stream> PostRequestAsync(string url, HttpContent content)
    {
        var response = await _httpClient.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStreamAsync();
    }

    #region Accounts

    public async Task<AccountDetails?> GetAccountDetailsAsync(string address)
    {
        try
        {
            var stream = await GetRequestAsync($"account?address={address}");
            return await JsonSerializer.DeserializeAsync<AccountDetails>(stream);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
    
    /// <summary>
    /// Returns the detail information of an account.
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    public async Task<Account?> GetAccountAsync(string address)
    {
        try
        {
            var stream = await GetRequestAsync($"account?address={address}");
            return await JsonSerializer.DeserializeAsync<Account>(stream);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
    
    /// <summary>
    /// Returns the list of accounts.
    /// Note : The value sum of start and limit must be less than or equal to 10000.
    /// In case the total number of accounts is greater than 10000, the function is recursive.
    /// </summary>
    /// <param name="limit"></param>
    /// <param name="start"></param>
    /// <param name="sort"></param>
    /// <param name="accountList"></param>
    /// <returns></returns>
    public async Task<AccountList?> GetAccountListAsync(int limit = 20, int start = 0, string? sort = "-balance", AccountList? accountList = null)
    {
        while (true)
        {
            try
            {
                var stream = await GetRequestAsync($"accounts?limit={limit}&start={start}&sort={sort}");
                var accountListResult = await JsonSerializer.DeserializeAsync<AccountList>(stream);
                if (accountList == null)
                {
                    accountList = accountListResult;
                }
                else
                {
                    if (accountListResult != null)
                    {
                        accountList.AccountNumber = accountListResult.AccountNumber;
                        accountList.Last24HAccountChange = accountListResult.Last24HAccountChange;
                        accountList.Total = accountListResult.Total;
                        accountList.Data.AddRange(accountListResult.Data);
                        foreach (var (key, value) in accountList.ContractMap)
                        {
                            accountList.ContractMap.TryAdd(key, value);
                        }
                        accountList.RangeTotal = accountListResult.RangeTotal;
                        foreach (var (key, value) in accountListResult.ContractInfo)
                        {
                            accountList.ContractInfo.Add(key, value);
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                if (accountList != null && accountList.Data.Count < limit)
                {
                    return accountList;
                }
                start += limit;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
    
    /// <summary>
    /// Returns a list of tokens held by the account with a balance greater than 0.
    /// Note : The maximum value for limit is 200.
    /// </summary>
    /// <param name="address"></param>
    /// <param name="limit"></param>
    /// <param name="start"></param>
    /// <param name="hidden"></param>
    /// <param name="show"></param>
    /// <param name="sortType"></param>
    /// <param name="sortBy"></param>
    /// <param name="token"></param>
    /// <param name="tokenList"></param>
    /// <returns></returns>
    public async Task<TokenList?> GetAccountTokenList(string address, int limit = 20, int start = 0, int hidden = 0, int show = 0, int sortType = 0, int sortBy = 0, string token = "", TokenList? tokenList = null)
    {
        while (true)
        {
            try
            {
                var stream = await GetRequestAsync($"account/tokens?address={address}&start={start}&limit={limit}&hidden={hidden}&show={show}&sortType={sortType}&sortBy={sortBy}&token={token}");
                var tokenListResult = await JsonSerializer.DeserializeAsync<TokenList>(stream);
                if (tokenList == null)
                {
                    tokenList = tokenListResult;
                }
                else
                {
                    if (tokenListResult != null)
                    {
                        tokenList.Total = tokenListResult.Total;
                        tokenList.Tokens.AddRange(tokenListResult.Tokens);
                    }
                    else
                    {
                        return null;
                    }
                }
                if (tokenList != null && tokenList.Tokens.Count < limit)
                {
                    return tokenList;
                }
                start += limit;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
    
    /// <summary>
    /// Returns the voter list of a certain SR or the voted list of a certain account involving all SRs.
    /// Note : The maximum value for limit is 200, in case the total number of votes is greater than 200, the start parameter should be used to get the next page.
    /// </summary>
    /// <param name="address"></param>
    /// <param name="limit"></param>
    /// <param name="start"></param>
    /// <param name="voteList"></param>
    /// <returns></returns>
    public async Task<VoteList?> GetVoteListAsync(string address, int limit = 20, int start = 0, VoteList? voteList = null)
    {
        while (true)
        {
            try
            {
                var stream = await GetRequestAsync($"vote?voter={address}&limit={limit}&start={start}");
                var voteListResult = await JsonSerializer.DeserializeAsync<VoteList>(stream);
                if (voteList == null)
                {
                    voteList = voteListResult;
                }
                else
                {
                    if (voteListResult != null)
                    {
                        voteList.Total = voteListResult.Total;
                        voteList.Votes.AddRange(voteListResult.Votes);
                    }
                    else
                    {
                        return null;
                    }
                }
                if (voteList != null && voteList.Votes.Count < limit)
                {
                    return voteList;
                }

                if (voteList != null)
                    start += voteList.Votes.Count;
                else
                    return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
    
    public async Task<AccountResourceList?> GetAccountResourcesV1Async(string address)
    {
        try
        {
            var stream = await GetRequestAsync($"account/resources?address={address}");
            return await JsonSerializer.DeserializeAsync<AccountResourceList>(stream);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
    
    #endregion

    #region Transactions

    public async Task<TransactionDetail?> GetTransactionDetailAsync(string hash)
    {
        try
        {
            var stream = await GetRequestAsync($"transaction-info?hash={hash}");
            return await JsonSerializer.DeserializeAsync<TransactionDetail>(stream);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    #endregion
}