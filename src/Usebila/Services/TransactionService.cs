using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Usebila.Core;
using Usebila.Exceptions;
using Usebila.Models.Transactions;

namespace Usebila.Services;

/// <inheritdoc/>
public sealed class TransactionService : ITransactionService
{
    readonly Lazy<ITransactionServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ITransactionServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IBilaClient _client;

    /// <inheritdoc/>
    public ITransactionService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TransactionService(this._client.WithOptions(modifier));
    }

    public TransactionService(IBilaClient client)
    {
        _client = client;

        _withRawResponse = new(() => new TransactionServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<TransactionRetrieveResponse> Retrieve(
        TransactionRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Retrieve(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<TransactionRetrieveResponse> Retrieve(
        string id,
        TransactionRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<TransactionListResponse> List(
        TransactionListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class TransactionServiceWithRawResponse : ITransactionServiceWithRawResponse
{
    readonly IBilaClientWithRawResponse _client;

    /// <inheritdoc/>
    public ITransactionServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new TransactionServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public TransactionServiceWithRawResponse(IBilaClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TransactionRetrieveResponse>> Retrieve(
        TransactionRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<TransactionRetrieveParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var transaction = await response
                    .Deserialize<TransactionRetrieveResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    transaction.Validate();
                }
                return transaction;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<TransactionRetrieveResponse>> Retrieve(
        string id,
        TransactionRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TransactionListResponse>> List(
        TransactionListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<TransactionListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var transactions = await response
                    .Deserialize<TransactionListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    transactions.Validate();
                }
                return transactions;
            }
        );
    }
}
