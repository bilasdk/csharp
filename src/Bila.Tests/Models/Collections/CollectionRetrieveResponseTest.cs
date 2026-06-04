using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Collections;

namespace Bila.Tests.Models.Collections;

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
                Status = DataStatus.Successful,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                FeeBearer = FeeBearer.Merchant,
                Narration = "Payment for Order #12345",
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        Data expectedData = new()
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
            Status = DataStatus.Successful,
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
                Status = DataStatus.Successful,
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
                Status = DataStatus.Successful,
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
        Data expectedData = new()
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
            Status = DataStatus.Successful,
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
                Status = DataStatus.Successful,
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
                Status = DataStatus.Successful,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                FeeBearer = FeeBearer.Merchant,
                Narration = "Payment for Order #12345",
            },
        };

        CollectionRetrieveResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class IntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new IntersectionMember1
        {
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
                Status = DataStatus.Successful,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                FeeBearer = FeeBearer.Merchant,
                Narration = "Payment for Order #12345",
            },
        };

        Data expectedData = new()
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
            Status = DataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new IntersectionMember1
        {
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
                Status = DataStatus.Successful,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                FeeBearer = FeeBearer.Merchant,
                Narration = "Payment for Order #12345",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<IntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new IntersectionMember1
        {
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
                Status = DataStatus.Successful,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                FeeBearer = FeeBearer.Merchant,
                Narration = "Payment for Order #12345",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<IntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        Data expectedData = new()
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
            Status = DataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new IntersectionMember1
        {
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
                Status = DataStatus.Successful,
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
        var model = new IntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new IntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new IntersectionMember1
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
        var model = new IntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new IntersectionMember1
        {
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
                Status = DataStatus.Successful,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                FeeBearer = FeeBearer.Merchant,
                Narration = "Payment for Order #12345",
            },
        };

        IntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Data
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
            Status = DataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        string expectedID = "col-001";
        double expectedAmount = 100;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        Customer expectedCustomer = new()
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "order-12345";
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Successful;
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
        var model = new Data
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
            Status = DataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
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
            Status = DataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "col-001";
        double expectedAmount = 100;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        Customer expectedCustomer = new()
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "order-12345";
        ApiEnum<string, DataStatus> expectedStatus = DataStatus.Successful;
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
        var model = new Data
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
            Status = DataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
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
            Status = DataStatus.Successful,
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
        var model = new Data
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
            Status = DataStatus.Successful,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Data
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
            Status = DataStatus.Successful,

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
        var model = new Data
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
            Status = DataStatus.Successful,

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
        var model = new Data
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
            Status = DataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = FeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CustomerTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Customer
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string expectedName = "JOHN DOE";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedOperator, model.Operator);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Customer
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customer>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Customer
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Customer>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedName = "JOHN DOE";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedOperator, deserialized.Operator);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Customer
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Customer
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        Customer copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataStatusTest : TestBase
{
    [Theory]
    [InlineData(DataStatus.Pending)]
    [InlineData(DataStatus.Successful)]
    [InlineData(DataStatus.Failed)]
    [InlineData(DataStatus.OtpRequired)]
    [InlineData(DataStatus.PayOffline)]
    public void Validation_Works(DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataStatus.Pending)]
    [InlineData(DataStatus.Successful)]
    [InlineData(DataStatus.Failed)]
    [InlineData(DataStatus.OtpRequired)]
    [InlineData(DataStatus.PayOffline)]
    public void SerializationRoundtrip_Works(DataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataStatus>>(
            json,
            ModelBase.SerializerOptions
        );

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
