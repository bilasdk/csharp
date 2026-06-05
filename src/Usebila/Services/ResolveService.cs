using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Usebila.Core;
using Usebila.Models.Resolve;

namespace Usebila.Services;

/// <inheritdoc/>
public sealed class ResolveService : IResolveService
{
    readonly Lazy<IResolveServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IResolveServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IBilaClient _client;

    /// <inheritdoc/>
    public IResolveService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ResolveService(this._client.WithOptions(modifier));
    }

    public ResolveService(IBilaClient client)
    {
        _client = client;

        _withRawResponse = new(() => new ResolveServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<ResolveBankAccountResponse> BankAccount(
        ResolveBankAccountParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.BankAccount(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<ResolveMobileMoneyResponse> MobileMoney(
        ResolveMobileMoneyParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.MobileMoney(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class ResolveServiceWithRawResponse : IResolveServiceWithRawResponse
{
    readonly IBilaClientWithRawResponse _client;

    /// <inheritdoc/>
    public IResolveServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new ResolveServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public ResolveServiceWithRawResponse(IBilaClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<ResolveBankAccountResponse>> BankAccount(
        ResolveBankAccountParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<ResolveBankAccountParams> request = new()
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
                    .Deserialize<ResolveBankAccountResponse>(token)
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
    public async Task<HttpResponse<ResolveMobileMoneyResponse>> MobileMoney(
        ResolveMobileMoneyParams parameters,
        CancellationToken cancellationToken = default
    )
    {
        HttpRequest<ResolveMobileMoneyParams> request = new()
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
                    .Deserialize<ResolveMobileMoneyResponse>(token)
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
