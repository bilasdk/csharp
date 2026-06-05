using System;
using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models;
using Bila.Models.Webhooks;

namespace Bila.Tests.Models.Webhooks;

public class WebhookGetDeliveriesResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookGetDeliveriesResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                        Attempts = 1,
                        CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                        DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                        EventType = "payment.completed",
                        FailedAt = null,
                        MaxAttempts = 5,
                        NextRetryAt = null,
                        Payload = new Dictionary<string, JsonElement>()
                        {
                            { "id", JsonSerializer.SerializeToElement("bar") },
                            { "transactionId", JsonSerializer.SerializeToElement("bar") },
                            { "amount", JsonSerializer.SerializeToElement("bar") },
                            { "status", JsonSerializer.SerializeToElement("bar") },
                        },
                        ResponseBody = "{\"received\":true}",
                        ResponseStatus = 200,
                        Status = Status.Delivered,
                        WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    },
                ],
                Meta = new()
                {
                    CurrentPage = 1,
                    PageCount = 3,
                    PerPage = 50,
                    Total = 150,
                },
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        Data expectedData = new()
        {
            DataValue =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                    Attempts = 1,
                    CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                    DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                    EventType = "payment.completed",
                    FailedAt = null,
                    MaxAttempts = 5,
                    NextRetryAt = null,
                    Payload = new Dictionary<string, JsonElement>()
                    {
                        { "id", JsonSerializer.SerializeToElement("bar") },
                        { "transactionId", JsonSerializer.SerializeToElement("bar") },
                        { "amount", JsonSerializer.SerializeToElement("bar") },
                        { "status", JsonSerializer.SerializeToElement("bar") },
                    },
                    ResponseBody = "{\"received\":true}",
                    ResponseStatus = 200,
                    Status = Status.Delivered,
                    WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                },
            ],
            Meta = new()
            {
                CurrentPage = 1,
                PageCount = 3,
                PerPage = 50,
                Total = 150,
            },
        };

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WebhookGetDeliveriesResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                        Attempts = 1,
                        CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                        DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                        EventType = "payment.completed",
                        FailedAt = null,
                        MaxAttempts = 5,
                        NextRetryAt = null,
                        Payload = new Dictionary<string, JsonElement>()
                        {
                            { "id", JsonSerializer.SerializeToElement("bar") },
                            { "transactionId", JsonSerializer.SerializeToElement("bar") },
                            { "amount", JsonSerializer.SerializeToElement("bar") },
                            { "status", JsonSerializer.SerializeToElement("bar") },
                        },
                        ResponseBody = "{\"received\":true}",
                        ResponseStatus = 200,
                        Status = Status.Delivered,
                        WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    },
                ],
                Meta = new()
                {
                    CurrentPage = 1,
                    PageCount = 3,
                    PerPage = 50,
                    Total = 150,
                },
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookGetDeliveriesResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookGetDeliveriesResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                        Attempts = 1,
                        CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                        DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                        EventType = "payment.completed",
                        FailedAt = null,
                        MaxAttempts = 5,
                        NextRetryAt = null,
                        Payload = new Dictionary<string, JsonElement>()
                        {
                            { "id", JsonSerializer.SerializeToElement("bar") },
                            { "transactionId", JsonSerializer.SerializeToElement("bar") },
                            { "amount", JsonSerializer.SerializeToElement("bar") },
                            { "status", JsonSerializer.SerializeToElement("bar") },
                        },
                        ResponseBody = "{\"received\":true}",
                        ResponseStatus = 200,
                        Status = Status.Delivered,
                        WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    },
                ],
                Meta = new()
                {
                    CurrentPage = 1,
                    PageCount = 3,
                    PerPage = 50,
                    Total = 150,
                },
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookGetDeliveriesResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        Data expectedData = new()
        {
            DataValue =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                    Attempts = 1,
                    CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                    DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                    EventType = "payment.completed",
                    FailedAt = null,
                    MaxAttempts = 5,
                    NextRetryAt = null,
                    Payload = new Dictionary<string, JsonElement>()
                    {
                        { "id", JsonSerializer.SerializeToElement("bar") },
                        { "transactionId", JsonSerializer.SerializeToElement("bar") },
                        { "amount", JsonSerializer.SerializeToElement("bar") },
                        { "status", JsonSerializer.SerializeToElement("bar") },
                    },
                    ResponseBody = "{\"received\":true}",
                    ResponseStatus = 200,
                    Status = Status.Delivered,
                    WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                },
            ],
            Meta = new()
            {
                CurrentPage = 1,
                PageCount = 3,
                PerPage = 50,
                Total = 150,
            },
        };

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WebhookGetDeliveriesResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                        Attempts = 1,
                        CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                        DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                        EventType = "payment.completed",
                        FailedAt = null,
                        MaxAttempts = 5,
                        NextRetryAt = null,
                        Payload = new Dictionary<string, JsonElement>()
                        {
                            { "id", JsonSerializer.SerializeToElement("bar") },
                            { "transactionId", JsonSerializer.SerializeToElement("bar") },
                            { "amount", JsonSerializer.SerializeToElement("bar") },
                            { "status", JsonSerializer.SerializeToElement("bar") },
                        },
                        ResponseBody = "{\"received\":true}",
                        ResponseStatus = 200,
                        Status = Status.Delivered,
                        WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    },
                ],
                Meta = new()
                {
                    CurrentPage = 1,
                    PageCount = 3,
                    PerPage = 50,
                    Total = 150,
                },
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WebhookGetDeliveriesResponse
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
        var model = new WebhookGetDeliveriesResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WebhookGetDeliveriesResponse
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
        var model = new WebhookGetDeliveriesResponse
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
        var model = new WebhookGetDeliveriesResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                        Attempts = 1,
                        CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                        DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                        EventType = "payment.completed",
                        FailedAt = null,
                        MaxAttempts = 5,
                        NextRetryAt = null,
                        Payload = new Dictionary<string, JsonElement>()
                        {
                            { "id", JsonSerializer.SerializeToElement("bar") },
                            { "transactionId", JsonSerializer.SerializeToElement("bar") },
                            { "amount", JsonSerializer.SerializeToElement("bar") },
                            { "status", JsonSerializer.SerializeToElement("bar") },
                        },
                        ResponseBody = "{\"received\":true}",
                        ResponseStatus = 200,
                        Status = Status.Delivered,
                        WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    },
                ],
                Meta = new()
                {
                    CurrentPage = 1,
                    PageCount = 3,
                    PerPage = 50,
                    Total = 150,
                },
            },
        };

        WebhookGetDeliveriesResponse copied = new(model);

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
            DataValue =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                    Attempts = 1,
                    CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                    DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                    EventType = "payment.completed",
                    FailedAt = null,
                    MaxAttempts = 5,
                    NextRetryAt = null,
                    Payload = new Dictionary<string, JsonElement>()
                    {
                        { "id", JsonSerializer.SerializeToElement("bar") },
                        { "transactionId", JsonSerializer.SerializeToElement("bar") },
                        { "amount", JsonSerializer.SerializeToElement("bar") },
                        { "status", JsonSerializer.SerializeToElement("bar") },
                    },
                    ResponseBody = "{\"received\":true}",
                    ResponseStatus = 200,
                    Status = Status.Delivered,
                    WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                },
            ],
            Meta = new()
            {
                CurrentPage = 1,
                PageCount = 3,
                PerPage = 50,
                Total = 150,
            },
        };

        List<DataData> expectedDataValue =
        [
            new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                Attempts = 1,
                CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                EventType = "payment.completed",
                FailedAt = null,
                MaxAttempts = 5,
                NextRetryAt = null,
                Payload = new Dictionary<string, JsonElement>()
                {
                    { "id", JsonSerializer.SerializeToElement("bar") },
                    { "transactionId", JsonSerializer.SerializeToElement("bar") },
                    { "amount", JsonSerializer.SerializeToElement("bar") },
                    { "status", JsonSerializer.SerializeToElement("bar") },
                },
                ResponseBody = "{\"received\":true}",
                ResponseStatus = 200,
                Status = Status.Delivered,
                WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            },
        ];
        PaginationMetaDto expectedMeta = new()
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        Assert.Equal(expectedDataValue.Count, model.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], model.DataValue[i]);
        }
        Assert.Equal(expectedMeta, model.Meta);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            DataValue =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                    Attempts = 1,
                    CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                    DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                    EventType = "payment.completed",
                    FailedAt = null,
                    MaxAttempts = 5,
                    NextRetryAt = null,
                    Payload = new Dictionary<string, JsonElement>()
                    {
                        { "id", JsonSerializer.SerializeToElement("bar") },
                        { "transactionId", JsonSerializer.SerializeToElement("bar") },
                        { "amount", JsonSerializer.SerializeToElement("bar") },
                        { "status", JsonSerializer.SerializeToElement("bar") },
                    },
                    ResponseBody = "{\"received\":true}",
                    ResponseStatus = 200,
                    Status = Status.Delivered,
                    WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                },
            ],
            Meta = new()
            {
                CurrentPage = 1,
                PageCount = 3,
                PerPage = 50,
                Total = 150,
            },
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
            DataValue =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                    Attempts = 1,
                    CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                    DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                    EventType = "payment.completed",
                    FailedAt = null,
                    MaxAttempts = 5,
                    NextRetryAt = null,
                    Payload = new Dictionary<string, JsonElement>()
                    {
                        { "id", JsonSerializer.SerializeToElement("bar") },
                        { "transactionId", JsonSerializer.SerializeToElement("bar") },
                        { "amount", JsonSerializer.SerializeToElement("bar") },
                        { "status", JsonSerializer.SerializeToElement("bar") },
                    },
                    ResponseBody = "{\"received\":true}",
                    ResponseStatus = 200,
                    Status = Status.Delivered,
                    WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                },
            ],
            Meta = new()
            {
                CurrentPage = 1,
                PageCount = 3,
                PerPage = 50,
                Total = 150,
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        List<DataData> expectedDataValue =
        [
            new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                Attempts = 1,
                CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                EventType = "payment.completed",
                FailedAt = null,
                MaxAttempts = 5,
                NextRetryAt = null,
                Payload = new Dictionary<string, JsonElement>()
                {
                    { "id", JsonSerializer.SerializeToElement("bar") },
                    { "transactionId", JsonSerializer.SerializeToElement("bar") },
                    { "amount", JsonSerializer.SerializeToElement("bar") },
                    { "status", JsonSerializer.SerializeToElement("bar") },
                },
                ResponseBody = "{\"received\":true}",
                ResponseStatus = 200,
                Status = Status.Delivered,
                WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            },
        ];
        PaginationMetaDto expectedMeta = new()
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        Assert.Equal(expectedDataValue.Count, deserialized.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], deserialized.DataValue[i]);
        }
        Assert.Equal(expectedMeta, deserialized.Meta);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            DataValue =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                    Attempts = 1,
                    CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                    DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                    EventType = "payment.completed",
                    FailedAt = null,
                    MaxAttempts = 5,
                    NextRetryAt = null,
                    Payload = new Dictionary<string, JsonElement>()
                    {
                        { "id", JsonSerializer.SerializeToElement("bar") },
                        { "transactionId", JsonSerializer.SerializeToElement("bar") },
                        { "amount", JsonSerializer.SerializeToElement("bar") },
                        { "status", JsonSerializer.SerializeToElement("bar") },
                    },
                    ResponseBody = "{\"received\":true}",
                    ResponseStatus = 200,
                    Status = Status.Delivered,
                    WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                },
            ],
            Meta = new()
            {
                CurrentPage = 1,
                PageCount = 3,
                PerPage = 50,
                Total = 150,
            },
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Data
        {
            DataValue =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
                    Attempts = 1,
                    CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                    DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
                    EventType = "payment.completed",
                    FailedAt = null,
                    MaxAttempts = 5,
                    NextRetryAt = null,
                    Payload = new Dictionary<string, JsonElement>()
                    {
                        { "id", JsonSerializer.SerializeToElement("bar") },
                        { "transactionId", JsonSerializer.SerializeToElement("bar") },
                        { "amount", JsonSerializer.SerializeToElement("bar") },
                        { "status", JsonSerializer.SerializeToElement("bar") },
                    },
                    ResponseBody = "{\"received\":true}",
                    ResponseStatus = 200,
                    Status = Status.Delivered,
                    WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                },
            ],
            Meta = new()
            {
                CurrentPage = 1,
                PageCount = 3,
                PerPage = 50,
                Total = 150,
            },
        };

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
            Attempts = 1,
            CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
            EventType = "payment.completed",
            FailedAt = null,
            MaxAttempts = 5,
            NextRetryAt = null,
            Payload = new Dictionary<string, JsonElement>()
            {
                { "id", JsonSerializer.SerializeToElement("bar") },
                { "transactionId", JsonSerializer.SerializeToElement("bar") },
                { "amount", JsonSerializer.SerializeToElement("bar") },
                { "status", JsonSerializer.SerializeToElement("bar") },
            },
            ResponseBody = "{\"received\":true}",
            ResponseStatus = 200,
            Status = Status.Delivered,
            WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f6";
        double expectedAttempts = 1;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z");
        DateTimeOffset expectedDeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z");
        string expectedEventType = "payment.completed";
        double expectedMaxAttempts = 5;
        Dictionary<string, JsonElement> expectedPayload = new()
        {
            { "id", JsonSerializer.SerializeToElement("bar") },
            { "transactionId", JsonSerializer.SerializeToElement("bar") },
            { "amount", JsonSerializer.SerializeToElement("bar") },
            { "status", JsonSerializer.SerializeToElement("bar") },
        };
        string expectedResponseBody = "{\"received\":true}";
        double expectedResponseStatus = 200;
        ApiEnum<string, Status> expectedStatus = Status.Delivered;
        string expectedWebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAttempts, model.Attempts);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedDeliveredAt, model.DeliveredAt);
        Assert.Equal(expectedEventType, model.EventType);
        Assert.Null(model.FailedAt);
        Assert.Equal(expectedMaxAttempts, model.MaxAttempts);
        Assert.Null(model.NextRetryAt);
        Assert.Equal(expectedPayload.Count, model.Payload.Count);
        foreach (var item in expectedPayload)
        {
            Assert.True(model.Payload.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, model.Payload[item.Key]));
        }
        Assert.Equal(expectedResponseBody, model.ResponseBody);
        Assert.Equal(expectedResponseStatus, model.ResponseStatus);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedWebhookConfigID, model.WebhookConfigID);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
            Attempts = 1,
            CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
            EventType = "payment.completed",
            FailedAt = null,
            MaxAttempts = 5,
            NextRetryAt = null,
            Payload = new Dictionary<string, JsonElement>()
            {
                { "id", JsonSerializer.SerializeToElement("bar") },
                { "transactionId", JsonSerializer.SerializeToElement("bar") },
                { "amount", JsonSerializer.SerializeToElement("bar") },
                { "status", JsonSerializer.SerializeToElement("bar") },
            },
            ResponseBody = "{\"received\":true}",
            ResponseStatus = 200,
            Status = Status.Delivered,
            WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DataData>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
            Attempts = 1,
            CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
            EventType = "payment.completed",
            FailedAt = null,
            MaxAttempts = 5,
            NextRetryAt = null,
            Payload = new Dictionary<string, JsonElement>()
            {
                { "id", JsonSerializer.SerializeToElement("bar") },
                { "transactionId", JsonSerializer.SerializeToElement("bar") },
                { "amount", JsonSerializer.SerializeToElement("bar") },
                { "status", JsonSerializer.SerializeToElement("bar") },
            },
            ResponseBody = "{\"received\":true}",
            ResponseStatus = 200,
            Status = Status.Delivered,
            WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<DataData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f6";
        double expectedAttempts = 1;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z");
        DateTimeOffset expectedDeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z");
        string expectedEventType = "payment.completed";
        double expectedMaxAttempts = 5;
        Dictionary<string, JsonElement> expectedPayload = new()
        {
            { "id", JsonSerializer.SerializeToElement("bar") },
            { "transactionId", JsonSerializer.SerializeToElement("bar") },
            { "amount", JsonSerializer.SerializeToElement("bar") },
            { "status", JsonSerializer.SerializeToElement("bar") },
        };
        string expectedResponseBody = "{\"received\":true}";
        double expectedResponseStatus = 200;
        ApiEnum<string, Status> expectedStatus = Status.Delivered;
        string expectedWebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAttempts, deserialized.Attempts);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedDeliveredAt, deserialized.DeliveredAt);
        Assert.Equal(expectedEventType, deserialized.EventType);
        Assert.Null(deserialized.FailedAt);
        Assert.Equal(expectedMaxAttempts, deserialized.MaxAttempts);
        Assert.Null(deserialized.NextRetryAt);
        Assert.Equal(expectedPayload.Count, deserialized.Payload.Count);
        foreach (var item in expectedPayload)
        {
            Assert.True(deserialized.Payload.TryGetValue(item.Key, out var value));

            Assert.True(JsonElement.DeepEquals(value, deserialized.Payload[item.Key]));
        }
        Assert.Equal(expectedResponseBody, deserialized.ResponseBody);
        Assert.Equal(expectedResponseStatus, deserialized.ResponseStatus);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedWebhookConfigID, deserialized.WebhookConfigID);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
            Attempts = 1,
            CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
            EventType = "payment.completed",
            FailedAt = null,
            MaxAttempts = 5,
            NextRetryAt = null,
            Payload = new Dictionary<string, JsonElement>()
            {
                { "id", JsonSerializer.SerializeToElement("bar") },
                { "transactionId", JsonSerializer.SerializeToElement("bar") },
                { "amount", JsonSerializer.SerializeToElement("bar") },
                { "status", JsonSerializer.SerializeToElement("bar") },
            },
            ResponseBody = "{\"received\":true}",
            ResponseStatus = 200,
            Status = Status.Delivered,
            WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f6",
            Attempts = 1,
            CreatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            DeliveredAt = DateTimeOffset.Parse("2026-04-15T14:30:05.000Z"),
            EventType = "payment.completed",
            FailedAt = null,
            MaxAttempts = 5,
            NextRetryAt = null,
            Payload = new Dictionary<string, JsonElement>()
            {
                { "id", JsonSerializer.SerializeToElement("bar") },
                { "transactionId", JsonSerializer.SerializeToElement("bar") },
                { "amount", JsonSerializer.SerializeToElement("bar") },
                { "status", JsonSerializer.SerializeToElement("bar") },
            },
            ResponseBody = "{\"received\":true}",
            ResponseStatus = 200,
            Status = Status.Delivered,
            WebhookConfigID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        DataData copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class StatusTest : TestBase
{
    [Theory]
    [InlineData(Status.Queued)]
    [InlineData(Status.Delivered)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Retrying)]
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
    [InlineData(Status.Queued)]
    [InlineData(Status.Delivered)]
    [InlineData(Status.Failed)]
    [InlineData(Status.Retrying)]
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
