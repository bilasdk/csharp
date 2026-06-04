using System;
using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Transfers;

namespace Bila.Tests.Models.Transfers;

public class TransferListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferListResponse
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
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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
        TransferListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    Amount = 1000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Recipient = new()
                    {
                        AccountName = "JOHN DOE",
                        AccountNumber = "1234567890",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "payout-12345",
                    Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    Narration = "Salary payment",
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
        var model = new TransferListResponse
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
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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
        var deserialized = JsonSerializer.Deserialize<TransferListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferListResponse
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
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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
        var deserialized = JsonSerializer.Deserialize<TransferListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransferListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    Amount = 1000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Recipient = new()
                    {
                        AccountName = "JOHN DOE",
                        AccountNumber = "1234567890",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "payout-12345",
                    Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    Narration = "Salary payment",
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
        var model = new TransferListResponse
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
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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
        var model = new TransferListResponse
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
        var model = new TransferListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferListResponse
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
        var model = new TransferListResponse
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
        var model = new TransferListResponse
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
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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

        TransferListResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferListResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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

        TransferListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    Amount = 1000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Recipient = new()
                    {
                        AccountName = "JOHN DOE",
                        AccountNumber = "1234567890",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "payout-12345",
                    Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    Narration = "Salary payment",
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
        var model = new TransferListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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
        var deserialized = JsonSerializer.Deserialize<TransferListResponseIntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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
        var deserialized = JsonSerializer.Deserialize<TransferListResponseIntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        TransferListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    Amount = 1000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Recipient = new()
                    {
                        AccountName = "JOHN DOE",
                        AccountNumber = "1234567890",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "payout-12345",
                    Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    Narration = "Salary payment",
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
        var model = new TransferListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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
        var model = new TransferListResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransferListResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferListResponseIntersectionMember1
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
        var model = new TransferListResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "txn-001",
                        Amount = 1000,
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Recipient = new()
                        {
                            AccountName = "JOHN DOE",
                            AccountNumber = "1234567890",
                            BankName = "Zambia National Commercial Bank",
                            Operator = "airtel",
                            Phone = "0977123456",
                        },
                        Reference = "payout-12345",
                        Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                        Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                        CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                        Narration = "Salary payment",
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

        TransferListResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferListResponseIntersectionMember1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    Amount = 1000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Recipient = new()
                    {
                        AccountName = "JOHN DOE",
                        AccountNumber = "1234567890",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "payout-12345",
                    Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    Narration = "Salary payment",
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

        List<TransferListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "txn-001",
                Amount = 1000,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Recipient = new()
                {
                    AccountName = "JOHN DOE",
                    AccountNumber = "1234567890",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
                },
                Reference = "payout-12345",
                Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
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
        var model = new TransferListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    Amount = 1000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Recipient = new()
                    {
                        AccountName = "JOHN DOE",
                        AccountNumber = "1234567890",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "payout-12345",
                    Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    Narration = "Salary payment",
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
        var deserialized = JsonSerializer.Deserialize<TransferListResponseIntersectionMember1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    Amount = 1000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Recipient = new()
                    {
                        AccountName = "JOHN DOE",
                        AccountNumber = "1234567890",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "payout-12345",
                    Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    Narration = "Salary payment",
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
        var deserialized = JsonSerializer.Deserialize<TransferListResponseIntersectionMember1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<TransferListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "txn-001",
                Amount = 1000,
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Recipient = new()
                {
                    AccountName = "JOHN DOE",
                    AccountNumber = "1234567890",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
                },
                Reference = "payout-12345",
                Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
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
        var model = new TransferListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    Amount = 1000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Recipient = new()
                    {
                        AccountName = "JOHN DOE",
                        AccountNumber = "1234567890",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "payout-12345",
                    Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    Narration = "Salary payment",
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
        var model = new TransferListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "txn-001",
                    Amount = 1000,
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Recipient = new()
                    {
                        AccountName = "JOHN DOE",
                        AccountNumber = "1234567890",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
                    },
                    Reference = "payout-12345",
                    Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
                    Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
                    CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                    Narration = "Salary payment",
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

        TransferListResponseIntersectionMember1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferListResponseIntersectionMember1DataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        string expectedID = "txn-001";
        double expectedAmount = 1000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        TransferListResponseIntersectionMember1DataDataRecipient expectedRecipient = new()
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "payout-12345";
        ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus> expectedStatus =
            TransferListResponseIntersectionMember1DataDataStatus.Successful;
        ApiEnum<string, TransferListResponseIntersectionMember1DataDataType> expectedType =
            TransferListResponseIntersectionMember1DataDataType.BankAccount;
        DateTimeOffset expectedCompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z");
        string expectedNarration = "Salary payment";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAmount, model.Amount);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedRecipient, model.Recipient);
        Assert.Equal(expectedReference, model.Reference);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedCompletedAt, model.CompletedAt);
        Assert.Equal(expectedNarration, model.Narration);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferListResponseIntersectionMember1DataData>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferListResponseIntersectionMember1DataData>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedID = "txn-001";
        double expectedAmount = 1000;
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        TransferListResponseIntersectionMember1DataDataRecipient expectedRecipient = new()
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };
        string expectedReference = "payout-12345";
        ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus> expectedStatus =
            TransferListResponseIntersectionMember1DataDataStatus.Successful;
        ApiEnum<string, TransferListResponseIntersectionMember1DataDataType> expectedType =
            TransferListResponseIntersectionMember1DataDataType.BankAccount;
        DateTimeOffset expectedCompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z");
        string expectedNarration = "Salary payment";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAmount, deserialized.Amount);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedRecipient, deserialized.Recipient);
        Assert.Equal(expectedReference, deserialized.Reference);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedCompletedAt, deserialized.CompletedAt);
        Assert.Equal(expectedNarration, deserialized.Narration);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
        };

        Assert.Null(model.CompletedAt);
        Assert.False(model.RawData.ContainsKey("completedAt"));
        Assert.Null(model.Narration);
        Assert.False(model.RawData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,

            // Null should be interpreted as omitted for these properties
            CompletedAt = null,
            Narration = null,
        };

        Assert.Null(model.CompletedAt);
        Assert.False(model.RawData.ContainsKey("completedAt"));
        Assert.Null(model.Narration);
        Assert.False(model.RawData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,

            // Null should be interpreted as omitted for these properties
            CompletedAt = null,
            Narration = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataData
        {
            ID = "txn-001",
            Amount = 1000,
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Recipient = new()
            {
                AccountName = "JOHN DOE",
                AccountNumber = "1234567890",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
            },
            Reference = "payout-12345",
            Status = TransferListResponseIntersectionMember1DataDataStatus.Successful,
            Type = TransferListResponseIntersectionMember1DataDataType.BankAccount,
            CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
            Narration = "Salary payment",
        };

        TransferListResponseIntersectionMember1DataData copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferListResponseIntersectionMember1DataDataRecipientTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataDataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string expectedAccountName = "JOHN DOE";
        string expectedAccountNumber = "1234567890";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedAccountName, model.AccountName);
        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedBankName, model.BankName);
        Assert.Equal(expectedOperator, model.Operator);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataDataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferListResponseIntersectionMember1DataDataRecipient>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataDataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferListResponseIntersectionMember1DataDataRecipient>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedAccountName = "JOHN DOE";
        string expectedAccountNumber = "1234567890";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedAccountName, deserialized.AccountName);
        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedBankName, deserialized.BankName);
        Assert.Equal(expectedOperator, deserialized.Operator);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataDataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataDataRecipient
        {
            AccountName = "JOHN DOE",
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
        Assert.Null(model.BankName);
        Assert.False(model.RawData.ContainsKey("bankName"));
        Assert.Null(model.Operator);
        Assert.False(model.RawData.ContainsKey("operator"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataDataRecipient
        {
            AccountName = "JOHN DOE",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataDataRecipient
        {
            AccountName = "JOHN DOE",

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
        Assert.Null(model.BankName);
        Assert.False(model.RawData.ContainsKey("bankName"));
        Assert.Null(model.Operator);
        Assert.False(model.RawData.ContainsKey("operator"));
        Assert.Null(model.Phone);
        Assert.False(model.RawData.ContainsKey("phone"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataDataRecipient
        {
            AccountName = "JOHN DOE",

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferListResponseIntersectionMember1DataDataRecipient
        {
            AccountName = "JOHN DOE",
            AccountNumber = "1234567890",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        TransferListResponseIntersectionMember1DataDataRecipient copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferListResponseIntersectionMember1DataDataStatusTest : TestBase
{
    [Theory]
    [InlineData(TransferListResponseIntersectionMember1DataDataStatus.Pending)]
    [InlineData(TransferListResponseIntersectionMember1DataDataStatus.Successful)]
    [InlineData(TransferListResponseIntersectionMember1DataDataStatus.Failed)]
    public void Validation_Works(TransferListResponseIntersectionMember1DataDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferListResponseIntersectionMember1DataDataStatus.Pending)]
    [InlineData(TransferListResponseIntersectionMember1DataDataStatus.Successful)]
    [InlineData(TransferListResponseIntersectionMember1DataDataStatus.Failed)]
    public void SerializationRoundtrip_Works(
        TransferListResponseIntersectionMember1DataDataStatus rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class TransferListResponseIntersectionMember1DataDataTypeTest : TestBase
{
    [Theory]
    [InlineData(TransferListResponseIntersectionMember1DataDataType.BankAccount)]
    [InlineData(TransferListResponseIntersectionMember1DataDataType.MobileMoney)]
    public void Validation_Works(TransferListResponseIntersectionMember1DataDataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferListResponseIntersectionMember1DataDataType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferListResponseIntersectionMember1DataDataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferListResponseIntersectionMember1DataDataType.BankAccount)]
    [InlineData(TransferListResponseIntersectionMember1DataDataType.MobileMoney)]
    public void SerializationRoundtrip_Works(
        TransferListResponseIntersectionMember1DataDataType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferListResponseIntersectionMember1DataDataType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferListResponseIntersectionMember1DataDataType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferListResponseIntersectionMember1DataDataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferListResponseIntersectionMember1DataDataType>
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
