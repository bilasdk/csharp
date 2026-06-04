using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.TransferRecipients;

namespace Bila.Tests.Models.TransferRecipients;

public class TransferRecipientCreateBankAccountResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransferRecipientCreateBankAccountResponseIntersectionMember1Data expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
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
        var model = new TransferRecipientCreateBankAccountResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferRecipientCreateBankAccountResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<TransferRecipientCreateBankAccountResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransferRecipientCreateBankAccountResponseIntersectionMember1Data expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
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
        var model = new TransferRecipientCreateBankAccountResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
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
        var model = new TransferRecipientCreateBankAccountResponse
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
        var model = new TransferRecipientCreateBankAccountResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponse
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
        var model = new TransferRecipientCreateBankAccountResponse
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
        var model = new TransferRecipientCreateBankAccountResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
        };

        TransferRecipientCreateBankAccountResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferRecipientCreateBankAccountResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
        };

        TransferRecipientCreateBankAccountResponseIntersectionMember1Data expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferRecipientCreateBankAccountResponseIntersectionMember1>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferRecipientCreateBankAccountResponseIntersectionMember1>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        TransferRecipientCreateBankAccountResponseIntersectionMember1Data expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
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
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1
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
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type =
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
        };

        TransferRecipientCreateBankAccountResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferRecipientCreateBankAccountResponseIntersectionMember1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedAccountName = "John Doe";
        string expectedCountry = "zm";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        ApiEnum<
            string,
            TransferRecipientCreateBankAccountResponseIntersectionMember1DataType
        > expectedType =
            TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount;
        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccountName, model.AccountName);
        Assert.Equal(expectedCountry, model.Country);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedBankID, model.BankID);
        Assert.Equal(expectedBankName, model.BankName);
        Assert.Equal(expectedOperator, model.Operator);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferRecipientCreateBankAccountResponseIntersectionMember1Data>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferRecipientCreateBankAccountResponseIntersectionMember1Data>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedAccountName = "John Doe";
        string expectedCountry = "zm";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        ApiEnum<
            string,
            TransferRecipientCreateBankAccountResponseIntersectionMember1DataType
        > expectedType =
            TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount;
        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccountName, deserialized.AccountName);
        Assert.Equal(expectedCountry, deserialized.Country);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedBankID, deserialized.BankID);
        Assert.Equal(expectedBankName, deserialized.BankName);
        Assert.Equal(expectedOperator, deserialized.Operator);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
        Assert.Null(model.BankID);
        Assert.False(model.RawData.ContainsKey("bankId"));
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
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankID = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
        Assert.Null(model.BankID);
        Assert.False(model.RawData.ContainsKey("bankId"));
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
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankID = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferRecipientCreateBankAccountResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type =
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        TransferRecipientCreateBankAccountResponseIntersectionMember1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferRecipientCreateBankAccountResponseIntersectionMember1DataTypeTest : TestBase
{
    [Theory]
    [InlineData(TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount)]
    [InlineData(TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.MobileMoney)]
    public void Validation_Works(
        TransferRecipientCreateBankAccountResponseIntersectionMember1DataType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            TransferRecipientCreateBankAccountResponseIntersectionMember1DataType
        > value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientCreateBankAccountResponseIntersectionMember1DataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount)]
    [InlineData(TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.MobileMoney)]
    public void SerializationRoundtrip_Works(
        TransferRecipientCreateBankAccountResponseIntersectionMember1DataType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<
            string,
            TransferRecipientCreateBankAccountResponseIntersectionMember1DataType
        > value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientCreateBankAccountResponseIntersectionMember1DataType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientCreateBankAccountResponseIntersectionMember1DataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientCreateBankAccountResponseIntersectionMember1DataType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}
