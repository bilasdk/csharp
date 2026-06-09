using System;
using System.Text.Json;
using Usebila.Core;
using Usebila.Exceptions;
using Transfers = Usebila.Models.Transfers;

namespace Usebila.Tests.Models.Transfers;

public class TransferListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new Transfers::TransferListParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            StartDate = "2024-01-01T00:00:00Z",
            Status = Transfers::Status.Pending,
            Type = Transfers::Type.BankAccount,
        };

        string expectedAccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedEndDate = "2024-12-31T23:59:59Z";
        double expectedPage = 1;
        double expectedPerPage = 50;
        string expectedStartDate = "2024-01-01T00:00:00Z";
        ApiEnum<string, Transfers::Status> expectedStatus = Transfers::Status.Pending;
        ApiEnum<string, Transfers::Type> expectedType = Transfers::Type.BankAccount;

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedEndDate, parameters.EndDate);
        Assert.Equal(expectedPage, parameters.Page);
        Assert.Equal(expectedPerPage, parameters.PerPage);
        Assert.Equal(expectedStartDate, parameters.StartDate);
        Assert.Equal(expectedStatus, parameters.Status);
        Assert.Equal(expectedType, parameters.Type);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new Transfers::TransferListParams { };

        Assert.Null(parameters.AccountID);
        Assert.False(parameters.RawQueryData.ContainsKey("accountId"));
        Assert.Null(parameters.EndDate);
        Assert.False(parameters.RawQueryData.ContainsKey("endDate"));
        Assert.Null(parameters.Page);
        Assert.False(parameters.RawQueryData.ContainsKey("page"));
        Assert.Null(parameters.PerPage);
        Assert.False(parameters.RawQueryData.ContainsKey("perPage"));
        Assert.Null(parameters.StartDate);
        Assert.False(parameters.RawQueryData.ContainsKey("startDate"));
        Assert.Null(parameters.Status);
        Assert.False(parameters.RawQueryData.ContainsKey("status"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new Transfers::TransferListParams
        {
            // Null should be interpreted as omitted for these properties
            AccountID = null,
            EndDate = null,
            Page = null,
            PerPage = null,
            StartDate = null,
            Status = null,
            Type = null,
        };

        Assert.Null(parameters.AccountID);
        Assert.False(parameters.RawQueryData.ContainsKey("accountId"));
        Assert.Null(parameters.EndDate);
        Assert.False(parameters.RawQueryData.ContainsKey("endDate"));
        Assert.Null(parameters.Page);
        Assert.False(parameters.RawQueryData.ContainsKey("page"));
        Assert.Null(parameters.PerPage);
        Assert.False(parameters.RawQueryData.ContainsKey("perPage"));
        Assert.Null(parameters.StartDate);
        Assert.False(parameters.RawQueryData.ContainsKey("startDate"));
        Assert.Null(parameters.Status);
        Assert.False(parameters.RawQueryData.ContainsKey("status"));
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void Url_Works()
    {
        Transfers::TransferListParams parameters = new()
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            StartDate = "2024-01-01T00:00:00Z",
            Status = Transfers::Status.Pending,
            Type = Transfers::Type.BankAccount,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri(
                    "https://api.usebila.com/api/v1/bila/transfers?accountId=68f11209-451f-4a15-bfcd-d916eb8b09f4&endDate=2024-12-31T23%3a59%3a59Z&page=1&perPage=50&startDate=2024-01-01T00%3a00%3a00Z&status=pending&type=bank-account"
                ),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new Transfers::TransferListParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            StartDate = "2024-01-01T00:00:00Z",
            Status = Transfers::Status.Pending,
            Type = Transfers::Type.BankAccount,
        };

        Transfers::TransferListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Transfers::Status.Pending)]
    [InlineData(Transfers::Status.Successful)]
    [InlineData(Transfers::Status.Failed)]
    public void Validation_Works(Transfers::Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Transfers::Status> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Transfers::Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Transfers::Status.Pending)]
    [InlineData(Transfers::Status.Successful)]
    [InlineData(Transfers::Status.Failed)]
    public void SerializationRoundtrip_Works(Transfers::Status rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Transfers::Status> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Transfers::Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Transfers::Status>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Transfers::Status>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Transfers::Type.BankAccount)]
    [InlineData(Transfers::Type.MobileMoney)]
    public void Validation_Works(Transfers::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Transfers::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Transfers::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Transfers::Type.BankAccount)]
    [InlineData(Transfers::Type.MobileMoney)]
    public void SerializationRoundtrip_Works(Transfers::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Transfers::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Transfers::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Transfers::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Transfers::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
