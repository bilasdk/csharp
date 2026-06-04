using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Accounts = Bila.Models.Accounts;

namespace Bila.Tests.Models.Accounts;

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
        Accounts::Data expectedData = new()
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
        Accounts::Data expectedData = new()
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

public class IntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Accounts::IntersectionMember1
        {
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

        Accounts::Data expectedData = new()
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

        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Accounts::IntersectionMember1
        {
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
        var deserialized = JsonSerializer.Deserialize<Accounts::IntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Accounts::IntersectionMember1
        {
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
        var deserialized = JsonSerializer.Deserialize<Accounts::IntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Accounts::Data expectedData = new()
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

        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Accounts::IntersectionMember1
        {
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
        var model = new Accounts::IntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Accounts::IntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Accounts::IntersectionMember1
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
        var model = new Accounts::IntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Accounts::IntersectionMember1
        {
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

        Accounts::IntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Accounts::Data
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

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        Accounts::Details expectedDetails = new()
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };
        ApiEnum<string, Accounts::Status> expectedStatus = Accounts::Status.Active;
        ApiEnum<string, Accounts::Type> expectedType = Accounts::Type.Main;
        string expectedAvailableBalance = "1500.00";
        string expectedLedgerBalance = "1500.00";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedDetails, model.Details);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedAvailableBalance, model.AvailableBalance);
        Assert.Equal(expectedLedgerBalance, model.LedgerBalance);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Accounts::Data
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

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Accounts::Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Accounts::Data
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

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Accounts::Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        Accounts::Details expectedDetails = new()
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };
        ApiEnum<string, Accounts::Status> expectedStatus = Accounts::Status.Active;
        ApiEnum<string, Accounts::Type> expectedType = Accounts::Type.Main;
        string expectedAvailableBalance = "1500.00";
        string expectedLedgerBalance = "1500.00";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedDetails, deserialized.Details);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedAvailableBalance, deserialized.AvailableBalance);
        Assert.Equal(expectedLedgerBalance, deserialized.LedgerBalance);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Accounts::Data
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

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Accounts::Data
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
        };

        Assert.Null(model.AvailableBalance);
        Assert.False(model.RawData.ContainsKey("availableBalance"));
        Assert.Null(model.LedgerBalance);
        Assert.False(model.RawData.ContainsKey("ledgerBalance"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Accounts::Data
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
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Accounts::Data
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

            // Null should be interpreted as omitted for these properties
            AvailableBalance = null,
            LedgerBalance = null,
        };

        Assert.Null(model.AvailableBalance);
        Assert.False(model.RawData.ContainsKey("availableBalance"));
        Assert.Null(model.LedgerBalance);
        Assert.False(model.RawData.ContainsKey("ledgerBalance"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Accounts::Data
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

            // Null should be interpreted as omitted for these properties
            AvailableBalance = null,
            LedgerBalance = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Accounts::Data
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

        Accounts::Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Accounts::Details
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        string expectedAccountName = "John Doe";
        string expectedType = "bank-account";
        string expectedTillNumber = "123456";

        Assert.Equal(expectedAccountName, model.AccountName);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedTillNumber, model.TillNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Accounts::Details
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Accounts::Details>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Accounts::Details
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Accounts::Details>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountName = "John Doe";
        string expectedType = "bank-account";
        string expectedTillNumber = "123456";

        Assert.Equal(expectedAccountName, deserialized.AccountName);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedTillNumber, deserialized.TillNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Accounts::Details
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Accounts::Details { AccountName = "John Doe", Type = "bank-account" };

        Assert.Null(model.TillNumber);
        Assert.False(model.RawData.ContainsKey("tillNumber"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Accounts::Details { AccountName = "John Doe", Type = "bank-account" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Accounts::Details
        {
            AccountName = "John Doe",
            Type = "bank-account",

            // Null should be interpreted as omitted for these properties
            TillNumber = null,
        };

        Assert.Null(model.TillNumber);
        Assert.False(model.RawData.ContainsKey("tillNumber"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Accounts::Details
        {
            AccountName = "John Doe",
            Type = "bank-account",

            // Null should be interpreted as omitted for these properties
            TillNumber = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Accounts::Details
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        Accounts::Details copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Accounts::Status.Active)]
    [InlineData(Accounts::Status.Inactive)]
    [InlineData(Accounts::Status.Suspended)]
    public void Validation_Works(Accounts::Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::Status> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Accounts::Status.Active)]
    [InlineData(Accounts::Status.Inactive)]
    [InlineData(Accounts::Status.Suspended)]
    public void SerializationRoundtrip_Works(Accounts::Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::Status> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Accounts::Type.Main)]
    [InlineData(Accounts::Type.Sub)]
    [InlineData(Accounts::Type.Virtual)]
    public void Validation_Works(Accounts::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Accounts::Type.Main)]
    [InlineData(Accounts::Type.Sub)]
    [InlineData(Accounts::Type.Virtual)]
    public void SerializationRoundtrip_Works(Accounts::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Accounts::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Accounts::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
