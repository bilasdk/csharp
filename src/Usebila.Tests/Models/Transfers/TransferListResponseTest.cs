using System;
using System.Collections.Generic;
using System.Text.Json;
using Usebila.Core;
using Usebila.Models;
using Usebila.Models.Transfers;

namespace Usebila.Tests.Models.Transfers;

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
                DataValue =
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
                        Status = TransferResponseDtoStatus.Successful,
                        Type = TransferResponseDtoType.BankAccount,
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
        Data expectedData = new()
        {
            DataValue =
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
                    Status = TransferResponseDtoStatus.Successful,
                    Type = TransferResponseDtoType.BankAccount,
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
                DataValue =
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
                        Status = TransferResponseDtoStatus.Successful,
                        Type = TransferResponseDtoType.BankAccount,
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
                DataValue =
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
                        Status = TransferResponseDtoStatus.Successful,
                        Type = TransferResponseDtoType.BankAccount,
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
        Data expectedData = new()
        {
            DataValue =
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
                    Status = TransferResponseDtoStatus.Successful,
                    Type = TransferResponseDtoType.BankAccount,
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
                DataValue =
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
                        Status = TransferResponseDtoStatus.Successful,
                        Type = TransferResponseDtoType.BankAccount,
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
                DataValue =
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
                        Status = TransferResponseDtoStatus.Successful,
                        Type = TransferResponseDtoType.BankAccount,
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

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Data
        {
            DataValue =
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
                    Status = TransferResponseDtoStatus.Successful,
                    Type = TransferResponseDtoType.BankAccount,
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

        List<TransferResponseDto> expectedDataValue =
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
                Status = TransferResponseDtoStatus.Successful,
                Type = TransferResponseDtoType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        ];
        PaginationMetaDto expectedMeta = new()
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        Assert.Equal(expectedDataValue.Count, model.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], model.DataValue[i]);
        }
        Assert.Equal(expectedMeta, model.Meta);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new Data
        {
            DataValue =
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
                    Status = TransferResponseDtoStatus.Successful,
                    Type = TransferResponseDtoType.BankAccount,
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
        var deserialized = JsonSerializer.Deserialize<Data>(json, ModelBase.SerializerOptions);

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Data
        {
            DataValue =
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
                    Status = TransferResponseDtoStatus.Successful,
                    Type = TransferResponseDtoType.BankAccount,
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
        var deserialized = JsonSerializer.Deserialize<Data>(element, ModelBase.SerializerOptions);
        Assert.NotNull(deserialized);

        List<TransferResponseDto> expectedDataValue =
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
                Status = TransferResponseDtoStatus.Successful,
                Type = TransferResponseDtoType.BankAccount,
                CompletedAt = DateTimeOffset.Parse("2024-01-15T10:31:00Z"),
                Narration = "Salary payment",
            },
        ];
        PaginationMetaDto expectedMeta = new()
        {
            CurrentPage = 1,
            PageCount = 3,
            PerPage = 50,
            Total = 150,
        };

        Assert.Equal(expectedDataValue.Count, deserialized.DataValue.Count);
        for (int i = 0; i < expectedDataValue.Count; i++)
        {
            Assert.Equal(expectedDataValue[i], deserialized.DataValue[i]);
        }
        Assert.Equal(expectedMeta, deserialized.Meta);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new Data
        {
            DataValue =
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
                    Status = TransferResponseDtoStatus.Successful,
                    Type = TransferResponseDtoType.BankAccount,
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
        var model = new Data
        {
            DataValue =
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
                    Status = TransferResponseDtoStatus.Successful,
                    Type = TransferResponseDtoType.BankAccount,
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

        Data copied = new(model);

        Assert.Equal(model, copied);
    }
}
