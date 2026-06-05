using System;
using System.Text.Json;
using Usebila.Core;
using Usebila.Models.Collections;

namespace Usebila.Tests.Models.Collections;

public class CollectionRetrieveResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CollectionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        BilaCollectionResponseDto expectedData = new()
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

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CollectionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CollectionRetrieveResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CollectionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<CollectionRetrieveResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        BilaCollectionResponseDto expectedData = new()
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

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CollectionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CollectionRetrieveResponse
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
        var model = new CollectionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CollectionRetrieveResponse
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
        var model = new CollectionRetrieveResponse
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
        var model = new CollectionRetrieveResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
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
            },
        };

        CollectionRetrieveResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
