using System;
using System.Text.Json;
using Usebila.Core;
using Usebila.Exceptions;
using Usebila.Models.Transactions;

namespace Usebila.Tests.Models.Transactions;

public class TransactionResponseDtoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransactionResponseDto
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = TransactionResponseDtoType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        string expectedID = "txn-001";
        string expectedAccountID = "acc-001";
        double expectedAmount = 1000;
        double expectedBalanceAfter = 6000;
        double expectedBalanceBefore = 5000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        ApiEnum<string, Status> expectedStatus = Status.Successful;
        ApiEnum<string, TransactionResponseDtoType> expectedType =
            TransactionResponseDtoType.Credit;
        string expectedDescription = "Mobile money collection";
        string expectedReference = "order-12345";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccountID, model.AccountID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedBalanceAfter, model.BalanceAfter);
        Assert.Equal(expectedBalanceBefore, model.BalanceBefore);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedReference, model.Reference);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransactionResponseDto
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = TransactionResponseDtoType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransactionResponseDto>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransactionResponseDto
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = TransactionResponseDtoType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransactionResponseDto>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "txn-001";
        string expectedAccountID = "acc-001";
        double expectedAmount = 1000;
        double expectedBalanceAfter = 6000;
        double expectedBalanceBefore = 5000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        ApiEnum<string, Status> expectedStatus = Status.Successful;
        ApiEnum<string, TransactionResponseDtoType> expectedType =
            TransactionResponseDtoType.Credit;
        string expectedDescription = "Mobile money collection";
        string expectedReference = "order-12345";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccountID, deserialized.AccountID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedBalanceAfter, deserialized.BalanceAfter);
        Assert.Equal(expectedBalanceBefore, deserialized.BalanceBefore);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedReference, deserialized.Reference);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransactionResponseDto
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = TransactionResponseDtoType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransactionResponseDto
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = TransactionResponseDtoType.Credit,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Reference);
        Assert.False(model.RawData.ContainsKey("reference"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransactionResponseDto
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = TransactionResponseDtoType.Credit,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransactionResponseDto
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = TransactionResponseDtoType.Credit,

            // Null should be interpreted as omitted for these properties
            Description = null,
            Reference = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Reference);
        Assert.False(model.RawData.ContainsKey("reference"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new TransactionResponseDto
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = TransactionResponseDtoType.Credit,

            // Null should be interpreted as omitted for these properties
            Description = null,
            Reference = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransactionResponseDto
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = TransactionResponseDtoType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        TransactionResponseDto copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Pending)]
    [InlineData(Status.Successful)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Cancelled)]
    public void Validation_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Status.Pending)]
    [InlineData(Status.Successful)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Cancelled)]
    public void SerializationRoundtrip_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class TransactionResponseDtoTypeTest : TestBase
{
    [Theory]
    [InlineData(TransactionResponseDtoType.Credit)]
    [InlineData(TransactionResponseDtoType.Debit)]
    public void Validation_Works(TransactionResponseDtoType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransactionResponseDtoType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TransactionResponseDtoType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransactionResponseDtoType.Credit)]
    [InlineData(TransactionResponseDtoType.Debit)]
    public void SerializationRoundtrip_Works(TransactionResponseDtoType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransactionResponseDtoType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TransactionResponseDtoType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, TransactionResponseDtoType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, TransactionResponseDtoType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
