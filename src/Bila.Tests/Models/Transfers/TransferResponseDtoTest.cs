using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Transfers;

namespace Bila.Tests.Models.Transfers;

public class TransferResponseDtoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferResponseDto
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferResponseDtoStatus.Successful,
            Type = TransferResponseDtoType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        string expectedID = "txn-001";
        double expectedAmount = 1000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        TransferRecipientDto expectedRecipient = new()
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "payout-12345";
        ApiEnum<string, TransferResponseDtoStatus> expectedStatus =
            TransferResponseDtoStatus.Successful;
        ApiEnum<string, TransferResponseDtoType> expectedType = TransferResponseDtoType.BankAccount;
        DateTimeOffset expectedCompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z");
        string expectedNarration = "Salary payment";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedRecipient, model.Recipient);
        Assert.Equal(expectedReference, model.Reference);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedCompletedAt, model.CompletedAt);
        Assert.Equal(expectedNarration, model.Narration);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferResponseDto
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferResponseDtoStatus.Successful,
            Type = TransferResponseDtoType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferResponseDto>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferResponseDto
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferResponseDtoStatus.Successful,
            Type = TransferResponseDtoType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferResponseDto>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "txn-001";
        double expectedAmount = 1000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        TransferRecipientDto expectedRecipient = new()
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "payout-12345";
        ApiEnum<string, TransferResponseDtoStatus> expectedStatus =
            TransferResponseDtoStatus.Successful;
        ApiEnum<string, TransferResponseDtoType> expectedType = TransferResponseDtoType.BankAccount;
        DateTimeOffset expectedCompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z");
        string expectedNarration = "Salary payment";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedRecipient, deserialized.Recipient);
        Assert.Equal(expectedReference, deserialized.Reference);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedCompletedAt, deserialized.CompletedAt);
        Assert.Equal(expectedNarration, deserialized.Narration);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferResponseDto
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferResponseDtoStatus.Successful,
            Type = TransferResponseDtoType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferResponseDto
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferResponseDtoStatus.Successful,
            Type = TransferResponseDtoType.BankAccount,
        };

        Assert.Null(model.CompletedAt);
        Assert.False(model.RawData.ContainsKey("completedAt"));
        Assert.Null(model.Narration);
        Assert.False(model.RawData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransferResponseDto
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferResponseDtoStatus.Successful,
            Type = TransferResponseDtoType.BankAccount,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferResponseDto
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferResponseDtoStatus.Successful,
            Type = TransferResponseDtoType.BankAccount,

            // Null should be interpreted as omitted for these properties
            CompletedAt = null,
            Narration = null,
        };

        Assert.Null(model.CompletedAt);
        Assert.False(model.RawData.ContainsKey("completedAt"));
        Assert.Null(model.Narration);
        Assert.False(model.RawData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new TransferResponseDto
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferResponseDtoStatus.Successful,
            Type = TransferResponseDtoType.BankAccount,

            // Null should be interpreted as omitted for these properties
            CompletedAt = null,
            Narration = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferResponseDto
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferResponseDtoStatus.Successful,
            Type = TransferResponseDtoType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        TransferResponseDto copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferResponseDtoStatusTest : TestBase
{
    [Theory]
    [InlineData(TransferResponseDtoStatus.Pending)]
    [InlineData(TransferResponseDtoStatus.Successful)]
    [InlineData(TransferResponseDtoStatus.Failed)]
    public void Validation_Works(TransferResponseDtoStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferResponseDtoStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TransferResponseDtoStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferResponseDtoStatus.Pending)]
    [InlineData(TransferResponseDtoStatus.Successful)]
    [InlineData(TransferResponseDtoStatus.Failed)]
    public void SerializationRoundtrip_Works(TransferResponseDtoStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferResponseDtoStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TransferResponseDtoStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TransferResponseDtoStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TransferResponseDtoStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class TransferResponseDtoTypeTest : TestBase
{
    [Theory]
    [InlineData(TransferResponseDtoType.BankAccount)]
    [InlineData(TransferResponseDtoType.MobileMoney)]
    public void Validation_Works(TransferResponseDtoType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferResponseDtoType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TransferResponseDtoType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferResponseDtoType.BankAccount)]
    [InlineData(TransferResponseDtoType.MobileMoney)]
    public void SerializationRoundtrip_Works(TransferResponseDtoType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferResponseDtoType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TransferResponseDtoType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TransferResponseDtoType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TransferResponseDtoType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
