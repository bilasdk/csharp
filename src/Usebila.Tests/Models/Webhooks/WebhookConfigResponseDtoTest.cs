using System;
using System.Collections.Generic;
using System.Text.Json;
using Usebila.Core;
using Usebila.Models.Webhooks;

namespace Usebila.Tests.Models.Webhooks;

public class WebhookConfigResponseDtoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookConfigResponseDto
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
        var model = new WebhookConfigResponseDto
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
        var deserialized = JsonSerializer.Deserialize<WebhookConfigResponseDto>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookConfigResponseDto
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
        var deserialized = JsonSerializer.Deserialize<WebhookConfigResponseDto>(
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
        var model = new WebhookConfigResponseDto
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
        var model = new WebhookConfigResponseDto
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

        WebhookConfigResponseDto copied = new(model);

        Assert.Equal(model, copied);
    }
}
