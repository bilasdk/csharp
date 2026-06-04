using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Collections;

namespace Bila.Services;

/// <inheritdoc/>
public sealed class CollectionService : ICollectionService
{
    readonly Lazy<ICollectionServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public ICollectionServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IBilaClient _client;

    /// <inheritdoc/>
    public ICollectionService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new CollectionService(this._client.WithOptions(modifier));
    }

    public CollectionService(IBilaClient client)
    {
        _client = client;

        _withRawResponse = new(() => new CollectionServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<CollectionRetrieveResponse> Retrieve(
        CollectionRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Retrieve(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<CollectionRetrieveResponse> Retrieve(
        string id,
        CollectionRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<CollectionListResponse> List(
        CollectionListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<CollectionGetStatusByReferenceResponse> GetStatusByReference(
        CollectionGetStatusByReferenceParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.GetStatusByReference(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<CollectionGetStatusByReferenceResponse> GetStatusByReference(
        string reference,
        CollectionGetStatusByReferenceParams? parameters = null,
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
    public async Task<CollectionInitiateMobileMoneyCollectionResponse> InitiateMobileMoneyCollection(
        CollectionInitiateMobileMoneyCollectionParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.InitiateMobileMoneyCollection(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class CollectionServiceWithRawResponse : ICollectionServiceWithRawResponse
{
    readonly IBilaClientWithRawResponse _client;

    /// <inheritdoc/>
    public ICollectionServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    )
    {
        return new CollectionServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public CollectionServiceWithRawResponse(IBilaClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<CollectionRetrieveResponse>> Retrieve(
        CollectionRetrieveParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<CollectionRetrieveParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var collection = await response
                    .Deserialize<CollectionRetrieveResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    collection.Validate();
                }
                return collection;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<CollectionRetrieveResponse>> Retrieve(
        string id,
        CollectionRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Retrieve(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<CollectionListResponse>> List(
        CollectionListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<CollectionListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var collections = await response
                    .Deserialize<CollectionListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    collections.Validate();
                }
                return collections;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<CollectionGetStatusByReferenceResponse>> GetStatusByReference(
        CollectionGetStatusByReferenceParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.Reference == null)
        {
            throw new BilaInvalidDataException("'parameters.Reference' cannot be null");
        }

        HttpRequest<CollectionGetStatusByReferenceParams> request = new()
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
                    .Deserialize<CollectionGetStatusByReferenceResponse>(token)
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
    public Task<HttpResponse<CollectionGetStatusByReferenceResponse>> GetStatusByReference(
        string reference,
        CollectionGetStatusByReferenceParams? parameters = null,
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
    public async Task<
        HttpResponse<CollectionInitiateMobileMoneyCollectionResponse>
    > InitiateMobileMoneyCollection(
        CollectionInitiateMobileMoneyCollectionParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<CollectionInitiateMobileMoneyCollectionParams> request = new()
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
                    .Deserialize<CollectionInitiateMobileMoneyCollectionResponse>(token)
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
