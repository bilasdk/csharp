using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Transactions = Bila.Models.Transactions;

namespace Bila.Tests.Models.Transactions;

public class TransactionListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new Transactions::TransactionListParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            StartDate = "2024-01-01T00:00:00Z",
            Type = Transactions::Type.Credit,
        };

        string expectedAccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedEndDate = "2024-12-31T23:59:59Z";
        double expectedPage = 1;
        double expectedPerPage = 50;
        string expectedStartDate = "2024-01-01T00:00:00Z";
        ApiEnum<string, Transactions::Type> expectedType = Transactions::Type.Credit;

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedEndDate, parameters.EndDate);
        Assert.Equal(expectedPage, parameters.Page);
        Assert.Equal(expectedPerPage, parameters.PerPage);
        Assert.Equal(expectedStartDate, parameters.StartDate);
        Assert.Equal(expectedType, parameters.Type);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new Transactions::TransactionListParams { };

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
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new Transactions::TransactionListParams
        {
            // Null should be interpreted as omitted for these properties
            AccountID = null,
            EndDate = null,
            Page = null,
            PerPage = null,
            StartDate = null,
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
        Assert.Null(parameters.Type);
        Assert.False(parameters.RawQueryData.ContainsKey("type"));
    }

    [Fact]
    public void Url_Works()
    {
        Transactions::TransactionListParams parameters = new()
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            StartDate = "2024-01-01T00:00:00Z",
            Type = Transactions::Type.Credit,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri(
                    "https://api.usebila.com/api/v1/bila/transactions?accountId=68f11209-451f-4a15-bfcd-d916eb8b09f4&endDate=2024-12-31T23%3a59%3a59Z&page=1&perPage=50&startDate=2024-01-01T00%3a00%3a00Z&type=credit"
                ),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new Transactions::TransactionListParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            StartDate = "2024-01-01T00:00:00Z",
            Type = Transactions::Type.Credit,
        };

        Transactions::TransactionListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class TypeTest : TestBase
{
    [Theory]
    [InlineData(Transactions::Type.Credit)]
    [InlineData(Transactions::Type.Debit)]
    public void Validation_Works(Transactions::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Transactions::Type> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Transactions::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Transactions::Type.Credit)]
    [InlineData(Transactions::Type.Debit)]
    public void SerializationRoundtrip_Works(Transactions::Type rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Transactions::Type> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Transactions::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Transactions::Type>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Transactions::Type>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
