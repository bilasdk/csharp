using System;
using System.Threading;
using System.Threading.Tasks;
using Bila.Core;
using Bila.Models.Collections;

namespace Bila.Services;

/// <summary>
/// Payment collection operation endpoints
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface ICollectionService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ICollectionServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ICollectionService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Retrieve a single collection by its UUID
    /// </summary>
    Task<CollectionRetrieveResponse> Retrieve(
        CollectionRetrieveParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Retrieve(CollectionRetrieveParams, CancellationToken)"/>
    Task<CollectionRetrieveResponse> Retrieve(
        string id,
        CollectionRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of payment collections for the authenticated merchant
    /// </summary>
    Task<CollectionListResponse> List(
        CollectionListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve collection status by client reference
    /// </summary>
    Task<CollectionGetStatusByReferenceResponse> GetStatusByReference(
        CollectionGetStatusByReferenceParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="GetStatusByReference(CollectionGetStatusByReferenceParams, CancellationToken)"/>
    Task<CollectionGetStatusByReferenceResponse> GetStatusByReference(
        string reference,
        CollectionGetStatusByReferenceParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Initiate a payment collection from a mobile money account. Creates a transaction
    /// record in your dashboard.
    /// </summary>
    Task<CollectionInitiateMobileMoneyCollectionResponse> InitiateMobileMoneyCollection(
        CollectionInitiateMobileMoneyCollectionParams parameters,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ICollectionService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ICollectionServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ICollectionServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/collections/{id}</c>, but is otherwise the
    /// same as <see cref="ICollectionService.Retrieve(CollectionRetrieveParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CollectionRetrieveResponse>> Retrieve(
        CollectionRetrieveParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Retrieve(CollectionRetrieveParams, CancellationToken)"/>
    Task<HttpResponse<CollectionRetrieveResponse>> Retrieve(
        string id,
        CollectionRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/collections</c>, but is otherwise the
    /// same as <see cref="ICollectionService.List(CollectionListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CollectionListResponse>> List(
        CollectionListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/collections/status/{reference}</c>, but is otherwise the
    /// same as <see cref="ICollectionService.GetStatusByReference(CollectionGetStatusByReferenceParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<CollectionGetStatusByReferenceResponse>> GetStatusByReference(
        CollectionGetStatusByReferenceParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="GetStatusByReference(CollectionGetStatusByReferenceParams, CancellationToken)"/>
    Task<HttpResponse<CollectionGetStatusByReferenceResponse>> GetStatusByReference(
        string reference,
        CollectionGetStatusByReferenceParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>post /api/v1/bila/collections/mobile-money</c>, but is otherwise the
    /// same as <see cref="ICollectionService.InitiateMobileMoneyCollection(CollectionInitiateMobileMoneyCollectionParams, CancellationToken)"/>.
    /// </summary>
    Task<
        HttpResponse<CollectionInitiateMobileMoneyCollectionResponse>
    > InitiateMobileMoneyCollection(
        CollectionInitiateMobileMoneyCollectionParams parameters,
        CancellationToken cancellationToken = default
    );
}
