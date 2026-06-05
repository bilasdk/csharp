using System.Text.Json;
using Usebila.Core;
using Usebila.Models.Webhooks;

namespace Usebila.Tests.Models.Webhooks;

public class WebhookRotateSecretResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookRotateSecretResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new("7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3"),
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        WebhookRotateSecretResponseData expectedData = new(
            "7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3"
        );

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WebhookRotateSecretResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new("7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3"),
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookRotateSecretResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookRotateSecretResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new("7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3"),
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookRotateSecretResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        WebhookRotateSecretResponseData expectedData = new(
            "7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3"
        );

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WebhookRotateSecretResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new("7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3"),
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WebhookRotateSecretResponse
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
        var model = new WebhookRotateSecretResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WebhookRotateSecretResponse
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
        var model = new WebhookRotateSecretResponse
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
        var model = new WebhookRotateSecretResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new("7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3"),
        };

        WebhookRotateSecretResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class WebhookRotateSecretResponseDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookRotateSecretResponseData
        {
            Secret = "7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3",
        };

        string expectedSecret = "7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3";

        Assert.Equal(expectedSecret, model.Secret);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new WebhookRotateSecretResponseData
        {
            Secret = "7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookRotateSecretResponseData>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookRotateSecretResponseData
        {
            Secret = "7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookRotateSecretResponseData>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedSecret = "7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3";

        Assert.Equal(expectedSecret, deserialized.Secret);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new WebhookRotateSecretResponseData
        {
            Secret = "7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new WebhookRotateSecretResponseData
        {
            Secret = "7f3a9c2e8b1d4f6a0e5c8b2d9f1a4e6c0b3d8f2a1e5c9b6d0f4a8e2c7b1d5f9a3",
        };

        WebhookRotateSecretResponseData copied = new(model);

        Assert.Equal(model, copied);
    }
}
