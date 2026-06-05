using System;
using System.Text.Json;
using Usebila.Core;
using Accounts = Usebila.Models.Accounts;

namespace Usebila.Tests.Models.Accounts;

public class AccountRetrieveResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Accounts::AccountRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Details = new()
                {
                    AccountName = "John Doe",
                    Type = "bank-account",
                    TillNumber = "123456",
                },
                Status = Accounts::Status.Active,
                Type = Accounts::Type.Main,
                AvailableBalance = "1500.00",
                LedgerBalance = "1500.00",
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        Accounts::AccountResponseDto expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = Accounts::Status.Active,
            Type = Accounts::Type.Main,
            AvailableBalance = "1500.00",
            LedgerBalance = "1500.00",
        };

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Accounts::AccountRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Details = new()
                {
                    AccountName = "John Doe",
                    Type = "bank-account",
                    TillNumber = "123456",
                },
                Status = Accounts::Status.Active,
                Type = Accounts::Type.Main,
                AvailableBalance = "1500.00",
                LedgerBalance = "1500.00",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Accounts::AccountRetrieveResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Accounts::AccountRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Details = new()
                {
                    AccountName = "John Doe",
                    Type = "bank-account",
                    TillNumber = "123456",
                },
                Status = Accounts::Status.Active,
                Type = Accounts::Type.Main,
                AvailableBalance = "1500.00",
                LedgerBalance = "1500.00",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Accounts::AccountRetrieveResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        Accounts::AccountResponseDto expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = Accounts::Status.Active,
            Type = Accounts::Type.Main,
            AvailableBalance = "1500.00",
            LedgerBalance = "1500.00",
        };

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Accounts::AccountRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Details = new()
                {
                    AccountName = "John Doe",
                    Type = "bank-account",
                    TillNumber = "123456",
                },
                Status = Accounts::Status.Active,
                Type = Accounts::Type.Main,
                AvailableBalance = "1500.00",
                LedgerBalance = "1500.00",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Accounts::AccountRetrieveResponse
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
        var model = new Accounts::AccountRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Accounts::AccountRetrieveResponse
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
        var model = new Accounts::AccountRetrieveResponse
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
        var model = new Accounts::AccountRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Details = new()
                {
                    AccountName = "John Doe",
                    Type = "bank-account",
                    TillNumber = "123456",
                },
                Status = Accounts::Status.Active,
                Type = Accounts::Type.Main,
                AvailableBalance = "1500.00",
                LedgerBalance = "1500.00",
            },
        };

        Accounts::AccountRetrieveResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
