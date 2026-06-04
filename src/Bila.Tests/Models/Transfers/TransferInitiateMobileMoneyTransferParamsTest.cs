using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Transfers;

namespace Bila.Tests.Models.Transfers;

public class TransferInitiateMobileMoneyTransferParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new TransferInitiateMobileMoneyTransferParams
        {
            Amount = 250,
            Country = TransferInitiateMobileMoneyTransferParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "mobile-transfer-001",
            Narration = "Mobile money payout",
            RecipientName = "Jane Doe",
            WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        double expectedAmount = 250;
        ApiEnum<string, TransferInitiateMobileMoneyTransferParamsCountry> expectedCountry =
            TransferInitiateMobileMoneyTransferParamsCountry.Zm;
        ApiEnum<string, Operator> expectedOperator = Operator.Airtel;
        string expectedPhone = "0977433571";
        string expectedReference = "mobile-transfer-001";
        string expectedNarration = "Mobile money payout";
        string expectedRecipientName = "Jane Doe";
        string expectedWalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

        Assert.Equal(expectedAmount, parameters.Amount);
        Assert.Equal(expectedCountry, parameters.Country);
        Assert.Equal(expectedOperator, parameters.Operator);
        Assert.Equal(expectedPhone, parameters.Phone);
        Assert.Equal(expectedReference, parameters.Reference);
        Assert.Equal(expectedNarration, parameters.Narration);
        Assert.Equal(expectedRecipientName, parameters.RecipientName);
        Assert.Equal(expectedWalletID, parameters.WalletID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new TransferInitiateMobileMoneyTransferParams
        {
            Amount = 250,
            Country = TransferInitiateMobileMoneyTransferParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "mobile-transfer-001",
        };

        Assert.Null(parameters.Narration);
        Assert.False(parameters.RawBodyData.ContainsKey("narration"));
        Assert.Null(parameters.RecipientName);
        Assert.False(parameters.RawBodyData.ContainsKey("recipientName"));
        Assert.Null(parameters.WalletID);
        Assert.False(parameters.RawBodyData.ContainsKey("walletId"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new TransferInitiateMobileMoneyTransferParams
        {
            Amount = 250,
            Country = TransferInitiateMobileMoneyTransferParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "mobile-transfer-001",

            // Null should be interpreted as omitted for these properties
            Narration = null,
            RecipientName = null,
            WalletID = null,
        };

        Assert.Null(parameters.Narration);
        Assert.False(parameters.RawBodyData.ContainsKey("narration"));
        Assert.Null(parameters.RecipientName);
        Assert.False(parameters.RawBodyData.ContainsKey("recipientName"));
        Assert.Null(parameters.WalletID);
        Assert.False(parameters.RawBodyData.ContainsKey("walletId"));
    }

    [Fact]
    public void Url_Works()
    {
        TransferInitiateMobileMoneyTransferParams parameters = new()
        {
            Amount = 250,
            Country = TransferInitiateMobileMoneyTransferParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "mobile-transfer-001",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri("https://api.usebila.com/api/v1/bila/transfers/mobile-money"),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new TransferInitiateMobileMoneyTransferParams
        {
            Amount = 250,
            Country = TransferInitiateMobileMoneyTransferParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "mobile-transfer-001",
            Narration = "Mobile money payout",
            RecipientName = "Jane Doe",
            WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        TransferInitiateMobileMoneyTransferParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class TransferInitiateMobileMoneyTransferParamsCountryTest : TestBase
{
    [Theory]
    [InlineData(TransferInitiateMobileMoneyTransferParamsCountry.Zm)]
    [InlineData(TransferInitiateMobileMoneyTransferParamsCountry.Ng)]
    public void Validation_Works(TransferInitiateMobileMoneyTransferParamsCountry rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferInitiateMobileMoneyTransferParamsCountry> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferInitiateMobileMoneyTransferParamsCountry>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferInitiateMobileMoneyTransferParamsCountry.Zm)]
    [InlineData(TransferInitiateMobileMoneyTransferParamsCountry.Ng)]
    public void SerializationRoundtrip_Works(
        TransferInitiateMobileMoneyTransferParamsCountry rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferInitiateMobileMoneyTransferParamsCountry> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferInitiateMobileMoneyTransferParamsCountry>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferInitiateMobileMoneyTransferParamsCountry>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferInitiateMobileMoneyTransferParamsCountry>
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
    [InlineData(Operator.Vodacom)]
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
    [InlineData(Operator.Vodacom)]
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
