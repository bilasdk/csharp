using System.Text.Json;
using Bila.Core;
using Bila.Models.Resolve;

namespace Bila.Tests.Models.Resolve;

public class ResolveMobileMoneyResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ResolveMobileMoneyResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AccountName = "John Doe",
                Country = "zm",
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "First National Bank",
                Operator = "airtel",
                Phone = "0977433571",
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        ResolvedAccountResponseDto expectedData = new()
        {
            AccountName = "John Doe",
            Country = "zm",
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "First National Bank",
            Operator = "airtel",
            Phone = "0977433571",
        };

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ResolveMobileMoneyResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AccountName = "John Doe",
                Country = "zm",
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "First National Bank",
                Operator = "airtel",
                Phone = "0977433571",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ResolveMobileMoneyResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ResolveMobileMoneyResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AccountName = "John Doe",
                Country = "zm",
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "First National Bank",
                Operator = "airtel",
                Phone = "0977433571",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ResolveMobileMoneyResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        ResolvedAccountResponseDto expectedData = new()
        {
            AccountName = "John Doe",
            Country = "zm",
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "First National Bank",
            Operator = "airtel",
            Phone = "0977433571",
        };

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ResolveMobileMoneyResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AccountName = "John Doe",
                Country = "zm",
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "First National Bank",
                Operator = "airtel",
                Phone = "0977433571",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ResolveMobileMoneyResponse
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
        var model = new ResolveMobileMoneyResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ResolveMobileMoneyResponse
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
        var model = new ResolveMobileMoneyResponse
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
        var model = new ResolveMobileMoneyResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AccountName = "John Doe",
                Country = "zm",
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "First National Bank",
                Operator = "airtel",
                Phone = "0977433571",
            },
        };

        ResolveMobileMoneyResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
