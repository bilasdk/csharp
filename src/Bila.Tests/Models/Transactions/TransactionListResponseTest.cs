using System;
using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Transactions;

namespace Bila.Tests.Models.Transactions;

public class TransactionListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransactionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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
        TransactionListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    AccountID = "acc-001",
                    Amount = 1000,
                    BalanceAfter = 6000,
                    BalanceBefore = 5000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                    Description = "Mobile money collection",
                    Reference = "order-12345",
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
        var model = new TransactionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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
        var deserialized = JsonSerializer.Deserialize<TransactionListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransactionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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
        var deserialized = JsonSerializer.Deserialize<TransactionListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransactionListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    AccountID = "acc-001",
                    Amount = 1000,
                    BalanceAfter = 6000,
                    BalanceBefore = 5000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                    Description = "Mobile money collection",
                    Reference = "order-12345",
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
        var model = new TransactionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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
        var model = new TransactionListResponse
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
        var model = new TransactionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransactionListResponse
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
        var model = new TransactionListResponse
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
        var model = new TransactionListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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

        TransactionListResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransactionListResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransactionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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

        TransactionListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    AccountID = "acc-001",
                    Amount = 1000,
                    BalanceAfter = 6000,
                    BalanceBefore = 5000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                    Description = "Mobile money collection",
                    Reference = "order-12345",
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
        var model = new TransactionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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
        var deserialized = JsonSerializer.Deserialize<TransactionListResponseIntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransactionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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
        var deserialized = JsonSerializer.Deserialize<TransactionListResponseIntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        TransactionListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    AccountID = "acc-001",
                    Amount = 1000,
                    BalanceAfter = 6000,
                    BalanceBefore = 5000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                    Description = "Mobile money collection",
                    Reference = "order-12345",
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
        var model = new TransactionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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
        var model = new TransactionListResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransactionListResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransactionListResponseIntersectionMember1
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
        var model = new TransactionListResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransactionListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        AccountID = "acc-001",
                        Amount = 1000,
                        BalanceAfter = 6000,
                        BalanceBefore = 5000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Status =
                            TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                        Description = "Mobile money collection",
                        Reference = "order-12345",
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

        TransactionListResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransactionListResponseIntersectionMember1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransactionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    AccountID = "acc-001",
                    Amount = 1000,
                    BalanceAfter = 6000,
                    BalanceBefore = 5000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                    Description = "Mobile money collection",
                    Reference = "order-12345",
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

        List<TransactionListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "txn-001",
                AccountID = "acc-001",
                Amount = 1000,
                BalanceAfter = 6000,
                BalanceBefore = 5000,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                Description = "Mobile money collection",
                Reference = "order-12345",
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
        var model = new TransactionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    AccountID = "acc-001",
                    Amount = 1000,
                    BalanceAfter = 6000,
                    BalanceBefore = 5000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                    Description = "Mobile money collection",
                    Reference = "order-12345",
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
            JsonSerializer.Deserialize<TransactionListResponseIntersectionMember1Data>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransactionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    AccountID = "acc-001",
                    Amount = 1000,
                    BalanceAfter = 6000,
                    BalanceBefore = 5000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                    Description = "Mobile money collection",
                    Reference = "order-12345",
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
            JsonSerializer.Deserialize<TransactionListResponseIntersectionMember1Data>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        List<TransactionListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "txn-001",
                AccountID = "acc-001",
                Amount = 1000,
                BalanceAfter = 6000,
                BalanceBefore = 5000,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                Description = "Mobile money collection",
                Reference = "order-12345",
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
        var model = new TransactionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    AccountID = "acc-001",
                    Amount = 1000,
                    BalanceAfter = 6000,
                    BalanceBefore = 5000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                    Description = "Mobile money collection",
                    Reference = "order-12345",
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
        var model = new TransactionListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    AccountID = "acc-001",
                    Amount = 1000,
                    BalanceAfter = 6000,
                    BalanceBefore = 5000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
                    Description = "Mobile money collection",
                    Reference = "order-12345",
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

        TransactionListResponseIntersectionMember1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransactionListResponseIntersectionMember1DataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransactionListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        string expectedID = "txn-001";
        string expectedAccountID = "acc-001";
        double expectedAmount = 1000;
        double expectedBalanceAfter = 6000;
        double expectedBalanceBefore = 5000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus> expectedStatus =
            TransactionListResponseIntersectionMember1DataDataStatus.Successful;
        ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType> expectedType =
            TransactionListResponseIntersectionMember1DataDataType.Credit;
        string expectedDescription = "Mobile money collection";
        string expectedReference = "order-12345";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccountID, model.AccountID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedBalanceAfter, model.BalanceAfter);
        Assert.Equal(expectedBalanceBefore, model.BalanceBefore);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedDescription, model.Description);
        Assert.Equal(expectedReference, model.Reference);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransactionListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransactionListResponseIntersectionMember1DataData>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransactionListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransactionListResponseIntersectionMember1DataData>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedID = "txn-001";
        string expectedAccountID = "acc-001";
        double expectedAmount = 1000;
        double expectedBalanceAfter = 6000;
        double expectedBalanceBefore = 5000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus> expectedStatus =
            TransactionListResponseIntersectionMember1DataDataStatus.Successful;
        ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType> expectedType =
            TransactionListResponseIntersectionMember1DataDataType.Credit;
        string expectedDescription = "Mobile money collection";
        string expectedReference = "order-12345";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccountID, deserialized.AccountID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedBalanceAfter, deserialized.BalanceAfter);
        Assert.Equal(expectedBalanceBefore, deserialized.BalanceBefore);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedDescription, deserialized.Description);
        Assert.Equal(expectedReference, deserialized.Reference);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransactionListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransactionListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Reference);
        Assert.False(model.RawData.ContainsKey("reference"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransactionListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransactionListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransactionListResponseIntersectionMember1DataDataType.Credit,

            // Null should be interpreted as omitted for these properties
            Description = null,
            Reference = null,
        };

        Assert.Null(model.Description);
        Assert.False(model.RawData.ContainsKey("description"));
        Assert.Null(model.Reference);
        Assert.False(model.RawData.ContainsKey("reference"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new TransactionListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransactionListResponseIntersectionMember1DataDataType.Credit,

            // Null should be interpreted as omitted for these properties
            Description = null,
            Reference = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransactionListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            AccountID = "acc-001",
            Amount = 1000,
            BalanceAfter = 6000,
            BalanceBefore = 5000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Status = TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransactionListResponseIntersectionMember1DataDataType.Credit,
            Description = "Mobile money collection",
            Reference = "order-12345",
        };

        TransactionListResponseIntersectionMember1DataData copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransactionListResponseIntersectionMember1DataDataStatusTest : TestBase
{
    [Theory]
    [InlineData(TransactionListResponseIntersectionMember1DataDataStatus.Pending)]
    [InlineData(TransactionListResponseIntersectionMember1DataDataStatus.Successful)]
    [InlineData(TransactionListResponseIntersectionMember1DataDataStatus.Failed)]
    [InlineData(TransactionListResponseIntersectionMember1DataDataStatus.Cancelled)]
    public void Validation_Works(TransactionListResponseIntersectionMember1DataDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransactionListResponseIntersectionMember1DataDataStatus.Pending)]
    [InlineData(TransactionListResponseIntersectionMember1DataDataStatus.Successful)]
    [InlineData(TransactionListResponseIntersectionMember1DataDataStatus.Failed)]
    [InlineData(TransactionListResponseIntersectionMember1DataDataStatus.Cancelled)]
    public void SerializationRoundtrip_Works(
        TransactionListResponseIntersectionMember1DataDataStatus rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class TransactionListResponseIntersectionMember1DataDataTypeTest : TestBase
{
    [Theory]
    [InlineData(TransactionListResponseIntersectionMember1DataDataType.Credit)]
    [InlineData(TransactionListResponseIntersectionMember1DataDataType.Debit)]
    public void Validation_Works(TransactionListResponseIntersectionMember1DataDataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransactionListResponseIntersectionMember1DataDataType.Credit)]
    [InlineData(TransactionListResponseIntersectionMember1DataDataType.Debit)]
    public void SerializationRoundtrip_Works(
        TransactionListResponseIntersectionMember1DataDataType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType>
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
