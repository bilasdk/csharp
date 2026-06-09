using System;
using System.Text.Json;
using Usebila.Core;
using Usebila.Models.Transfers;

namespace Usebila.Tests.Models.Transfers;

public class TransferRetrieveResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransferResponseDto expectedData = new()
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

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferRetrieveResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferRetrieveResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransferResponseDto expectedData = new()
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

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferRetrieveResponse
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
        var model = new TransferRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferRetrieveResponse
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
        var model = new TransferRetrieveResponse
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
        var model = new TransferRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        TransferRetrieveResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
