using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Models.Banks;

namespace Bila.Tests.Models.Banks;

public class BankListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new BankListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        List<Data> expectedData =
        [
            new()
            {
                ID = "bank-001",
                Code = "FNB",
                Country = "zm",
                Name = "First National Bank",
                Type = "commercial",
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
        var model = new BankListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BankListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new BankListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<BankListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        List<Data> expectedData =
        [
            new()
            {
                ID = "bank-001",
                Code = "FNB",
                Country = "zm",
                Name = "First National Bank",
                Type = "commercial",
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
        var model = new BankListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new BankListResponse
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
        var model = new BankListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new BankListResponse
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
        var model = new BankListResponse
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
        var model = new BankListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        BankListResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class IntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new IntersectionMember1
        {
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        List<Data> expectedData =
        [
            new()
            {
                ID = "bank-001",
                Code = "FNB",
                Country = "zm",
                Name = "First National Bank",
                Type = "commercial",
            },
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
        var model = new IntersectionMember1
        {
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<IntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new IntersectionMember1
        {
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<IntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Data> expectedData =
        [
            new()
            {
                ID = "bank-001",
                Code = "FNB",
                Country = "zm",
                Name = "First National Bank",
                Type = "commercial",
            },
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
        var model = new IntersectionMember1
        {
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new IntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new IntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new IntersectionMember1
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
        var model = new IntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new IntersectionMember1
        {
            Data =
            [
                new()
                {
                    ID = "bank-001",
                    Code = "FNB",
                    Country = "zm",
                    Name = "First National Bank",
                    Type = "commercial",
                },
            ],
        };

        IntersectionMember1 copied = new(model);

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
            ID = "bank-001",
            Code = "FNB",
            Country = "zm",
            Name = "First National Bank",
            Type = "commercial",
        };

        string expectedID = "bank-001";
        string expectedCode = "FNB";
        string expectedCountry = "zm";
        string expectedName = "First National Bank";
        string expectedType = "commercial";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCode, model.Code);
        Assert.Equal(expectedCountry, model.Country);
        Assert.Equal(expectedName, model.Name);
        Assert.Equal(expectedType, model.Type);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            ID = "bank-001",
            Code = "FNB",
            Country = "zm",
            Name = "First National Bank",
            Type = "commercial",
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
            ID = "bank-001",
            Code = "FNB",
            Country = "zm",
            Name = "First National Bank",
            Type = "commercial",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        string expectedID = "bank-001";
        string expectedCode = "FNB";
        string expectedCountry = "zm";
        string expectedName = "First National Bank";
        string expectedType = "commercial";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCode, deserialized.Code);
        Assert.Equal(expectedCountry, deserialized.Country);
        Assert.Equal(expectedName, deserialized.Name);
        Assert.Equal(expectedType, deserialized.Type);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            ID = "bank-001",
            Code = "FNB",
            Country = "zm",
            Name = "First National Bank",
            Type = "commercial",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "bank-001",
            Code = "FNB",
            Country = "zm",
            Name = "First National Bank",
        };

        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new Data
        {
            ID = "bank-001",
            Code = "FNB",
            Country = "zm",
            Name = "First National Bank",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Data
        {
            ID = "bank-001",
            Code = "FNB",
            Country = "zm",
            Name = "First National Bank",

            // Null should be interpreted as omitted for these properties
            Type = null,
        };

        Assert.Null(model.Type);
        Assert.False(model.RawData.ContainsKey("type"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new Data
        {
            ID = "bank-001",
            Code = "FNB",
            Country = "zm",
            Name = "First National Bank",

            // Null should be interpreted as omitted for these properties
            Type = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Data
        {
            ID = "bank-001",
            Code = "FNB",
            Country = "zm",
            Name = "First National Bank",
            Type = "commercial",
        };

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}
