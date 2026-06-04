using System;
using System.Threading;
using System.Threading.Tasks;
using Bila.Core;
using Bila.Models.Accounts;
using Bila.Models.Webhooks;

namespace Bila.Services;

/// <summary>
/// Webhook configuration and delivery history
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public interface IWebhookService
{
    /// <summary>
    /// Returns a view of this service that provides access to raw HTTP responses
    /// for each method.
    /// </summary>
    IWebhookServiceWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IWebhookService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Create a webhook config
    /// </summary>
    Task<WebhookCreateResponse> Create(
        WebhookCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a webhook config
    /// </summary>
    Task<WebhookUpdateResponse> Update(
        WebhookUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(WebhookUpdateParams, CancellationToken)"/>
    Task<WebhookUpdateResponse> Update(
        string id,
        WebhookUpdateParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List webhook configs
    /// </summary>
    Task<WebhookListResponse> List(
        WebhookListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deactivate a webhook
    /// </summary>
    Task<BilaResponse> Deactivate(
        WebhookDeactivateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Deactivate(WebhookDeactivateParams, CancellationToken)"/>
    Task<BilaResponse> Deactivate(
        string id,
        WebhookDeactivateParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get delivery history
    /// </summary>
    Task<WebhookGetDeliveriesResponse> GetDeliveries(
        WebhookGetDeliveriesParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="GetDeliveries(WebhookGetDeliveriesParams, CancellationToken)"/>
    Task<WebhookGetDeliveriesResponse> GetDeliveries(
        string id,
        WebhookGetDeliveriesParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List webhook event types
    /// </summary>
    Task<WebhookListEventsResponse> ListEvents(
        WebhookListEventsParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Rotate webhook signing secret
    /// </summary>
    Task<WebhookRotateSecretResponse> RotateSecret(
        WebhookRotateSecretParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="RotateSecret(WebhookRotateSecretParams, CancellationToken)"/>
    Task<WebhookRotateSecretResponse> RotateSecret(
        string id,
        WebhookRotateSecretParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>
/// A view of <see cref="IWebhookService"/> that provides access to raw
/// HTTP responses for each method.
/// </summary>
public interface IWebhookServiceWithRawResponse
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IWebhookServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier);

    /// <summary>
    /// Returns a raw HTTP response for <c>post /api/v1/bila/webhooks</c>, but is otherwise the
    /// same as <see cref="IWebhookService.Create(WebhookCreateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<WebhookCreateResponse>> Create(
        WebhookCreateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>patch /api/v1/bila/webhooks/{id}</c>, but is otherwise the
    /// same as <see cref="IWebhookService.Update(WebhookUpdateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<WebhookUpdateResponse>> Update(
        WebhookUpdateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Update(WebhookUpdateParams, CancellationToken)"/>
    Task<HttpResponse<WebhookUpdateResponse>> Update(
        string id,
        WebhookUpdateParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/webhooks</c>, but is otherwise the
    /// same as <see cref="IWebhookService.List(WebhookListParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<WebhookListResponse>> List(
        WebhookListParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>delete /api/v1/bila/webhooks/{id}</c>, but is otherwise the
    /// same as <see cref="IWebhookService.Deactivate(WebhookDeactivateParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<BilaResponse>> Deactivate(
        WebhookDeactivateParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="Deactivate(WebhookDeactivateParams, CancellationToken)"/>
    Task<HttpResponse<BilaResponse>> Deactivate(
        string id,
        WebhookDeactivateParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/webhooks/{id}/deliveries</c>, but is otherwise the
    /// same as <see cref="IWebhookService.GetDeliveries(WebhookGetDeliveriesParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<WebhookGetDeliveriesResponse>> GetDeliveries(
        WebhookGetDeliveriesParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="GetDeliveries(WebhookGetDeliveriesParams, CancellationToken)"/>
    Task<HttpResponse<WebhookGetDeliveriesResponse>> GetDeliveries(
        string id,
        WebhookGetDeliveriesParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>get /api/v1/bila/webhooks/events</c>, but is otherwise the
    /// same as <see cref="IWebhookService.ListEvents(WebhookListEventsParams?, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<WebhookListEventsResponse>> ListEvents(
        WebhookListEventsParams? parameters = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a raw HTTP response for <c>post /api/v1/bila/webhooks/{id}/rotate-secret</c>, but is otherwise the
    /// same as <see cref="IWebhookService.RotateSecret(WebhookRotateSecretParams, CancellationToken)"/>.
    /// </summary>
    Task<HttpResponse<WebhookRotateSecretResponse>> RotateSecret(
        WebhookRotateSecretParams parameters,
        CancellationToken cancellationToken = default
    );

    /// <inheritdoc cref="RotateSecret(WebhookRotateSecretParams, CancellationToken)"/>
    Task<HttpResponse<WebhookRotateSecretResponse>> RotateSecret(
        string id,
        WebhookRotateSecretParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
