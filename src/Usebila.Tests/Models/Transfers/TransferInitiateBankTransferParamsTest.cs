using System;
using System.Text.Json;
using Usebila.Core;
using Usebila.Exceptions;
using Usebila.Models.Transfers;

namespace Usebila.Tests.Models.Transfers;

public class TransferInitiateBankTransferParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new TransferInitiateBankTransferParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            Amount = 1000,
            Reference = "transfer-001",
            AccountNumber = "1234567890",
            BankID = "bank-001",
            Country = Country.Zm,
            Narration = "Payment for services",
            RecipientName = "Jane Doe",
            TransferRecipientID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        string expectedAccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        double expectedAmount = 1000;
        string expectedReference = "transfer-001";
        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        ApiEnum<string, Country> expectedCountry = Country.Zm;
        string expectedNarration = "Payment for services";
        string expectedRecipientName = "Jane Doe";
        string expectedTransferRecipientID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedWalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedAmount, parameters.Amount);
        Assert.Equal(expectedReference, parameters.Reference);
        Assert.Equal(expectedAccountNumber, parameters.AccountNumber);
        Assert.Equal(expectedBankID, parameters.BankID);
        Assert.Equal(expectedCountry, parameters.Country);
        Assert.Equal(expectedNarration, parameters.Narration);
        Assert.Equal(expectedRecipientName, parameters.RecipientName);
        Assert.Equal(expectedTransferRecipientID, parameters.TransferRecipientID);
        Assert.Equal(expectedWalletID, parameters.WalletID);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new TransferInitiateBankTransferParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            Amount = 1000,
            Reference = "transfer-001",
        };

        Assert.Null(parameters.AccountNumber);
        Assert.False(parameters.RawBodyData.ContainsKey("accountNumber"));
        Assert.Null(parameters.BankID);
        Assert.False(parameters.RawBodyData.ContainsKey("bankId"));
        Assert.Null(parameters.Country);
        Assert.False(parameters.RawBodyData.ContainsKey("country"));
        Assert.Null(parameters.Narration);
        Assert.False(parameters.RawBodyData.ContainsKey("narration"));
        Assert.Null(parameters.RecipientName);
        Assert.False(parameters.RawBodyData.ContainsKey("recipientName"));
        Assert.Null(parameters.TransferRecipientID);
        Assert.False(parameters.RawBodyData.ContainsKey("transferRecipientId"));
        Assert.Null(parameters.WalletID);
        Assert.False(parameters.RawBodyData.ContainsKey("walletId"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new TransferInitiateBankTransferParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            Amount = 1000,
            Reference = "transfer-001",

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankID = null,
            Country = null,
            Narration = null,
            RecipientName = null,
            TransferRecipientID = null,
            WalletID = null,
        };

        Assert.Null(parameters.AccountNumber);
        Assert.False(parameters.RawBodyData.ContainsKey("accountNumber"));
        Assert.Null(parameters.BankID);
        Assert.False(parameters.RawBodyData.ContainsKey("bankId"));
        Assert.Null(parameters.Country);
        Assert.False(parameters.RawBodyData.ContainsKey("country"));
        Assert.Null(parameters.Narration);
        Assert.False(parameters.RawBodyData.ContainsKey("narration"));
        Assert.Null(parameters.RecipientName);
        Assert.False(parameters.RawBodyData.ContainsKey("recipientName"));
        Assert.Null(parameters.TransferRecipientID);
        Assert.False(parameters.RawBodyData.ContainsKey("transferRecipientId"));
        Assert.Null(parameters.WalletID);
        Assert.False(parameters.RawBodyData.ContainsKey("walletId"));
    }

    [Fact]
    public void Url_Works()
    {
        TransferInitiateBankTransferParams parameters = new()
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            Amount = 1000,
            Reference = "transfer-001",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri("https://api.usebila.com/api/v1/bila/transfers/bank-account"),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new TransferInitiateBankTransferParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            Amount = 1000,
            Reference = "transfer-001",
            AccountNumber = "1234567890",
            BankID = "bank-001",
            Country = Country.Zm,
            Narration = "Payment for services",
            RecipientName = "Jane Doe",
            TransferRecipientID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        TransferInitiateBankTransferParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class CountryTest : TestBase
{
    [Theory]
    [InlineData(Country.Zm)]
    public void Validation_Works(Country rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Country> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Country>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Country.Zm)]
    public void SerializationRoundtrip_Works(Country rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Country> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Country>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Country>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Country>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
