using System.Text.Json;
using Usebila.Core;
using Usebila.Models.Accounts;

namespace Usebila.Tests.Models.Accounts;

public class AccountDetailsDtoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountDetailsDto
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
        var model = new AccountDetailsDto
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountDetailsDto>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountDetailsDto
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountDetailsDto>(
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
        var model = new AccountDetailsDto
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
        var model = new AccountDetailsDto { AccountName = "John Doe", Type = "bank-account" };

        Assert.Null(model.TillNumber);
        Assert.False(model.RawData.ContainsKey("tillNumber"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AccountDetailsDto { AccountName = "John Doe", Type = "bank-account" };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AccountDetailsDto
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
        var model = new AccountDetailsDto
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
        var model = new AccountDetailsDto
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        AccountDetailsDto copied = new(model);

        Assert.Equal(model, copied);
    }
}
