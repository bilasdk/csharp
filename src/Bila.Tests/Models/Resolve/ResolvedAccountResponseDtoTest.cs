using System.Text.Json;
using Bila.Core;
using Bila.Models.Resolve;

namespace Bila.Tests.Models.Resolve;

public class ResolvedAccountResponseDtoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new ResolvedAccountResponseDto
        {
            AccountName = "John Doe",
            Country = "zm",
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "First National Bank",
            Operator = "airtel",
            Phone = "0977433571",
        };

        string expectedAccountName = "John Doe";
        string expectedCountry = "zm";
        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        string expectedBankName = "First National Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977433571";

        Assert.Equal(expectedAccountName, model.AccountName);
        Assert.Equal(expectedCountry, model.Country);
        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedBankID, model.BankID);
        Assert.Equal(expectedBankName, model.BankName);
        Assert.Equal(expectedOperator, model.Operator);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new ResolvedAccountResponseDto
        {
            AccountName = "John Doe",
            Country = "zm",
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "First National Bank",
            Operator = "airtel",
            Phone = "0977433571",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ResolvedAccountResponseDto>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new ResolvedAccountResponseDto
        {
            AccountName = "John Doe",
            Country = "zm",
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "First National Bank",
            Operator = "airtel",
            Phone = "0977433571",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ResolvedAccountResponseDto>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedAccountName = "John Doe";
        string expectedCountry = "zm";
        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        string expectedBankName = "First National Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977433571";

        Assert.Equal(expectedAccountName, deserialized.AccountName);
        Assert.Equal(expectedCountry, deserialized.Country);
        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedBankID, deserialized.BankID);
        Assert.Equal(expectedBankName, deserialized.BankName);
        Assert.Equal(expectedOperator, deserialized.Operator);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new ResolvedAccountResponseDto
        {
            AccountName = "John Doe",
            Country = "zm",
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "First National Bank",
            Operator = "airtel",
            Phone = "0977433571",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new ResolvedAccountResponseDto { AccountName = "John Doe", Country = "zm" };

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
        var model = new ResolvedAccountResponseDto { AccountName = "John Doe", Country = "zm" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new ResolvedAccountResponseDto
        {
            AccountName = "John Doe",
            Country = "zm",

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
        var model = new ResolvedAccountResponseDto
        {
            AccountName = "John Doe",
            Country = "zm",

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
        var model = new ResolvedAccountResponseDto
        {
            AccountName = "John Doe",
            Country = "zm",
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "First National Bank",
            Operator = "airtel",
            Phone = "0977433571",
        };

        ResolvedAccountResponseDto copied = new(model);

        Assert.Equal(model, copied);
    }
}
