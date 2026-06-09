using System;
using System.Threading;
using System.Threading.Tasks;
using Usebila.Core;
using Usebila.Models.Banks;

namespace Usebila.Services;

/// <summary>
/// Bank reference data endpoints
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface IBankService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IBankServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IBankService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Retrieve a list of all supported banks and financial institutions
    /// </summary>
    Task<BankListResponse> List(
        BankListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IBankService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IBankServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IBankServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/banks</c>, but is otherwise the
    /// same as <see cref="IBankService.List(BankListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<BankListResponse>> List(
        BankListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
