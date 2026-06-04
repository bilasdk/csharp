using System;
using Bila.Models.Accounts;

namespace Bila.Tests.Models.Accounts;

public class AccountListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new AccountListParams { Page = 1, PerPage = 50 };

        double expectedPage = 1;
        double expectedPerPage = 50;

        Assert.Equal(expectedPage, parameters.Page);
        Assert.Equal(expectedPerPage, parameters.PerPage);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new AccountListParams { };

        Assert.Null(parameters.Page);
        Assert.False(parameters.RawQueryData.ContainsKey("page"));
        Assert.Null(parameters.PerPage);
        Assert.False(parameters.RawQueryData.ContainsKey("perPage"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new AccountListParams
        {
            // Null should be interpreted as omitted for these properties
            Page = null,
            PerPage = null,
        };

        Assert.Null(parameters.Page);
        Assert.False(parameters.RawQueryData.ContainsKey("page"));
        Assert.Null(parameters.PerPage);
        Assert.False(parameters.RawQueryData.ContainsKey("perPage"));
    }

    [Fact]
    public void Url_Works()
    {
        AccountListParams parameters = new() { Page = 1, PerPage = 50 };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri("https://api.usebila.com/api/v1/bila/accounts?page=1&perPage=50"),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new AccountListParams { Page = 1, PerPage = 50 };

        AccountListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
