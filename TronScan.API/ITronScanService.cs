using TronScan.API.Classes;

namespace TronScan.API;


public interface ITronScanService
{
    Task<AccountDetails?> GetAccountDetailsAsync(string address);
    Task<Account?> GetAccountAsync(string address);
    Task<AccountList?> GetAccountListAsync(int limit = 20, int start = 0, string? sort = "-balance", AccountList? accountList = null);
    Task<TokenList?> GetAccountTokenList(string address, int limit = 20, int start = 0, int hidden = 0, int show = 0, int sortType = 0, int sortBy = 0, string token = "", TokenList? tokenList = null);
    Task<VoteList?> GetVoteListAsync(string address, int limit = 20, int start = 0, VoteList? voteList = null);
    Task<AccountResourceList?> GetAccountResourcesV1Async(string address);
    Task<TransactionDetail?> GetTransactionDetailAsync(string hash);
}