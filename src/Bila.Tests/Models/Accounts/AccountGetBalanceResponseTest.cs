using System.Text.Json;
using Bila.Core;
using Bila.Models.Accounts;

namespace Bila.Tests.Models.Accounts;

public class AccountGetBalanceResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountGetBalanceResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        AccountGetBalanceResponseIntersectionMember1Data expectedData = new()
        {
            AvailableBalance = "1500.00",
            Currency = "ZMW",
            LedgerBalance = "1500.00",
        };

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountGetBalanceResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountGetBalanceResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountGetBalanceResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountGetBalanceResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        AccountGetBalanceResponseIntersectionMember1Data expectedData = new()
        {
            AvailableBalance = "1500.00",
            Currency = "ZMW",
            LedgerBalance = "1500.00",
        };

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountGetBalanceResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AccountGetBalanceResponse
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
        var model = new AccountGetBalanceResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AccountGetBalanceResponse
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
        var model = new AccountGetBalanceResponse
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
        var model = new AccountGetBalanceResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        AccountGetBalanceResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountGetBalanceResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1
        {
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        AccountGetBalanceResponseIntersectionMember1Data expectedData = new()
        {
            AvailableBalance = "1500.00",
            Currency = "ZMW",
            LedgerBalance = "1500.00",
        };

        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1
        {
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountGetBalanceResponseIntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1
        {
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<AccountGetBalanceResponseIntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        AccountGetBalanceResponseIntersectionMember1Data expectedData = new()
        {
            AvailableBalance = "1500.00",
            Currency = "ZMW",
            LedgerBalance = "1500.00",
        };

        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1
        {
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1
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
        var model = new AccountGetBalanceResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1
        {
            Data = new()
            {
                AvailableBalance = "1500.00",
                Currency = "ZMW",
                LedgerBalance = "1500.00",
            },
        };

        AccountGetBalanceResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountGetBalanceResponseIntersectionMember1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1Data
        {
            AvailableBalance = "1500.00",
            Currency = "ZMW",
            LedgerBalance = "1500.00",
        };

        string expectedAvailableBalance = "1500.00";
        string expectedCurrency = "ZMW";
        string expectedLedgerBalance = "1500.00";

        Assert.Equal(expectedAvailableBalance, model.AvailableBalance);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedLedgerBalance, model.LedgerBalance);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1Data
        {
            AvailableBalance = "1500.00",
            Currency = "ZMW",
            LedgerBalance = "1500.00",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<AccountGetBalanceResponseIntersectionMember1Data>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1Data
        {
            AvailableBalance = "1500.00",
            Currency = "ZMW",
            LedgerBalance = "1500.00",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<AccountGetBalanceResponseIntersectionMember1Data>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedAvailableBalance = "1500.00";
        string expectedCurrency = "ZMW";
        string expectedLedgerBalance = "1500.00";

        Assert.Equal(expectedAvailableBalance, deserialized.AvailableBalance);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedLedgerBalance, deserialized.LedgerBalance);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1Data
        {
            AvailableBalance = "1500.00",
            Currency = "ZMW",
            LedgerBalance = "1500.00",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountGetBalanceResponseIntersectionMember1Data
        {
            AvailableBalance = "1500.00",
            Currency = "ZMW",
            LedgerBalance = "1500.00",
        };

        AccountGetBalanceResponseIntersectionMember1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}
