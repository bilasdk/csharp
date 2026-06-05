using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Webhooks;

namespace Bila.Services;

/// <inheritdoc/>
public sealed class WebhookService : IWebhookService
{
    readonly Lazy<IWebhookServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IWebhookServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IBilaClient _client;

    /// <inheritdoc/>
    public IWebhookService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new WebhookService(this._client.WithOptions(modifier));
    }

    public WebhookService(IBilaClient client)
    {
        _client = client;

        _withRawResponse = new(() => new WebhookServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<WebhookCreateResponse> Create(
        WebhookCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Create(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<WebhookUpdateResponse> Update(
        WebhookUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Update(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<WebhookUpdateResponse> Update(
        string id,
        WebhookUpdateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Update(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<WebhookListResponse> List(
        WebhookListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<WebhookDeactivateResponse> Deactivate(
        WebhookDeactivateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.Deactivate(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<WebhookDeactivateResponse> Deactivate(
        string id,
        WebhookDeactivateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Deactivate(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<WebhookGetDeliveriesResponse> GetDeliveries(
        WebhookGetDeliveriesParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.GetDeliveries(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<WebhookGetDeliveriesResponse> GetDeliveries(
        string id,
        WebhookGetDeliveriesParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.GetDeliveries(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<WebhookListEventsResponse> ListEvents(
        WebhookListEventsParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.ListEvents(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<WebhookRotateSecretResponse> RotateSecret(
        WebhookRotateSecretParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.RotateSecret(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public Task<WebhookRotateSecretResponse> RotateSecret(
        string id,
        WebhookRotateSecretParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.RotateSecret(parameters with { ID = id }, cancellationToken);
    }
}

/// <inheritdoc/>
public sealed class WebhookServiceWithRawResponse : IWebhookServiceWithRawResponse
{
    readonly IBilaClientWithRawResponse _client;

    /// <inheritdoc/>
    public IWebhookServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new WebhookServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public WebhookServiceWithRawResponse(IBilaClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WebhookCreateResponse>> Create(
        WebhookCreateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<WebhookCreateParams> request = new()
        {
            Method = HttpMethod.Post,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var webhook = await response
                    .Deserialize<WebhookCreateResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    webhook.Validate();
                }
                return webhook;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WebhookUpdateResponse>> Update(
        WebhookUpdateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<WebhookUpdateParams> request = new()
        {
            Method = BilaClientWithRawResponse.PatchMethod,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var webhook = await response
                    .Deserialize<WebhookUpdateResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    webhook.Validate();
                }
                return webhook;
            }
        );
    }

    /// <inheritdoc/>
    public Task<HttpResponse<WebhookUpdateResponse>> Update(
        string id,
        WebhookUpdateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Update(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WebhookListResponse>> List(
        WebhookListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<WebhookListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var webhooks = await response
                    .Deserialize<WebhookListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    webhooks.Validate();
                }
                return webhooks;
            }
        );
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WebhookDeactivateResponse>> Deactivate(
        WebhookDeactivateParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<WebhookDeactivateParams> request = new()
        {
            Method = HttpMethod.Delete,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var deserializedResponse = await response
                    .Deserialize<WebhookDeactivateResponse>(token)
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
    public Task<HttpResponse<WebhookDeactivateResponse>> Deactivate(
        string id,
        WebhookDeactivateParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.Deactivate(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WebhookGetDeliveriesResponse>> GetDeliveries(
        WebhookGetDeliveriesParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<WebhookGetDeliveriesParams> request = new()
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
                    .Deserialize<WebhookGetDeliveriesResponse>(token)
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
    public Task<HttpResponse<WebhookGetDeliveriesResponse>> GetDeliveries(
        string id,
        WebhookGetDeliveriesParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.GetDeliveries(parameters with { ID = id }, cancellationToken);
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<WebhookListEventsResponse>> ListEvents(
        WebhookListEventsParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<WebhookListEventsParams> request = new()
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
                    .Deserialize<WebhookListEventsResponse>(token)
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
    public async Task<HttpResponse<WebhookRotateSecretResponse>> RotateSecret(
        WebhookRotateSecretParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        if (parameters.ID == null)
        {
            throw new BilaInvalidDataException("'parameters.ID' cannot be null");
        }

        HttpRequest<WebhookRotateSecretParams> request = new()
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
                    .Deserialize<WebhookRotateSecretResponse>(token)
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
    public Task<HttpResponse<WebhookRotateSecretResponse>> RotateSecret(
        string id,
        WebhookRotateSecretParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        return this.RotateSecret(parameters with { ID = id }, cancellationToken);
    }
}
