using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Resolve;

namespace Bila.Tests.Models.Resolve;

public class ResolveMobileMoneyParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ResolveMobileMoneyParams
        {
            Country = ResolveMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
        };

        ApiEnum<string, ResolveMobileMoneyParamsCountry> expectedCountry =
            ResolveMobileMoneyParamsCountry.Zm;
        ApiEnum<string, Operator> expectedOperator = Operator.Airtel;
        string expectedPhone = "0977433571";

        Assert.Equal(expectedCountry, parameters.Country);
        Assert.Equal(expectedOperator, parameters.Operator);
        Assert.Equal(expectedPhone, parameters.Phone);
    }

    [Fact]
    public void Url_Works()
    {
        ResolveMobileMoneyParams parameters = new()
        {
            Country = ResolveMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri("https://api.usebila.com/api/v1/bila/resolve/mobile-money"),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new ResolveMobileMoneyParams
        {
            Country = ResolveMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
        };

        ResolveMobileMoneyParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class ResolveMobileMoneyParamsCountryTest : TestBase
{
    [Theory]
    [InlineData(ResolveMobileMoneyParamsCountry.Zm)]
    public void Validation_Works(ResolveMobileMoneyParamsCountry rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResolveMobileMoneyParamsCountry> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResolveMobileMoneyParamsCountry>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(ResolveMobileMoneyParamsCountry.Zm)]
    public void SerializationRoundtrip_Works(ResolveMobileMoneyParamsCountry rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, ResolveMobileMoneyParamsCountry> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ResolveMobileMoneyParamsCountry>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, ResolveMobileMoneyParamsCountry>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, ResolveMobileMoneyParamsCountry>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class OperatorTest : TestBase
{
    [Theory]
    [InlineData(Operator.Airtel)]
    [InlineData(Operator.Mtn)]
    [InlineData(Operator.Zamtel)]
    public void Validation_Works(Operator rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Operator> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Operator>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Operator.Airtel)]
    [InlineData(Operator.Mtn)]
    [InlineData(Operator.Zamtel)]
    public void SerializationRoundtrip_Works(Operator rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Operator> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Operator>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Operator>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Operator>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
