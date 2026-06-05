using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.TransferRecipients;

namespace Bila.Tests.Models.TransferRecipients;

public class RecipientResponseDtoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new RecipientResponseDto
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = RecipientResponseDtoType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedAccountName = "John Doe";
        string expectedCountry = "zm";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        ApiEnum<string, RecipientResponseDtoType> expectedType =
            RecipientResponseDtoType.BankAccount;
        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccountName, model.AccountName);
        Assert.Equal(expectedCountry, model.Country);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedBankID, model.BankID);
        Assert.Equal(expectedBankName, model.BankName);
        Assert.Equal(expectedOperator, model.Operator);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new RecipientResponseDto
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = RecipientResponseDtoType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RecipientResponseDto>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new RecipientResponseDto
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = RecipientResponseDtoType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<RecipientResponseDto>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedAccountName = "John Doe";
        string expectedCountry = "zm";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        ApiEnum<string, RecipientResponseDtoType> expectedType =
            RecipientResponseDtoType.BankAccount;
        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccountName, deserialized.AccountName);
        Assert.Equal(expectedCountry, deserialized.Country);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedBankID, deserialized.BankID);
        Assert.Equal(expectedBankName, deserialized.BankName);
        Assert.Equal(expectedOperator, deserialized.Operator);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new RecipientResponseDto
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = RecipientResponseDtoType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new RecipientResponseDto
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = RecipientResponseDtoType.BankAccount,
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
        Assert.Null(model.BankID);
        Assert.False(model.RawData.ContainsKey("bankId"));
        Assert.Null(model.BankName);
        Assert.False(model.RawData.ContainsKey("bankName"));
        Assert.Null(model.Operator);
        Assert.False(model.RawData.ContainsKey("operator"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new RecipientResponseDto
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = RecipientResponseDtoType.BankAccount,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new RecipientResponseDto
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = RecipientResponseDtoType.BankAccount,

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankID = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
        Assert.Null(model.BankID);
        Assert.False(model.RawData.ContainsKey("bankId"));
        Assert.Null(model.BankName);
        Assert.False(model.RawData.ContainsKey("bankName"));
        Assert.Null(model.Operator);
        Assert.False(model.RawData.ContainsKey("operator"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new RecipientResponseDto
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = RecipientResponseDtoType.BankAccount,

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankID = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new RecipientResponseDto
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = RecipientResponseDtoType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        RecipientResponseDto copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class RecipientResponseDtoTypeTest : TestBase
{
    [Theory]
    [InlineData(RecipientResponseDtoType.BankAccount)]
    [InlineData(RecipientResponseDtoType.MobileMoney)]
    public void Validation_Works(RecipientResponseDtoType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RecipientResponseDtoType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RecipientResponseDtoType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(RecipientResponseDtoType.BankAccount)]
    [InlineData(RecipientResponseDtoType.MobileMoney)]
    public void SerializationRoundtrip_Works(RecipientResponseDtoType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, RecipientResponseDtoType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, RecipientResponseDtoType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, RecipientResponseDtoType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, RecipientResponseDtoType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
