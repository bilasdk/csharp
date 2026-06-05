using System;
using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Models.Webhooks;

namespace Bila.Tests.Models.Webhooks;

public class WebhookListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
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
            ],
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        List<WebhookConfigResponseDto> expectedData =
        [
            new()
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
        ];

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.NotNull(model.Data);
        Assert.Equal(expectedData.Count, model.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], model.Data[i]);
        }
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WebhookListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
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
            ],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
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
            ],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        List<WebhookConfigResponseDto> expectedData =
        [
            new()
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
        ];

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.NotNull(deserialized.Data);
        Assert.Equal(expectedData.Count, deserialized.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], deserialized.Data[i]);
        }
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WebhookListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
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
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WebhookListResponse
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
        var model = new WebhookListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WebhookListResponse
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
        var model = new WebhookListResponse
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
        var model = new WebhookListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
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
            ],
        };

        WebhookListResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
