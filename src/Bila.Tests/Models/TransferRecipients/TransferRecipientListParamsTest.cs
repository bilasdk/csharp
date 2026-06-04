using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using TransferRecipients = Bila.Models.TransferRecipients;

namespace Bila.Tests.Models.TransferRecipients;

public class TransferRecipientListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new TransferRecipients::TransferRecipientListParams
        {
            Page = 1,
            PerPage = 50,
            Type = TransferRecipients::Type.BankAccount,
        };

        double expectedPage = 1;
        double expectedPerPage = 50;
        ApiEnum<string, TransferRecipients::Type> expectedType =
            TransferRecipients::Type.BankAccount;

        Assert.Equal(expectedPage, parameters.Page);
        Assert.Equal(expectedPerPage, parameters.PerPage);
        Assert.Equal(expectedType, parameters.Type);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new TransferRecipients::TransferRecipientListParams { };

        Assert.Null(parameters.Page);
        Assert.False(parameters.RawQueryData.ContainsKey("page"));
        Assert.Null(parameters.PerPage);
        Assert.False(parameters.RawQueryData.ContainsKey("perPage"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new TransferRecipients::TransferRecipientListParams
        {
            // Null should be interpreted as omitted for these properties
            Page = null,
            PerPage = null,
            Type = null,
        };

        Assert.Null(parameters.Page);
        Assert.False(parameters.RawQueryData.ContainsKey("page"));
        Assert.Null(parameters.PerPage);
        Assert.False(parameters.RawQueryData.ContainsKey("perPage"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void Url_Works()
    {
        TransferRecipients::TransferRecipientListParams parameters = new()
        {
            Page = 1,
            PerPage = 50,
            Type = TransferRecipients::Type.BankAccount,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri(
                    "https://api.usebila.com/api/v1/bila/transfer-recipients?page=1&perPage=50&type=bank-account"
                ),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new TransferRecipients::TransferRecipientListParams
        {
            Page = 1,
            PerPage = 50,
            Type = TransferRecipients::Type.BankAccount,
        };

        TransferRecipients::TransferRecipientListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(TransferRecipients::Type.BankAccount)]
    [InlineData(TransferRecipients::Type.MobileMoney)]
    public void Validation_Works(TransferRecipients::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferRecipients::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TransferRecipients::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferRecipients::Type.BankAccount)]
    [InlineData(TransferRecipients::Type.MobileMoney)]
    public void SerializationRoundtrip_Works(TransferRecipients::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferRecipients::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TransferRecipients::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TransferRecipients::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TransferRecipients::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
