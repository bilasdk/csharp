using System;
using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.TransferRecipients;

namespace Bila.Tests.Models.TransferRecipients;

public class TransferRecipientListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferRecipientListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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
        TransferRecipientListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    AccountName = "John Doe",
                    Country = "zm",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                    AccountNumber = "1234567890",
                    BankID = "bank-001",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
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
        var model = new TransferRecipientListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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
        var deserialized = JsonSerializer.Deserialize<TransferRecipientListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferRecipientListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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
        var deserialized = JsonSerializer.Deserialize<TransferRecipientListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        TransferRecipientListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    AccountName = "John Doe",
                    Country = "zm",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                    AccountNumber = "1234567890",
                    BankID = "bank-001",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
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
        var model = new TransferRecipientListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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
        var model = new TransferRecipientListResponse
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
        var model = new TransferRecipientListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferRecipientListResponse
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
        var model = new TransferRecipientListResponse
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
        var model = new TransferRecipientListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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

        TransferRecipientListResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferRecipientListResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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

        TransferRecipientListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    AccountName = "John Doe",
                    Country = "zm",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                    AccountNumber = "1234567890",
                    BankID = "bank-001",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
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
        var model = new TransferRecipientListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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
        var deserialized =
            JsonSerializer.Deserialize<TransferRecipientListResponseIntersectionMember1>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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
        var deserialized =
            JsonSerializer.Deserialize<TransferRecipientListResponseIntersectionMember1>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        TransferRecipientListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    AccountName = "John Doe",
                    Country = "zm",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                    AccountNumber = "1234567890",
                    BankID = "bank-001",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
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
        var model = new TransferRecipientListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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
        var model = new TransferRecipientListResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1
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
        var model = new TransferRecipientListResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        AccountName = "John Doe",
                        Country = "zm",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Type =
                            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                        AccountNumber = "1234567890",
                        BankID = "bank-001",
                        BankName = "Zambia National Commercial Bank",
                        Operator = "airtel",
                        Phone = "0977123456",
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

        TransferRecipientListResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferRecipientListResponseIntersectionMember1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    AccountName = "John Doe",
                    Country = "zm",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                    AccountNumber = "1234567890",
                    BankID = "bank-001",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
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

        List<TransferRecipientListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
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
        var model = new TransferRecipientListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    AccountName = "John Doe",
                    Country = "zm",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                    AccountNumber = "1234567890",
                    BankID = "bank-001",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
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
            JsonSerializer.Deserialize<TransferRecipientListResponseIntersectionMember1Data>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    AccountName = "John Doe",
                    Country = "zm",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                    AccountNumber = "1234567890",
                    BankID = "bank-001",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
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
            JsonSerializer.Deserialize<TransferRecipientListResponseIntersectionMember1Data>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        List<TransferRecipientListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                AccountName = "John Doe",
                Country = "zm",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                AccountNumber = "1234567890",
                BankID = "bank-001",
                BankName = "Zambia National Commercial Bank",
                Operator = "airtel",
                Phone = "0977123456",
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
        var model = new TransferRecipientListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    AccountName = "John Doe",
                    Country = "zm",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                    AccountNumber = "1234567890",
                    BankID = "bank-001",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
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
        var model = new TransferRecipientListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    AccountName = "John Doe",
                    Country = "zm",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
                    AccountNumber = "1234567890",
                    BankID = "bank-001",
                    BankName = "Zambia National Commercial Bank",
                    Operator = "airtel",
                    Phone = "0977123456",
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

        TransferRecipientListResponseIntersectionMember1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferRecipientListResponseIntersectionMember1DataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedAccountName = "John Doe";
        string expectedCountry = "zm";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        ApiEnum<string, TransferRecipientListResponseIntersectionMember1DataDataType> expectedType =
            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount;
        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedAccountName, model.AccountName);
        Assert.Equal(expectedCountry, model.Country);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedAccountNumber, model.AccountNumber);
        Assert.Equal(expectedBankID, model.BankID);
        Assert.Equal(expectedBankName, model.BankName);
        Assert.Equal(expectedOperator, model.Operator);
        Assert.Equal(expectedPhone, model.Phone);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferRecipientListResponseIntersectionMember1DataData>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<TransferRecipientListResponseIntersectionMember1DataData>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedAccountName = "John Doe";
        string expectedCountry = "zm";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        ApiEnum<string, TransferRecipientListResponseIntersectionMember1DataDataType> expectedType =
            TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount;
        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        string expectedBankName = "Zambia National Commercial Bank";
        string expectedOperator = "airtel";
        string expectedPhone = "0977123456";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedAccountName, deserialized.AccountName);
        Assert.Equal(expectedCountry, deserialized.Country);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedAccountNumber, deserialized.AccountNumber);
        Assert.Equal(expectedBankID, deserialized.BankID);
        Assert.Equal(expectedBankName, deserialized.BankName);
        Assert.Equal(expectedOperator, deserialized.Operator);
        Assert.Equal(expectedPhone, deserialized.Phone);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
        Assert.Null(model.BankID);
        Assert.False(model.RawData.ContainsKey("bankId"));
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
        var model = new TransferRecipientListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankID = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        Assert.Null(model.AccountNumber);
        Assert.False(model.RawData.ContainsKey("accountNumber"));
        Assert.Null(model.BankID);
        Assert.False(model.RawData.ContainsKey("bankId"));
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
        var model = new TransferRecipientListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,

            // Null should be interpreted as omitted for these properties
            AccountNumber = null,
            BankID = null,
            BankName = null,
            Operator = null,
            Phone = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new TransferRecipientListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            AccountName = "John Doe",
            Country = "zm",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Type = TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            BankName = "Zambia National Commercial Bank",
            Operator = "airtel",
            Phone = "0977123456",
        };

        TransferRecipientListResponseIntersectionMember1DataData copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class TransferRecipientListResponseIntersectionMember1DataDataTypeTest : TestBase
{
    [Theory]
    [InlineData(TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount)]
    [InlineData(TransferRecipientListResponseIntersectionMember1DataDataType.MobileMoney)]
    public void Validation_Works(
        TransferRecipientListResponseIntersectionMember1DataDataType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferRecipientListResponseIntersectionMember1DataDataType> value =
            rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientListResponseIntersectionMember1DataDataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount)]
    [InlineData(TransferRecipientListResponseIntersectionMember1DataDataType.MobileMoney)]
    public void SerializationRoundtrip_Works(
        TransferRecipientListResponseIntersectionMember1DataDataType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, TransferRecipientListResponseIntersectionMember1DataDataType> value =
            rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientListResponseIntersectionMember1DataDataType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientListResponseIntersectionMember1DataDataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, TransferRecipientListResponseIntersectionMember1DataDataType>
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
