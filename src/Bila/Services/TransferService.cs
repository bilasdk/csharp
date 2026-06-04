using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Transfers;

namespace Bila.Services;

/// <inheritdoc/>
public sealed class TransferService : ITransferService
{
    readonly Lazy<ITransferServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ITransferServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IBilaClient _client;

    /// <inheritdoc/>
    public ITransferService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TransferService(this._client.WithOptions(modifier));
    }

    public TransferService(IBilaClient client)
    {
        _client = client;

        _withRawResponse = new(() => new TransferServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<TransferRetrieveResponse> Retrieve(
        TransferRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Retrieve(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<TransferRetrieveResponse> Retrieve(
        string id,
        TransferRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<TransferListResponse> List(
        TransferListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<TransferGetStatusByReferenceResponse> GetStatusByReference(
        TransferGetStatusByReferenceParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.GetStatusByReference(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<TransferGetStatusByReferenceResponse> GetStatusByReference(
        string reference,
        TransferGetStatusByReferenceParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.GetStatusByReference(
            parameters with
            {
                Reference = reference,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<TransferInitiateBankTransferResponse> InitiateBankTransfer(
        TransferInitiateBankTransferParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.InitiateBankTransfer(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<TransferInitiateMobileMoneyTransferResponse> InitiateMobileMoneyTransfer(
        TransferInitiateMobileMoneyTransferParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.InitiateMobileMoneyTransfer(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class TransferServiceWithRawResponse : ITransferServiceWithRawResponse
{
    readonly IBilaClientWithRawResponse _client;

    /// <inheritdoc/>
    public ITransferServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TransferServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public TransferServiceWithRawResponse(IBilaClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TransferRetrieveResponse>> Retrieve(
        TransferRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<TransferRetrieveParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var transfer = await response
                    .Deserialize<TransferRetrieveResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    transfer.Validate();
                }
                return transfer;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<TransferRetrieveResponse>> Retrieve(
        string id,
        TransferRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TransferListResponse>> List(
        TransferListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<TransferListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var transfers = await response
                    .Deserialize<TransferListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    transfers.Validate();
                }
                return transfers;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TransferGetStatusByReferenceResponse>> GetStatusByReference(
        TransferGetStatusByReferenceParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.Reference == null)
        {
            throw new BilaInvalidDataException("'parameters.Reference' cannot be null");
        }

        HttpRequest<TransferGetStatusByReferenceParams> request = new()
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
                    .Deserialize<TransferGetStatusByReferenceResponse>(token)
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
    public Task<HttpResponse<TransferGetStatusByReferenceResponse>> GetStatusByReference(
        string reference,
        TransferGetStatusByReferenceParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.GetStatusByReference(
            parameters with
            {
                Reference = reference,
            },
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TransferInitiateBankTransferResponse>> InitiateBankTransfer(
        TransferInitiateBankTransferParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<TransferInitiateBankTransferParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<TransferInitiateBankTransferResponse>(token)
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
    public async Task<
        HttpResponse<TransferInitiateMobileMoneyTransferResponse>
    > InitiateMobileMoneyTransfer(
        TransferInitiateMobileMoneyTransferParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<TransferInitiateMobileMoneyTransferParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<TransferInitiateMobileMoneyTransferResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    deserializedResponse.Validate();
                }
                return deserializedResponse;
            }
        );
    }
}
