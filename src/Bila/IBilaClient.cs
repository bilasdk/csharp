using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bila.Core;
using Bila.Services;

namespace Bila;

/// <summary>
/// A client for interacting with the Bila REST API.
///
/// <para>This client performs best when you create a single instance and reuse it
/// for all interactions with the REST API. This is because each client holds its
/// own connection pool and thread pools. Reusing connections and threads reduces
/// latency and saves memory.</para>
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface IBilaClient : IDisposable
{
    /// <inheritdoc cref="ClientOptions.HttpClient" />
    HttpClient HttpClient { get; init; }

    /// <inheritdoc cref="ClientOptions.BaseUrl" />
    string BaseUrl { get; init; }

    /// <inheritdoc cref="ClientOptions.ResponseValidation" />
    bool ResponseValidation { get; init; }

    /// <inheritdoc cref="ClientOptions.MaxRetries" />
    int? MaxRetries { get; init; }

    /// <inheritdoc cref="ClientOptions.Timeout" />
    TimeSpan? Timeout { get; init; }

    /// <summary>
    /// Merchant API key (e.g., sk_live_xxx or sk_test_xxx)
    /// </summary>
    string ApiKey { get; init; }

    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IBilaClientWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IBilaClient WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IAccountService Accounts { get; }

    ITransferRecipientService TransferRecipients { get; }

    ITransferService Transfers { get; }

    ICollectionService Collections { get; }

    ITransactionService Transactions { get; }

    IWebhookService Webhooks { get; }

    IBankService Banks { get; }

    IResolveService Resolve { get; }
}

/// <summary>
/// A view of <see cref="IBilaClient"/> that provides access to raw HTTP responses for each method.
/// </summary>
public interface IBilaClientWithRawResponse : IDisposable
{
    /// <inheritdoc cref="ClientOptions.HttpClient" />
    HttpClient HttpClient { get; init; }

    /// <inheritdoc cref="ClientOptions.BaseUrl" />
    string BaseUrl { get; init; }

    /// <inheritdoc cref="ClientOptions.ResponseValidation" />
    bool ResponseValidation { get; init; }

    /// <inheritdoc cref="ClientOptions.MaxRetries" />
    int? MaxRetries { get; init; }

    /// <inheritdoc cref="ClientOptions.Timeout" />
    TimeSpan? Timeout { get; init; }

    /// <summary>
    /// Merchant API key (e.g., sk_live_xxx or sk_test_xxx)
    /// </summary>
    string ApiKey { get; init; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IBilaClientWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    IAccountServiceWithRawResponse Accounts { get; }

    ITransferRecipientServiceWithRawResponse TransferRecipients { get; }

    ITransferServiceWithRawResponse Transfers { get; }

    ICollectionServiceWithRawResponse Collections { get; }

    ITransactionServiceWithRawResponse Transactions { get; }

    IWebhookServiceWithRawResponse Webhooks { get; }

    IBankServiceWithRawResponse Banks { get; }

    IResolveServiceWithRawResponse Resolve { get; }

    /// <summary>
    /// Sends a request to the Bila REST API.
    /// </summary>
    Task<HttpResponse> Execute<T>(
        HttpRequest<T> request,
        CancellationToken cancellationToken = default
    )
        where T : ParamsBase;
}
