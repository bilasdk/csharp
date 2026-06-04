using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.TransferRecipients;

namespace Bila.Services;

/// <inheritdoc/>
public sealed class TransferRecipientService : ITransferRecipientService
{
    readonly Lazy<ITransferRecipientServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ITransferRecipientServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IBilaClient _client;

    /// <inheritdoc/>
    public ITransferRecipientService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new TransferRecipientService(this._client.WithOptions(modifier));
    }

    public TransferRecipientService(IBilaClient client)
    {
        _client = client;

        _withRawResponse = new(() =>
            new TransferRecipientServiceWithRawResponse(client.WithRawResponse)
        );
    }

    /// <inheritdoc/>
    public async Task<TransferRecipientRetrieveResponse> Retrieve(
        TransferRecipientRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Retrieve(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<TransferRecipientRetrieveResponse> Retrieve(
        string id,
        TransferRecipientRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<TransferRecipientListResponse> List(
        TransferRecipientListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<TransferRecipientCreateBankAccountResponse> CreateBankAccount(
        TransferRecipientCreateBankAccountParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.CreateBankAccount(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<TransferRecipientCreateMobileMoneyResponse> CreateMobileMoney(
        TransferRecipientCreateMobileMoneyParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.CreateMobileMoney(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class TransferRecipientServiceWithRawResponse
    : ITransferRecipientServiceWithRawResponse
{
    readonly IBilaClientWithRawResponse _client;

    /// <inheritdoc/>
    public ITransferRecipientServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new TransferRecipientServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public TransferRecipientServiceWithRawResponse(IBilaClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TransferRecipientRetrieveResponse>> Retrieve(
        TransferRecipientRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<TransferRecipientRetrieveParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var transferRecipient = await response
                    .Deserialize<TransferRecipientRetrieveResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    transferRecipient.Validate();
                }
                return transferRecipient;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<TransferRecipientRetrieveResponse>> Retrieve(
        string id,
        TransferRecipientRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TransferRecipientListResponse>> List(
        TransferRecipientListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<TransferRecipientListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var transferRecipients = await response
                    .Deserialize<TransferRecipientListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    transferRecipients.Validate();
                }
                return transferRecipients;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<TransferRecipientCreateBankAccountResponse>> CreateBankAccount(
        TransferRecipientCreateBankAccountParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<TransferRecipientCreateBankAccountParams> request = new()
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
                    .Deserialize<TransferRecipientCreateBankAccountResponse>(token)
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
    public async Task<HttpResponse<TransferRecipientCreateMobileMoneyResponse>> CreateMobileMoney(
        TransferRecipientCreateMobileMoneyParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<TransferRecipientCreateMobileMoneyParams> request = new()
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
                    .Deserialize<TransferRecipientCreateMobileMoneyResponse>(token)
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
