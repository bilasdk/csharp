using System;
using System.Threading;
using System.Threading.Tasks;
using Bila.Core;
using Bila.Models.Resolve;

namespace Bila.Services;

/// <summary>
/// Account resolution/verification endpoints
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface IResolveService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IResolveServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IResolveService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Verify and retrieve bank account holder details
    /// </summary>
    Task<ResolveBankAccountResponse> BankAccount(
        ResolveBankAccountParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Verify and retrieve mobile money account holder details
    /// </summary>
    Task<ResolveMobileMoneyResponse> MobileMoney(
        ResolveMobileMoneyParams parameters,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IResolveService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IResolveServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IResolveServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>post /api/v1/bila/resolve/bank-account</c>, but is otherwise the
    /// same as <see cref="IResolveService.BankAccount(ResolveBankAccountParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ResolveBankAccountResponse>> BankAccount(
        ResolveBankAccountParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>post /api/v1/bila/resolve/mobile-money</c>, but is otherwise the
    /// same as <see cref="IResolveService.MobileMoney(ResolveMobileMoneyParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<ResolveMobileMoneyResponse>> MobileMoney(
        ResolveMobileMoneyParams parameters,
        CancellationToken cancellationToken = default
    );
}
