using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bila.Core;
using Bila.Models.Banks;

namespace Bila.Services;

/// <inheritdoc/>
public sealed class BankService : IBankService
{
    readonly Lazy<IBankServiceWithRawResponse> _withRawResponse;

    /// <inheritdoc/>
    public IBankServiceWithRawResponse WithRawResponse
    {
        get { return _withRawResponse.Value; }
    }

    readonly IBilaClient _client;

    /// <inheritdoc/>
    public IBankService WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new BankService(this._client.WithOptions(modifier));
    }

    public BankService(IBilaClient client)
    {
        _client = client;

        _withRawResponse = new(() => new BankServiceWithRawResponse(client.WithRawResponse));
    }

    /// <inheritdoc/>
    public async Task<BankListResponse> List(
        BankListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        using var response = await this
            .WithRawResponse.List(parameters, cancellationToken)
            .ConfigureAwait(false);
        return await response.Deserialize(cancellationToken).ConfigureAwait(false);
    }
}

/// <inheritdoc/>
public sealed class BankServiceWithRawResponse : IBankServiceWithRawResponse
{
    readonly IBilaClientWithRawResponse _client;

    /// <inheritdoc/>
    public IBankServiceWithRawResponse WithOptions(Func<ClientOptions, ClientOptions> modifier)
    {
        return new BankServiceWithRawResponse(this._client.WithOptions(modifier));
    }

    public BankServiceWithRawResponse(IBilaClientWithRawResponse client)
    {
        _client = client;
    }

    /// <inheritdoc/>
    public async Task<HttpResponse<BankListResponse>> List(
        BankListParams? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        parameters ??= new();

        HttpRequest<BankListParams> request = new()
        {
            Method = HttpMethod.Get,
            Params = parameters,
        };
        var response = await this._client.Execute(request, cancellationToken).ConfigureAwait(false);
        return new(
            response,
            async (token) =>
            {
                var banks = await response
                    .Deserialize<BankListResponse>(token)
                    .ConfigureAwait(false);
                if (this._client.ResponseValidation)
                {
                    banks.Validate();
                }
                return banks;
            }
        );
    }
}
