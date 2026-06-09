using System;
using System.Text.Json;
using Usebila.Core;
using Usebila.Exceptions;
using Accounts = Usebila.Models.Accounts;

namespace Usebila.Tests.Models.Accounts;

public class AccountResponseDtoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Accounts::AccountResponseDto
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
        Accounts::AccountDetailsDto expectedDetails = new()
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
        var model = new Accounts::AccountResponseDto
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
        var deserialized = JsonSerializer.Deserialize<Accounts::AccountResponseDto>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Accounts::AccountResponseDto
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
        var deserialized = JsonSerializer.Deserialize<Accounts::AccountResponseDto>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        Accounts::AccountDetailsDto expectedDetails = new()
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
        var model = new Accounts::AccountResponseDto
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
        var model = new Accounts::AccountResponseDto
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
        var model = new Accounts::AccountResponseDto
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
        var model = new Accounts::AccountResponseDto
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
        var model = new Accounts::AccountResponseDto
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
        var model = new Accounts::AccountResponseDto
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

        Accounts::AccountResponseDto copied = new(model);

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
