using System;
using Bila.Models.Banks;

namespace Bila.Tests.Models.Banks;

public class BankListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new BankListParams { Country = "zm" };

        string expectedCountry = "zm";

        Assert.Equal(expectedCountry, parameters.Country);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new BankListParams { };

        Assert.Null(parameters.Country);
        Assert.False(parameters.RawQueryData.ContainsKey("country"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new BankListParams
        {
            // Null should be interpreted as omitted for these properties
            Country = null,
        };

        Assert.Null(parameters.Country);
        Assert.False(parameters.RawQueryData.ContainsKey("country"));
    }

    [Fact]
    public void Url_Works()
    {
        BankListParams parameters = new() { Country = "zm" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(new Uri("https://api.usebila.com/api/v1/bila/banks?country=zm"), url)
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new BankListParams { Country = "zm" };

        BankListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
