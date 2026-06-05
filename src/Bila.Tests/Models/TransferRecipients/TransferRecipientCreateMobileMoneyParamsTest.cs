using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.TransferRecipients;

namespace Bila.Tests.Models.TransferRecipients;

public class TransferRecipientCreateMobileMoneyParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new TransferRecipientCreateMobileMoneyParams
        {
            Country = TransferRecipientCreateMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            AccountName = "John Doe",
        };

        ApiEnum<string, TransferRecipientCreateMobileMoneyParamsCountry> expectedCountry =
            TransferRecipientCreateMobileMoneyParamsCountry.Zm;
        ApiEnum<string, Operator> expectedOperator = Operator.Airtel;
        string expectedPhone = "0977433571";
        string expectedAccountName = "John Doe";

        Assert.Equal(expectedCountry, parameters.Country);
        Assert.Equal(expectedOperator, parameters.Operator);
        Assert.Equal(expectedPhone, parameters.Phone);
        Assert.Equal(expectedAccountName, parameters.AccountName);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new TransferRecipientCreateMobileMoneyParams
        {
            Country = TransferRecipientCreateMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
        };

        Assert.Null(parameters.AccountName);
        Assert.False(parameters.RawBodyData.ContainsKey("accountName"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new TransferRecipientCreateMobileMoneyParams
        {
            Country = TransferRecipientCreateMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",

            // Null should be interpreted as omitted for these properties
            AccountName = null,
        };

        Assert.Null(parameters.AccountName);
        Assert.False(parameters.RawBodyData.ContainsKey("accountName"));
    }

    [Fact]
    public void Url_Works()
    {
        TransferRecipientCreateMobileMoneyParams parameters = new()
        {
            Country = TransferRecipientCreateMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri("https://api.usebila.com/api/v1/bila/transfer-recipients/mobile-money"),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new TransferRecipientCreateMobileMoneyParams
        {
            Country = TransferRecipientCreateMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            AccountName = "John Doe",
        };

        TransferRecipientCreateMobileMoneyParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class TransferRecipientCreateMobileMoneyParamsCountryTest : TestBase
{
    [Theory]
    [InlineData(TransferRecipientCreateMobileMoneyParamsCountry.Zm)]
    public void Validation_Works(TransferRecipientCreateMobileMoneyParamsCountry rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferRecipientCreateMobileMoneyParamsCountry> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientCreateMobileMoneyParamsCountry>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferRecipientCreateMobileMoneyParamsCountry.Zm)]
    public void SerializationRoundtrip_Works(
        TransferRecipientCreateMobileMoneyParamsCountry rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferRecipientCreateMobileMoneyParamsCountry> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientCreateMobileMoneyParamsCountry>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientCreateMobileMoneyParamsCountry>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientCreateMobileMoneyParamsCountry>
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
