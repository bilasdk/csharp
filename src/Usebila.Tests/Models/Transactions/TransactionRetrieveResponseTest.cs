using System;
using System.Text.Json;
using Usebila.Core;
using Usebila.Models.Transactions;

namespace Usebila.Tests.Models.Transactions;

public class TransactionRetrieveResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransactionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransactionResponseDto expectedData = new()
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

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransactionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransactionRetrieveResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransactionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransactionRetrieveResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransactionResponseDto expectedData = new()
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

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransactionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransactionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransactionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransactionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,

            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new TransactionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,

            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransactionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        TransactionRetrieveResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
