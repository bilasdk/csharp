using System.Text.Json;
using Bila.Core;
using Bila.Models.Accounts;

namespace Bila.Tests.Models.Accounts;

public class BilaResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new BilaResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;

        Assert.Equal(expectedMessage, model.Message);
        Assert.Equal(expectedStatus, model.Status);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new BilaResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BilaResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new BilaResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BilaResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;

        Assert.Equal(expectedMessage, deserialized.Message);
        Assert.Equal(expectedStatus, deserialized.Status);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new BilaResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new BilaResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        BilaResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}
