using TronScan.API.Classes;

namespace TronScan.API;


public interface ITronScanService
{
    Task<AccountDetails?> GetAccountDetailsAsync(string address);
    
    Task<Account?> GetAccountAsync(string address);
    
    Task<VoteList?> GetAccountVoteListAsync(string address);
    
    Task<AccountList?> GetAccountListAsync(int limit = 20, int start = 0, string? sort = "-balance", AccountList? accountList = null);
    
    Task<TokenList?> GetAccountTokenList(string address, int limit = 20, int start = 0, int hidden = 0, int show = 0, int sortType = 0, int sortBy = 0, string token = "", TokenList? tokenList = null);
    
    Task<VoteList?> GetVoteListAsync(string address, int limit = 20, int start = 0, VoteList? voteList = null);
    
    Task<AccountResourceList?> GetAccountResourcesV1Async(string address);
    
    Task<TransactionsList?> GetTransactionsListAsync(string? fromAddress = null, string? toAddress = null,
        int? limit = 20, long? block = null, int? start = 0, string? sort = "-timestamp",
        TransactionsList? transactionsList = null, bool? count = true);
    
    Task<TransactionDetail?> GetTransactionDetailAsync(string hash);
    
    Task<ChainParameters?> GetChainParametersAsync();
    
    Task<ProposalList?> GetProposalListAsync(int? limit = 20, int? start = 0, string? sort = "-number",
        string? address = null, ProposalList? proposalList = null);
    
    Task<WitnessVotingDetail?> GetWitnessVotingDetailAsync(string address);
    
    Task<WitnessList?> GetWitnessListAsync(int? witnessType = 0);
    
    Task<BlockList?> GetBlockListAsync(int? start = 0, int? limit = 10, string? producer = null,
        string? sort = "-number", long? startTimestamp = null, long? endTimestamp = null);

    Task<BlockStatistics?> GetBlockStatisticsAsync();

}