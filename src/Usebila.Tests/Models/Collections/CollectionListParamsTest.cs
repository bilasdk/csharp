using System;
using System.Text.Json;
using Usebila.Core;
using Usebila.Exceptions;
using Usebila.Models.Collections;

namespace Usebila.Tests.Models.Collections;

public class CollectionListParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new CollectionListParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            StartDate = "2024-01-01T00:00:00Z",
            Status = Status.Pending,
        };

        string expectedAccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedEndDate = "2024-12-31T23:59:59Z";
        double expectedPage = 1;
        double expectedPerPage = 50;
        string expectedStartDate = "2024-01-01T00:00:00Z";
        ApiEnum<string, Status> expectedStatus = Status.Pending;

        Assert.Equal(expectedAccountID, parameters.AccountID);
        Assert.Equal(expectedEndDate, parameters.EndDate);
        Assert.Equal(expectedPage, parameters.Page);
        Assert.Equal(expectedPerPage, parameters.PerPage);
        Assert.Equal(expectedStartDate, parameters.StartDate);
        Assert.Equal(expectedStatus, parameters.Status);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new CollectionListParams { };

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
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new CollectionListParams
        {
            // Null should be interpreted as omitted for these properties
            AccountID = null,
            EndDate = null,
            Page = null,
            PerPage = null,
            StartDate = null,
            Status = null,
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
    }

    [Fact]
    public void Url_Works()
    {
        CollectionListParams parameters = new()
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            StartDate = "2024-01-01T00:00:00Z",
            Status = Status.Pending,
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri(
                    "https://api.usebila.com/api/v1/bila/collections?accountId=68f11209-451f-4a15-bfcd-d916eb8b09f4&endDate=2024-12-31T23%3a59%3a59Z&page=1&perPage=50&startDate=2024-01-01T00%3a00%3a00Z&status=pending"
                ),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new CollectionListParams
        {
            AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            StartDate = "2024-01-01T00:00:00Z",
            Status = Status.Pending,
        };

        CollectionListParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Pending)]
    [InlineData(Status.Successful)]
    [InlineData(Status.Failed)]
    [InlineData(Status.OtpRequired)]
    [InlineData(Status.PayOffline)]
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
    [InlineData(Status.OtpRequired)]
    [InlineData(Status.PayOffline)]
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
