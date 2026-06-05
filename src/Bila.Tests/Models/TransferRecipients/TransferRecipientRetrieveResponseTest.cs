using System;
using System.Text.Json;
using Bila.Core;
using Bila.Models.TransferRecipients;

namespace Bila.Tests.Models.TransferRecipients;

public class TransferRecipientRetrieveResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferRecipientRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        RecipientResponseDto expectedData = new()
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

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferRecipientRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferRecipientRetrieveResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferRecipientRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferRecipientRetrieveResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        RecipientResponseDto expectedData = new()
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

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferRecipientRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferRecipientRetrieveResponse
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
        var model = new TransferRecipientRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferRecipientRetrieveResponse
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
        var model = new TransferRecipientRetrieveResponse
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
        var model = new TransferRecipientRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        TransferRecipientRetrieveResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
