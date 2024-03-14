## TronScan.API Blazor Client

This repository provides a Blazor client for interacting with the TronScan API. With this client, you can easily access various endpoints provided by the TronScan API to retrieve information related to the Tron blockchain.

### Prerequisites

Before using this client, ensure that you have the following:

- .NET 8 SDK installed on your machine.
- Basic knowledge of Blazor and C# programming.

### Installation

To install and use the TronScan.API Blazor Client in your Blazor application, follow these steps:

1. Add the `TronScan.API` package to your Blazor application. You can install it via NuGet Package Manager or by using the .NET CLI:

   ```bash
   dotnet add package TronScan.API
   ```

2. Configure the TronScan API service in your application. If you're using Blazor WebAssembly, you can do this in the `Program.cs` file:

   ```csharp
   builder.Services.AddTronScanAPI("YOUR_TRONSCAN_API_KEY_HERE");
   ```

   If you're using Blazor Server, you can configure it in the `Startup.cs` file.

### Configuration

After installing the necessary packages and configuring the TronScan API service, you can start using it in your Blazor components. Here's how you can use it:

```csharp
@page "/account-details/{address}"

@inject ITronScanService tronScanService
@inject NavigationManager navigation

<h3>Account Details</h3>

@if (accountDetails == null)
{
    <p>Loading...</p>
}
else
{
    <p>Account Address: @accountDetails.Address</p>
    <p>Balance: @accountDetails.Balance</p>
    <!-- Display other account details here -->
}

@code {
    private AccountDetails accountDetails;

    [Parameter]
    public string Address { get; set; }

    protected override async Task OnInitializedAsync()
    {
        accountDetails = await tronScanService.GetAccountDetailsAsync(Address);
    }
}
```

In the above example, we inject the `ITronScanService` into a Blazor component and use it to retrieve account details based on the provided address.

### Usage

Once you have configured the TronScan API service and injected it into your components, you can use its methods to interact with the TronScan API and retrieve various blockchain-related information.

Here are some of the methods available in the `ITronScanService` interface:

- `GetAccountDetailsAsync(address)`: Retrieves the detailed information of a Tron account based on the provided address.
- `GetAccountListAsync(limit, start, sort)`: Retrieves a list of Tron accounts.
- `GetAccountTokenList(address, limit, start, hidden, show, sortType, sortBy, token)`: Retrieves a list of tokens held by a Tron account.
- `GetVoteListAsync(address, limit, start)`: Retrieves the voter list of a certain Super Representative (SR) or the voted list of a certain account involving all SRs.
- `GetAccountResourcesV1Async(address)`: Returns the resource list of a Tron account that has resources in Stake 1.0.

Please refer to the [TronScan API documentation](https://apilist.tronscanapi.com/) for more details on available endpoints and their usage.

### Contributing

Contributions are welcome! If you encounter any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

### License

This project is licensed under the [MIT License](LICENSE).
