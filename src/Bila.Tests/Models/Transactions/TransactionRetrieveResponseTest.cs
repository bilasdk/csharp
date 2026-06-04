using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Transactions;

namespace Bila.Tests.Models.Transactions;

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
                Type = DataType.Credit,
                Description = "Mobile money collection",
                Reference = "order-12345",
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        Data expectedData = new()
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
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
                Type = DataType.Credit,
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
                Type = DataType.Credit,
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
        Data expectedData = new()
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
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
                Type = DataType.Credit,
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
                Type = DataType.Credit,
                Description = "Mobile money collection",
                Reference = "order-12345",
            },
        };

        TransactionRetrieveResponse copied = new(model);

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
                ID = "txn-001",
                AccountID = "acc-001",
                Amount = 1000,
                BalanceAfter = 6000,
                BalanceBefore = 5000,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Status = Status.Successful,
                Type = DataType.Credit,
                Description = "Mobile money collection",
                Reference = "order-12345",
            },
        };

        Data expectedData = new()
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
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
                ID = "txn-001",
                AccountID = "acc-001",
                Amount = 1000,
                BalanceAfter = 6000,
                BalanceBefore = 5000,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Status = Status.Successful,
                Type = DataType.Credit,
                Description = "Mobile money collection",
                Reference = "order-12345",
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
                ID = "txn-001",
                AccountID = "acc-001",
                Amount = 1000,
                BalanceAfter = 6000,
                BalanceBefore = 5000,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Status = Status.Successful,
                Type = DataType.Credit,
                Description = "Mobile money collection",
                Reference = "order-12345",
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
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
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
                ID = "txn-001",
                AccountID = "acc-001",
                Amount = 1000,
                BalanceAfter = 6000,
                BalanceBefore = 5000,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Status = Status.Successful,
                Type = DataType.Credit,
                Description = "Mobile money collection",
                Reference = "order-12345",
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
                ID = "txn-001",
                AccountID = "acc-001",
                Amount = 1000,
                BalanceAfter = 6000,
                BalanceBefore = 5000,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Status = Status.Successful,
                Type = DataType.Credit,
                Description = "Mobile money collection",
                Reference = "order-12345",
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
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        string expectedID = "txn-001";
        string expectedAccountID = "acc-001";
        double expectedAmount = 1000;
        double expectedBalanceAfter = 6000;
        double expectedBalanceBefore = 5000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        ApiEnum<string, Status> expectedStatus = Status.Successful;
        ApiEnum<string, DataType> expectedType = DataType.Credit;
        string expectedDescription = "Mobile money collection";
        string expectedReference = "order-12345";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccountID, model.AccountID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedBalanceAfter, model.BalanceAfter);
        Assert.Equal(expectedBalanceBefore, model.BalanceBefore);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedReference, model.Reference);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
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
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "txn-001";
        string expectedAccountID = "acc-001";
        double expectedAmount = 1000;
        double expectedBalanceAfter = 6000;
        double expectedBalanceBefore = 5000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        ApiEnum<string, Status> expectedStatus = Status.Successful;
        ApiEnum<string, DataType> expectedType = DataType.Credit;
        string expectedDescription = "Mobile money collection";
        string expectedReference = "order-12345";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccountID, deserialized.AccountID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedBalanceAfter, deserialized.BalanceAfter);
        Assert.Equal(expectedBalanceBefore, deserialized.BalanceBefore);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedReference, deserialized.Reference);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Reference);
        Assert.False(model.RawData.ContainsKey("reference"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Data
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,

            // Null should be interpreted as omitted for these properties
            Description = null,
            Reference = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Reference);
        Assert.False(model.RawData.ContainsKey("reference"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,

            // Null should be interpreted as omitted for these properties
            Description = null,
            Reference = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Data
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = Status.Successful,
            Type = DataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Pending)]
    [InlineData(Status.Successful)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Cancelled)]
    public void Validation_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Status.Pending)]
    [InlineData(Status.Successful)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Cancelled)]
    public void SerializationRoundtrip_Works(Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Status> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class DataTypeTest : TestBase
{
    [Theory]
    [InlineData(DataType.Credit)]
    [InlineData(DataType.Debit)]
    public void Validation_Works(DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(DataType.Credit)]
    [InlineData(DataType.Debit)]
    public void SerializationRoundtrip_Works(DataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, DataType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, DataType>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
