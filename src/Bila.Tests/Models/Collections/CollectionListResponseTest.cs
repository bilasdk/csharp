using System;
using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Collections;

namespace Bila.Tests.Models.Collections;

public class CollectionListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CollectionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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
        CollectionListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "col-001",
                    Amount = 100,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Customer = new()
                    {
                        Name = "JOHN DOE",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "order-12345",
                    Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                    Narration = "Payment for Order #12345",
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
        var model = new CollectionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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
        var deserialized = JsonSerializer.Deserialize<CollectionListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CollectionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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
        var deserialized = JsonSerializer.Deserialize<CollectionListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        CollectionListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "col-001",
                    Amount = 100,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Customer = new()
                    {
                        Name = "JOHN DOE",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "order-12345",
                    Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                    Narration = "Payment for Order #12345",
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
        var model = new CollectionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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
        var model = new CollectionListResponse
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
        var model = new CollectionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CollectionListResponse
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
        var model = new CollectionListResponse
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
        var model = new CollectionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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

        CollectionListResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CollectionListResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CollectionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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

        CollectionListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "col-001",
                    Amount = 100,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Customer = new()
                    {
                        Name = "JOHN DOE",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "order-12345",
                    Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                    Narration = "Payment for Order #12345",
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

        Assert.Equal(expectedData, model.Data);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CollectionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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
        var deserialized = JsonSerializer.Deserialize<CollectionListResponseIntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CollectionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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
        var deserialized = JsonSerializer.Deserialize<CollectionListResponseIntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        CollectionListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "col-001",
                    Amount = 100,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Customer = new()
                    {
                        Name = "JOHN DOE",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "order-12345",
                    Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                    Narration = "Payment for Order #12345",
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

        Assert.Equal(expectedData, deserialized.Data);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CollectionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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
        var model = new CollectionListResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CollectionListResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CollectionListResponseIntersectionMember1
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
        var model = new CollectionListResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new CollectionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "col-001",
                        Amount = 100,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Customer = new()
                        {
                            Name = "JOHN DOE",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "order-12345",
                        Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        FeeBearer =
                            CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                        Narration = "Payment for Order #12345",
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

        CollectionListResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CollectionListResponseIntersectionMember1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CollectionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "col-001",
                    Amount = 100,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Customer = new()
                    {
                        Name = "JOHN DOE",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "order-12345",
                    Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                    Narration = "Payment for Order #12345",
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

        List<CollectionListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "col-001",
                Amount = 100,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Customer = new()
                {
                    Name = "JOHN DOE",
                    Operator = "airtel",
                    Phone = "0977123456",
                },
                Reference = "order-12345",
                Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                Narration = "Payment for Order #12345",
            },
        ];
        Meta expectedMeta = new()
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        Assert.Equal(expectedData.Count, model.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], model.Data[i]);
        }
        Assert.Equal(expectedMeta, model.Meta);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CollectionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "col-001",
                    Amount = 100,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Customer = new()
                    {
                        Name = "JOHN DOE",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "order-12345",
                    Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                    Narration = "Payment for Order #12345",
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
        var deserialized =
            JsonSerializer.Deserialize<CollectionListResponseIntersectionMember1Data>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CollectionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "col-001",
                    Amount = 100,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Customer = new()
                    {
                        Name = "JOHN DOE",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "order-12345",
                    Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                    Narration = "Payment for Order #12345",
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
        var deserialized =
            JsonSerializer.Deserialize<CollectionListResponseIntersectionMember1Data>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        List<CollectionListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "col-001",
                Amount = 100,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Customer = new()
                {
                    Name = "JOHN DOE",
                    Operator = "airtel",
                    Phone = "0977123456",
                },
                Reference = "order-12345",
                Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                Narration = "Payment for Order #12345",
            },
        ];
        Meta expectedMeta = new()
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        Assert.Equal(expectedData.Count, deserialized.Data.Count);
        for (int i = 0; i < expectedData.Count; i++)
        {
            Assert.Equal(expectedData[i], deserialized.Data[i]);
        }
        Assert.Equal(expectedMeta, deserialized.Meta);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CollectionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "col-001",
                    Amount = 100,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Customer = new()
                    {
                        Name = "JOHN DOE",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "order-12345",
                    Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                    Narration = "Payment for Order #12345",
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
        var model = new CollectionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "col-001",
                    Amount = 100,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Customer = new()
                    {
                        Name = "JOHN DOE",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "order-12345",
                    Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
                    Narration = "Payment for Order #12345",
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

        CollectionListResponseIntersectionMember1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CollectionListResponseIntersectionMember1DataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataData
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        string expectedID = "col-001";
        double expectedAmount = 100;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        CollectionListResponseIntersectionMember1DataDataCustomer expectedCustomer = new()
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "order-12345";
        ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus> expectedStatus =
            CollectionListResponseIntersectionMember1DataDataStatus.Successful;
        DateTimeOffset expectedCompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z");
        ApiEnum<
            string,
            CollectionListResponseIntersectionMember1DataDataFeeBearer
        > expectedFeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant;
        string expectedNarration = "Payment for Order #12345";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedCustomer, model.Customer);
        Assert.Equal(expectedReference, model.Reference);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedCompletedAt, model.CompletedAt);
        Assert.Equal(expectedFeeBearer, model.FeeBearer);
        Assert.Equal(expectedNarration, model.Narration);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataData
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CollectionListResponseIntersectionMember1DataData>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataData
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CollectionListResponseIntersectionMember1DataData>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedID = "col-001";
        double expectedAmount = 100;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        CollectionListResponseIntersectionMember1DataDataCustomer expectedCustomer = new()
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "order-12345";
        ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus> expectedStatus =
            CollectionListResponseIntersectionMember1DataDataStatus.Successful;
        DateTimeOffset expectedCompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z");
        ApiEnum<
            string,
            CollectionListResponseIntersectionMember1DataDataFeeBearer
        > expectedFeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant;
        string expectedNarration = "Payment for Order #12345";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedCustomer, deserialized.Customer);
        Assert.Equal(expectedReference, deserialized.Reference);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedCompletedAt, deserialized.CompletedAt);
        Assert.Equal(expectedFeeBearer, deserialized.FeeBearer);
        Assert.Equal(expectedNarration, deserialized.Narration);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataData
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataData
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
        };

        Assert.Null(model.CompletedAt);
        Assert.False(model.RawData.ContainsKey("completedAt"));
        Assert.Null(model.FeeBearer);
        Assert.False(model.RawData.ContainsKey("feeBearer"));
        Assert.Null(model.Narration);
        Assert.False(model.RawData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataData
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataData
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,

            // Null should be interpreted as omitted for these properties
            CompletedAt = null,
            FeeBearer = null,
            Narration = null,
        };

        Assert.Null(model.CompletedAt);
        Assert.False(model.RawData.ContainsKey("completedAt"));
        Assert.Null(model.FeeBearer);
        Assert.False(model.RawData.ContainsKey("feeBearer"));
        Assert.Null(model.Narration);
        Assert.False(model.RawData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataData
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,

            // Null should be interpreted as omitted for these properties
            CompletedAt = null,
            FeeBearer = null,
            Narration = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataData
        {
            ID = "col-001",
            Amount = 100,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Customer = new()
            {
                Name = "JOHN DOE",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "order-12345",
            Status = CollectionListResponseIntersectionMember1DataDataStatus.Successful,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            FeeBearer = CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
            Narration = "Payment for Order #12345",
        };

        CollectionListResponseIntersectionMember1DataData copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CollectionListResponseIntersectionMember1DataDataCustomerTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataDataCustomer
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
        var model = new CollectionListResponseIntersectionMember1DataDataCustomer
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CollectionListResponseIntersectionMember1DataDataCustomer>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new CollectionListResponseIntersectionMember1DataDataCustomer
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<CollectionListResponseIntersectionMember1DataDataCustomer>(
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
        var model = new CollectionListResponseIntersectionMember1DataDataCustomer
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
        var model = new CollectionListResponseIntersectionMember1DataDataCustomer
        {
            Name = "JOHN DOE",
            Operator = "airtel",
            Phone = "0977123456",
        };

        CollectionListResponseIntersectionMember1DataDataCustomer copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class CollectionListResponseIntersectionMember1DataDataStatusTest : TestBase
{
    [Theory]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.Pending)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.Successful)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.Failed)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.OtpRequired)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.PayOffline)]
    public void Validation_Works(CollectionListResponseIntersectionMember1DataDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.Pending)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.Successful)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.Failed)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.OtpRequired)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataStatus.PayOffline)]
    public void SerializationRoundtrip_Works(
        CollectionListResponseIntersectionMember1DataDataStatus rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class CollectionListResponseIntersectionMember1DataDataFeeBearerTest : TestBase
{
    [Theory]
    [InlineData(CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataFeeBearer.Customer)]
    public void Validation_Works(
        CollectionListResponseIntersectionMember1DataDataFeeBearer rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CollectionListResponseIntersectionMember1DataDataFeeBearer> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CollectionListResponseIntersectionMember1DataDataFeeBearer>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant)]
    [InlineData(CollectionListResponseIntersectionMember1DataDataFeeBearer.Customer)]
    public void SerializationRoundtrip_Works(
        CollectionListResponseIntersectionMember1DataDataFeeBearer rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, CollectionListResponseIntersectionMember1DataDataFeeBearer> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CollectionListResponseIntersectionMember1DataDataFeeBearer>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, CollectionListResponseIntersectionMember1DataDataFeeBearer>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, CollectionListResponseIntersectionMember1DataDataFeeBearer>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class MetaTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Meta
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        double expectedCurrentPage = 1;
        double expectedPageCount = 3;
        double expectedPerPage = 50;
        double expectedTotal = 150;

        Assert.Equal(expectedCurrentPage, model.CurrentPage);
        Assert.Equal(expectedPageCount, model.PageCount);
        Assert.Equal(expectedPerPage, model.PerPage);
        Assert.Equal(expectedTotal, model.Total);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Meta
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Meta>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Meta
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<Meta>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        double expectedCurrentPage = 1;
        double expectedPageCount = 3;
        double expectedPerPage = 50;
        double expectedTotal = 150;

        Assert.Equal(expectedCurrentPage, deserialized.CurrentPage);
        Assert.Equal(expectedPageCount, deserialized.PageCount);
        Assert.Equal(expectedPerPage, deserialized.PerPage);
        Assert.Equal(expectedTotal, deserialized.Total);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Meta
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new Meta
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        Meta copied = new(model);

        Assert.Equal(model, copied);
    }
}
