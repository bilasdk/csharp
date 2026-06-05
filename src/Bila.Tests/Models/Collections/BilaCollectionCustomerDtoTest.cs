using System.Text.Json;
using Bila.Core;
using Bila.Models.Collections;

namespace Bila.Tests.Models.Collections;

public class BilaCollectionCustomerDtoTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new BilaCollectionCustomerDto
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string expectedName = "JOHN DOE";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedOperator, model.Operator);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new BilaCollectionCustomerDto
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BilaCollectionCustomerDto>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new BilaCollectionCustomerDto
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BilaCollectionCustomerDto>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedName = "JOHN DOE";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedOperator, deserialized.Operator);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new BilaCollectionCustomerDto
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new BilaCollectionCustomerDto
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        BilaCollectionCustomerDto copied = new(model);

        Assert.Equal(model, copied);
    }
}
