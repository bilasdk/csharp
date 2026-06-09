using System;
using System.Threading;
using System.Threading.Tasks;
using Usebila.Core;
using Usebila.Models.Accounts;

namespace Usebila.Services;

/// <summary>
/// Account/wallet management endpoints
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface IAccountService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IAccountServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAccountService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Retrieve a single account by its UUID
    /// </summary>
    Task<AccountRetrieveResponse> Retrieve(
        AccountRetrieveParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Retrieve(AccountRetrieveParams, CancellationToken)"/>
    Task<AccountRetrieveResponse> Retrieve(
        string id,
        AccountRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve a paginated list of accounts/wallets for the authenticated merchant
    /// </summary>
    Task<AccountListResponse> List(
        AccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve the balance of a specific account
    /// </summary>
    Task<AccountGetBalanceResponse> GetBalance(
        AccountGetBalanceParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="GetBalance(AccountGetBalanceParams, CancellationToken)"/>
    Task<AccountGetBalanceResponse> GetBalance(
        string id,
        AccountGetBalanceParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IAccountService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IAccountServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IAccountServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/accounts/{id}</c>, but is otherwise the
    /// same as <see cref="IAccountService.Retrieve(AccountRetrieveParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AccountRetrieveResponse>> Retrieve(
        AccountRetrieveParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Retrieve(AccountRetrieveParams, CancellationToken)"/>
    Task<HttpResponse<AccountRetrieveResponse>> Retrieve(
        string id,
        AccountRetrieveParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/accounts</c>, but is otherwise the
    /// same as <see cref="IAccountService.List(AccountListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AccountListResponse>> List(
        AccountListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/accounts/{id}/balance</c>, but is otherwise the
    /// same as <see cref="IAccountService.GetBalance(AccountGetBalanceParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<AccountGetBalanceResponse>> GetBalance(
        AccountGetBalanceParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="GetBalance(AccountGetBalanceParams, CancellationToken)"/>
    Task<HttpResponse<AccountGetBalanceResponse>> GetBalance(
        string id,
        AccountGetBalanceParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
