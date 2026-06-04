using System;
using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Models.Webhooks;

namespace Bila.Tests.Models.Webhooks;

public class WebhookUpdateResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookUpdateResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        WebhookUpdateResponseIntersectionMember1Data expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
            Events = ["payment.completed", "collection.completed"],
            IsActive = true,
            MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
            Secret = "a1b2****c3d4",
            UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            Url = "https://example.com/webhooks/bila",
        };

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WebhookUpdateResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookUpdateResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookUpdateResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookUpdateResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        WebhookUpdateResponseIntersectionMember1Data expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
            Events = ["payment.completed", "collection.completed"],
            IsActive = true,
            MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
            Secret = "a1b2****c3d4",
            UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            Url = "https://example.com/webhooks/bila",
        };

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WebhookUpdateResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WebhookUpdateResponse
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
        var model = new WebhookUpdateResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WebhookUpdateResponse
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
        var model = new WebhookUpdateResponse
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
        var model = new WebhookUpdateResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        WebhookUpdateResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class WebhookUpdateResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        WebhookUpdateResponseIntersectionMember1Data expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
            Events = ["payment.completed", "collection.completed"],
            IsActive = true,
            MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
            Secret = "a1b2****c3d4",
            UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            Url = "https://example.com/webhooks/bila",
        };

        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookUpdateResponseIntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookUpdateResponseIntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        WebhookUpdateResponseIntersectionMember1Data expectedData = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
            Events = ["payment.completed", "collection.completed"],
            IsActive = true,
            MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
            Secret = "a1b2****c3d4",
            UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            Url = "https://example.com/webhooks/bila",
        };

        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1
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
        var model = new WebhookUpdateResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1
        {
            Data = new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
                Events = ["payment.completed", "collection.completed"],
                IsActive = true,
                MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
                Secret = "a1b2****c3d4",
                UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
                Url = "https://example.com/webhooks/bila",
            },
        };

        WebhookUpdateResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class WebhookUpdateResponseIntersectionMember1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
            Events = ["payment.completed", "collection.completed"],
            IsActive = true,
            MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
            Secret = "a1b2****c3d4",
            UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            Url = "https://example.com/webhooks/bila",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z");
        List<string> expectedEvents = ["payment.completed", "collection.completed"];
        bool expectedIsActive = true;
        string expectedMerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5";
        string expectedSecret = "a1b2****c3d4";
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z");
        string expectedUrl = "https://example.com/webhooks/bila";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedEvents.Count, model.Events.Count);
        for (int i = 0; i < expectedEvents.Count; i++)
        {
            Assert.Equal(expectedEvents[i], model.Events[i]);
        }
        Assert.Equal(expectedIsActive, model.IsActive);
        Assert.Equal(expectedMerchantID, model.MerchantID);
        Assert.Equal(expectedSecret, model.Secret);
        Assert.Equal(expectedUpdatedAt, model.UpdatedAt);
        Assert.Equal(expectedUrl, model.Url);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
            Events = ["payment.completed", "collection.completed"],
            IsActive = true,
            MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
            Secret = "a1b2****c3d4",
            UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            Url = "https://example.com/webhooks/bila",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookUpdateResponseIntersectionMember1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
            Events = ["payment.completed", "collection.completed"],
            IsActive = true,
            MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
            Secret = "a1b2****c3d4",
            UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            Url = "https://example.com/webhooks/bila",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookUpdateResponseIntersectionMember1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z");
        List<string> expectedEvents = ["payment.completed", "collection.completed"];
        bool expectedIsActive = true;
        string expectedMerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5";
        string expectedSecret = "a1b2****c3d4";
        DateTimeOffset expectedUpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z");
        string expectedUrl = "https://example.com/webhooks/bila";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedEvents.Count, deserialized.Events.Count);
        for (int i = 0; i < expectedEvents.Count; i++)
        {
            Assert.Equal(expectedEvents[i], deserialized.Events[i]);
        }
        Assert.Equal(expectedIsActive, deserialized.IsActive);
        Assert.Equal(expectedMerchantID, deserialized.MerchantID);
        Assert.Equal(expectedSecret, deserialized.Secret);
        Assert.Equal(expectedUpdatedAt, deserialized.UpdatedAt);
        Assert.Equal(expectedUrl, deserialized.Url);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
            Events = ["payment.completed", "collection.completed"],
            IsActive = true,
            MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
            Secret = "a1b2****c3d4",
            UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            Url = "https://example.com/webhooks/bila",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new WebhookUpdateResponseIntersectionMember1Data
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2026-04-01T10:00:00.000Z"),
            Events = ["payment.completed", "collection.completed"],
            IsActive = true,
            MerchantID = "68f11209-451f-4a15-bfcd-d916eb8b09f5",
            Secret = "a1b2****c3d4",
            UpdatedAt = DateTimeOffset.Parse("2026-04-15T14:30:00.000Z"),
            Url = "https://example.com/webhooks/bila",
        };

        WebhookUpdateResponseIntersectionMember1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}
