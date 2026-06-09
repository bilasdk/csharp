using System;
using System.Threading;
using System.Threading.Tasks;
using Usebila.Core;
using Usebila.Models.TransferRecipients;

namespace Usebila.Services;

/// <summary>
/// Transfer recipient management endpoints
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface ITransferRecipientService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    ITransferRecipientServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ITransferRecipientService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Retrieve a single transfer recipient by its UUID
    /// </summary>
    Task<TransferRecipientRetrieveResponse> Retrieve(
        TransferRecipientRetrieveParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Retrieve(TransferRecipientRetrieveParams, CancellationToken)"/>
    Task<TransferRecipientRetrieveResponse> Retrieve(
        string id,
        TransferRecipientRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of saved transfer recipients
    /// </summary>
    Task<TransferRecipientListResponse> List(
        TransferRecipientListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new bank account transfer recipient
    /// </summary>
    Task<TransferRecipientCreateBankAccountResponse> CreateBankAccount(
        TransferRecipientCreateBankAccountParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new mobile money transfer recipient
    /// </summary>
    Task<TransferRecipientCreateMobileMoneyResponse> CreateMobileMoney(
        TransferRecipientCreateMobileMoneyParams parameters,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="ITransferRecipientService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface ITransferRecipientServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    ITransferRecipientServiceWithRawResponse WithOptions(
        Func<ClientOptions, ClientOptions> modifier
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/transfer-recipients/{id}</c>, but is otherwise the
    /// same as <see cref="ITransferRecipientService.Retrieve(TransferRecipientRetrieveParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TransferRecipientRetrieveResponse>> Retrieve(
        TransferRecipientRetrieveParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Retrieve(TransferRecipientRetrieveParams, CancellationToken)"/>
    Task<HttpResponse<TransferRecipientRetrieveResponse>> Retrieve(
        string id,
        TransferRecipientRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/transfer-recipients</c>, but is otherwise the
    /// same as <see cref="ITransferRecipientService.List(TransferRecipientListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TransferRecipientListResponse>> List(
        TransferRecipientListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>post /api/v1/bila/transfer-recipients/bank-account</c>, but is otherwise the
    /// same as <see cref="ITransferRecipientService.CreateBankAccount(TransferRecipientCreateBankAccountParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TransferRecipientCreateBankAccountResponse>> CreateBankAccount(
        TransferRecipientCreateBankAccountParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>post /api/v1/bila/transfer-recipients/mobile-money</c>, but is otherwise the
    /// same as <see cref="ITransferRecipientService.CreateMobileMoney(TransferRecipientCreateMobileMoneyParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<TransferRecipientCreateMobileMoneyResponse>> CreateMobileMoney(
        TransferRecipientCreateMobileMoneyParams parameters,
        CancellationToken cancellationToken = default
    );
}
