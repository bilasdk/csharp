using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Usebila.Core;
using Usebila.Exceptions;
using Usebila.Models.Accounts;

namespace Usebila.Services;

/// <inheritdoc/>
public sealed class AccountService : IAccountService
{
    readonly Lazy<IAccountServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IAccountServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IBilaClient _client;

    /// <inheritdoc/>
    public IAccountService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AccountService(this._client.WithOptions(modifier));
    }

    public AccountService(IBilaClient client)
    {
        _client = client;

        _withRawResponse = new(() => new AccountServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<AccountRetrieveResponse> Retrieve(
        AccountRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Retrieve(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<AccountRetrieveResponse> Retrieve(
        string id,
        AccountRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<AccountListResponse> List(
        AccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<AccountGetBalanceResponse> GetBalance(
        AccountGetBalanceParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.GetBalance(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<AccountGetBalanceResponse> GetBalance(
        string id,
        AccountGetBalanceParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.GetBalance(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class AccountServiceWithRawResponse : IAccountServiceWithRawResponse
{
    readonly IBilaClientWithRawResponse _client;

    /// <inheritdoc/>
    public IAccountServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new AccountServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public AccountServiceWithRawResponse(IBilaClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AccountRetrieveResponse>> Retrieve(
        AccountRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<AccountRetrieveParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var account = await response
                    .Deserialize<AccountRetrieveResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    account.Validate();
                }
                return account;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<AccountRetrieveResponse>> Retrieve(
        string id,
        AccountRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AccountListResponse>> List(
        AccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<AccountListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var accounts = await response
                    .Deserialize<AccountListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    accounts.Validate();
                }
                return accounts;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<AccountGetBalanceResponse>> GetBalance(
        AccountGetBalanceParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<AccountGetBalanceParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<AccountGetBalanceResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    deserializedResponse.Validate();
                }
                return deserializedResponse;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<AccountGetBalanceResponse>> GetBalance(
        string id,
        AccountGetBalanceParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.GetBalance(parameters with { ID = id }, cancellationToken);
    }
}
