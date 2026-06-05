using System;
using System.Threading;
using System.Threading.Tasks;
using Usebila.Core;
using Usebila.Models.Transfers;

namespace Usebila.Services;

/// <summary>
/// Payout/transfer operation endpoints
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface ITransferService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ITransferServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ITransferService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Retrieve a single transfer by its UUID
    /// </summary>
    Task<TransferRetrieveResponse> Retrieve(
        TransferRetrieveParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Retrieve(TransferRetrieveParams, CancellationToken)"/>
    Task<TransferRetrieveResponse> Retrieve(
        string id,
        TransferRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of transfers/payouts for the authenticated merchant
    /// </summary>
    Task<TransferListResponse> List(
        TransferListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve transfer status by client reference
    /// </summary>
    Task<TransferGetStatusByReferenceResponse> GetStatusByReference(
        TransferGetStatusByReferenceParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="GetStatusByReference(TransferGetStatusByReferenceParams, CancellationToken)"/>
    Task<TransferGetStatusByReferenceResponse> GetStatusByReference(
        string reference,
        TransferGetStatusByReferenceParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Initiate a transfer to a bank account. Creates a transaction record in your
    /// dashboard.
    /// </summary>
    Task<TransferInitiateBankTransferResponse> InitiateBankTransfer(
        TransferInitiateBankTransferParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Initiate a transfer to a mobile money account. Creates a transaction record in
    /// your dashboard.
    /// </summary>
    Task<TransferInitiateMobileMoneyTransferResponse> InitiateMobileMoneyTransfer(
        TransferInitiateMobileMoneyTransferParams parameters,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ITransferService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ITransferServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ITransferServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/transfers/{id}</c>, but is otherwise the
    /// same as <see cref="ITransferService.Retrieve(TransferRetrieveParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TransferRetrieveResponse>> Retrieve(
        TransferRetrieveParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Retrieve(TransferRetrieveParams, CancellationToken)"/>
    Task<HttpResponse<TransferRetrieveResponse>> Retrieve(
        string id,
        TransferRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/transfers</c>, but is otherwise the
    /// same as <see cref="ITransferService.List(TransferListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TransferListResponse>> List(
        TransferListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/transfers/status/{reference}</c>, but is otherwise the
    /// same as <see cref="ITransferService.GetStatusByReference(TransferGetStatusByReferenceParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TransferGetStatusByReferenceResponse>> GetStatusByReference(
        TransferGetStatusByReferenceParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="GetStatusByReference(TransferGetStatusByReferenceParams, CancellationToken)"/>
    Task<HttpResponse<TransferGetStatusByReferenceResponse>> GetStatusByReference(
        string reference,
        TransferGetStatusByReferenceParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>post /api/v1/bila/transfers/bank-account</c>, but is otherwise the
    /// same as <see cref="ITransferService.InitiateBankTransfer(TransferInitiateBankTransferParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TransferInitiateBankTransferResponse>> InitiateBankTransfer(
        TransferInitiateBankTransferParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>post /api/v1/bila/transfers/mobile-money</c>, but is otherwise the
    /// same as <see cref="ITransferService.InitiateMobileMoneyTransfer(TransferInitiateMobileMoneyTransferParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TransferInitiateMobileMoneyTransferResponse>> InitiateMobileMoneyTransfer(
        TransferInitiateMobileMoneyTransferParams parameters,
        CancellationToken cancellationToken = default
    );
}
