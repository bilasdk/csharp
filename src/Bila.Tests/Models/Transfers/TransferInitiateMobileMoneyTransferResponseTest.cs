using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Transfers;

namespace Bila.Tests.Models.Transfers;

public class TransferInitiateMobileMoneyTransferResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponse
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data expectedData = new()
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
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
        var model = new TransferInitiateMobileMoneyTransferResponse
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferInitiateMobileMoneyTransferResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponse
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferInitiateMobileMoneyTransferResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data expectedData = new()
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
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
        var model = new TransferInitiateMobileMoneyTransferResponse
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponse
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
        var model = new TransferInitiateMobileMoneyTransferResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponse
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
        var model = new TransferInitiateMobileMoneyTransferResponse
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
        var model = new TransferInitiateMobileMoneyTransferResponse
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        TransferInitiateMobileMoneyTransferResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferInitiateMobileMoneyTransferResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1
        {
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data expectedData = new()
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1
        {
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferInitiateMobileMoneyTransferResponseIntersectionMember1>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1
        {
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferInitiateMobileMoneyTransferResponseIntersectionMember1>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data expectedData = new()
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1
        {
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1
        {
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
                Status =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
                Type =
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        };

        TransferInitiateMobileMoneyTransferResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        string expectedID = "txn-001";
        double expectedAmount = 1000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient expectedRecipient =
            new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            };
        string expectedReference = "payout-12345";
        ApiEnum<
            string,
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
        > expectedStatus =
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful;
        ApiEnum<
            string,
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType
        > expectedType =
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount;
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
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedID = "txn-001";
        double expectedAmount = 1000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient expectedRecipient =
            new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            };
        string expectedReference = "payout-12345";
        ApiEnum<
            string,
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
        > expectedStatus =
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful;
        ApiEnum<
            string,
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType
        > expectedType =
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount;
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
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
        };

        Assert.Null(model.CompletedAt);
        Assert.False(model.RawData.ContainsKey("completedAt"));
        Assert.Null(model.Narration);
        Assert.False(model.RawData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,

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
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,

            // Null should be interpreted as omitted for these properties
            CompletedAt = null,
            Narration = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
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
            Status =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            Type =
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipientTest
    : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string expectedAccountName = "JOHN DOE";
        string expectedAccountNumber = "1234567890";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedAccountName, model.AccountName);
        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedBankName, model.BankName);
        Assert.Equal(expectedOperator, model.Operator);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedAccountName = "JOHN DOE";
        string expectedAccountNumber = "1234567890";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedAccountName, deserialized.AccountName);
        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedBankName, deserialized.BankName);
        Assert.Equal(expectedOperator, deserialized.Operator);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
        {
            AccountName = "JOHN DOE",
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
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
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
        {
            AccountName = "JOHN DOE",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
        {
            AccountName = "JOHN DOE",

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
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
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
        {
            AccountName = "JOHN DOE",

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient copied = new(
            model
        );

        Assert.Equal(model, copied);
    }
}

public class TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatusTest : TestBase
{
    [Theory]
    [InlineData(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Pending)]
    [InlineData(
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful
    )]
    [InlineData(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Failed)]
    public void Validation_Works(
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
        > value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
            >
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Pending)]
    [InlineData(
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful
    )]
    [InlineData(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Failed)]
    public void SerializationRoundtrip_Works(
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
        > value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
            >
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
            >
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<
                string,
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
            >
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataTypeTest : TestBase
{
    [Theory]
    [InlineData(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount)]
    [InlineData(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.MobileMoney)]
    public void Validation_Works(
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType
        > value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount)]
    [InlineData(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.MobileMoney)]
    public void SerializationRoundtrip_Works(
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType
        > value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
