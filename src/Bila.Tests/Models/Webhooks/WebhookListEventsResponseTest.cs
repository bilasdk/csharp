using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Models.Webhooks;

namespace Bila.Tests.Models.Webhooks;

public class WebhookListEventsResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookListEventsResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        List<string> expectedData =
        [
            "order.created",
            "order.paid",
            "order.cancelled",
            "stock.low",
            "payment.created",
            "payment.completed",
            "payment.failed",
            "collection.pending",
            "collection.completed",
            "collection.failed",
            "withdrawal.created",
            "withdrawal.completed",
            "withdrawal.failed",
            "transaction.updated",
            "transfer.pending",
            "transfer.completed",
            "transfer.failed",
            "settlement.completed",
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
        var model = new WebhookListEventsResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookListEventsResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookListEventsResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookListEventsResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        List<string> expectedData =
        [
            "order.created",
            "order.paid",
            "order.cancelled",
            "stock.low",
            "payment.created",
            "payment.completed",
            "payment.failed",
            "collection.pending",
            "collection.completed",
            "collection.failed",
            "withdrawal.created",
            "withdrawal.completed",
            "withdrawal.failed",
            "transaction.updated",
            "transfer.pending",
            "transfer.completed",
            "transfer.failed",
            "settlement.completed",
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
        var model = new WebhookListEventsResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WebhookListEventsResponse
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
        var model = new WebhookListEventsResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WebhookListEventsResponse
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
        var model = new WebhookListEventsResponse
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
        var model = new WebhookListEventsResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        WebhookListEventsResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class WebhookListEventsResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new WebhookListEventsResponseIntersectionMember1
        {
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        List<string> expectedData =
        [
            "order.created",
            "order.paid",
            "order.cancelled",
            "stock.low",
            "payment.created",
            "payment.completed",
            "payment.failed",
            "collection.pending",
            "collection.completed",
            "collection.failed",
            "withdrawal.created",
            "withdrawal.completed",
            "withdrawal.failed",
            "transaction.updated",
            "transfer.pending",
            "transfer.completed",
            "transfer.failed",
            "settlement.completed",
        ];

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
        var model = new WebhookListEventsResponseIntersectionMember1
        {
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookListEventsResponseIntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new WebhookListEventsResponseIntersectionMember1
        {
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<WebhookListEventsResponseIntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<string> expectedData =
        [
            "order.created",
            "order.paid",
            "order.cancelled",
            "stock.low",
            "payment.created",
            "payment.completed",
            "payment.failed",
            "collection.pending",
            "collection.completed",
            "collection.failed",
            "withdrawal.created",
            "withdrawal.completed",
            "withdrawal.failed",
            "transaction.updated",
            "transfer.pending",
            "transfer.completed",
            "transfer.failed",
            "settlement.completed",
        ];

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
        var model = new WebhookListEventsResponseIntersectionMember1
        {
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new WebhookListEventsResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new WebhookListEventsResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new WebhookListEventsResponseIntersectionMember1
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
        var model = new WebhookListEventsResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new WebhookListEventsResponseIntersectionMember1
        {
            Data =
            [
                "order.created",
                "order.paid",
                "order.cancelled",
                "stock.low",
                "payment.created",
                "payment.completed",
                "payment.failed",
                "collection.pending",
                "collection.completed",
                "collection.failed",
                "withdrawal.created",
                "withdrawal.completed",
                "withdrawal.failed",
                "transaction.updated",
                "transfer.pending",
                "transfer.completed",
                "transfer.failed",
                "settlement.completed",
            ],
        };

        WebhookListEventsResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}
