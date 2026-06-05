using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Collections;

namespace Bila.Tests.Models.Collections;

public class BilaCollectionResponseDtoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new BilaCollectionResponseDto
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = BilaCollectionResponseDtoStatus.Pending,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        string expectedID = "col-001";
        double expectedAmount = 100;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        BilaCollectionCustomerDto expectedCustomer = new()
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "order-12345";
        ApiEnum<string, BilaCollectionResponseDtoStatus> expectedStatus =
            BilaCollectionResponseDtoStatus.Pending;
        DateTimeOffset expectedCompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z");
        ApiEnum<string, FeeBearer> expectedFeeBearer = FeeBearer.Merchant;
        string expectedNarration = "Payment for Order #12345";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedCustomer, model.Customer);
        Assert.Equal(expectedReference, model.Reference);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedCompletedAt, model.CompletedAt);
        Assert.Equal(expectedFeeBearer, model.FeeBearer);
        Assert.Equal(expectedNarration, model.Narration);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new BilaCollectionResponseDto
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = BilaCollectionResponseDtoStatus.Pending,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BilaCollectionResponseDto>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new BilaCollectionResponseDto
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = BilaCollectionResponseDtoStatus.Pending,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BilaCollectionResponseDto>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "col-001";
        double expectedAmount = 100;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        BilaCollectionCustomerDto expectedCustomer = new()
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "order-12345";
        ApiEnum<string, BilaCollectionResponseDtoStatus> expectedStatus =
            BilaCollectionResponseDtoStatus.Pending;
        DateTimeOffset expectedCompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z");
        ApiEnum<string, FeeBearer> expectedFeeBearer = FeeBearer.Merchant;
        string expectedNarration = "Payment for Order #12345";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedCustomer, deserialized.Customer);
        Assert.Equal(expectedReference, deserialized.Reference);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedCompletedAt, deserialized.CompletedAt);
        Assert.Equal(expectedFeeBearer, deserialized.FeeBearer);
        Assert.Equal(expectedNarration, deserialized.Narration);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new BilaCollectionResponseDto
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = BilaCollectionResponseDtoStatus.Pending,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new BilaCollectionResponseDto
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = BilaCollectionResponseDtoStatus.Pending,
        };

        Assert.Null(model.CompletedAt);
        Assert.False(model.RawData.ContainsKey("completedAt"));
        Assert.Null(model.FeeBearer);
        Assert.False(model.RawData.ContainsKey("feeBearer"));
        Assert.Null(model.Narration);
        Assert.False(model.RawData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new BilaCollectionResponseDto
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = BilaCollectionResponseDtoStatus.Pending,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new BilaCollectionResponseDto
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = BilaCollectionResponseDtoStatus.Pending,

            // Null should be interpreted as omitted for these properties
            CompletedAt = null,
            FeeBearer = null,
            Narration = null,
        };

        Assert.Null(model.CompletedAt);
        Assert.False(model.RawData.ContainsKey("completedAt"));
        Assert.Null(model.FeeBearer);
        Assert.False(model.RawData.ContainsKey("feeBearer"));
        Assert.Null(model.Narration);
        Assert.False(model.RawData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new BilaCollectionResponseDto
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = BilaCollectionResponseDtoStatus.Pending,

            // Null should be interpreted as omitted for these properties
            CompletedAt = null,
            FeeBearer = null,
            Narration = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new BilaCollectionResponseDto
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = BilaCollectionResponseDtoStatus.Pending,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        BilaCollectionResponseDto copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class BilaCollectionResponseDtoStatusTest : TestBase
{
    [Theory]
    [InlineData(BilaCollectionResponseDtoStatus.Pending)]
    [InlineData(BilaCollectionResponseDtoStatus.Successful)]
    [InlineData(BilaCollectionResponseDtoStatus.Failed)]
    [InlineData(BilaCollectionResponseDtoStatus.OtpRequired)]
    [InlineData(BilaCollectionResponseDtoStatus.PayOffline)]
    public void Validation_Works(BilaCollectionResponseDtoStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BilaCollectionResponseDtoStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BilaCollectionResponseDtoStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(BilaCollectionResponseDtoStatus.Pending)]
    [InlineData(BilaCollectionResponseDtoStatus.Successful)]
    [InlineData(BilaCollectionResponseDtoStatus.Failed)]
    [InlineData(BilaCollectionResponseDtoStatus.OtpRequired)]
    [InlineData(BilaCollectionResponseDtoStatus.PayOffline)]
    public void SerializationRoundtrip_Works(BilaCollectionResponseDtoStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, BilaCollectionResponseDtoStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, BilaCollectionResponseDtoStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, BilaCollectionResponseDtoStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, BilaCollectionResponseDtoStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class FeeBearerTest : TestBase
{
    [Theory]
    [InlineData(FeeBearer.Merchant)]
    [InlineData(FeeBearer.Customer)]
    public void Validation_Works(FeeBearer rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FeeBearer> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, FeeBearer>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(FeeBearer.Merchant)]
    [InlineData(FeeBearer.Customer)]
    public void SerializationRoundtrip_Works(FeeBearer rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, FeeBearer> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, FeeBearer>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, FeeBearer>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, FeeBearer>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
