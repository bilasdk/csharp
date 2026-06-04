using System;
using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Accounts;

namespace Bila.Tests.Models.Accounts;

public class AccountListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountListResponse
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
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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
        AccountListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Details = new()
                    {
                        AccountName = "John Doe",
                        Type = "bank-account",
                        TillNumber = "123456",
                    },
                    Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                    Type = AccountListResponseIntersectionMember1DataDataType.Main,
                    AvailableBalance = "1500.00",
                    LedgerBalance = "1500.00",
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
        var model = new AccountListResponse
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
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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
        var deserialized = JsonSerializer.Deserialize<AccountListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountListResponse
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
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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
        var deserialized = JsonSerializer.Deserialize<AccountListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        AccountListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Details = new()
                    {
                        AccountName = "John Doe",
                        Type = "bank-account",
                        TillNumber = "123456",
                    },
                    Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                    Type = AccountListResponseIntersectionMember1DataDataType.Main,
                    AvailableBalance = "1500.00",
                    LedgerBalance = "1500.00",
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
        var model = new AccountListResponse
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
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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
        var model = new AccountListResponse
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
        var model = new AccountListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AccountListResponse
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
        var model = new AccountListResponse
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
        var model = new AccountListResponse
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
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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

        AccountListResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountListResponseIntersectionMember1Test : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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

        AccountListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Details = new()
                    {
                        AccountName = "John Doe",
                        Type = "bank-account",
                        TillNumber = "123456",
                    },
                    Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                    Type = AccountListResponseIntersectionMember1DataDataType.Main,
                    AvailableBalance = "1500.00",
                    LedgerBalance = "1500.00",
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
        var model = new AccountListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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
        var deserialized = JsonSerializer.Deserialize<AccountListResponseIntersectionMember1>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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
        var deserialized = JsonSerializer.Deserialize<AccountListResponseIntersectionMember1>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        AccountListResponseIntersectionMember1Data expectedData = new()
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Details = new()
                    {
                        AccountName = "John Doe",
                        Type = "bank-account",
                        TillNumber = "123456",
                    },
                    Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                    Type = AccountListResponseIntersectionMember1DataDataType.Main,
                    AvailableBalance = "1500.00",
                    LedgerBalance = "1500.00",
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
        var model = new AccountListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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
        var model = new AccountListResponseIntersectionMember1 { };

        Assert.Null(model.Data);
        Assert.False(model.RawData.ContainsKey("data"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AccountListResponseIntersectionMember1 { };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AccountListResponseIntersectionMember1
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
        var model = new AccountListResponseIntersectionMember1
        {
            // Null should be interpreted as omitted for these properties
            Data = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountListResponseIntersectionMember1
        {
            Data = new()
            {
                Data =
                [
                    new()
                    {
                        ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                        CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                        Currency = "ZMW",
                        Details = new()
                        {
                            AccountName = "John Doe",
                            Type = "bank-account",
                            TillNumber = "123456",
                        },
                        Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                        Type = AccountListResponseIntersectionMember1DataDataType.Main,
                        AvailableBalance = "1500.00",
                        LedgerBalance = "1500.00",
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

        AccountListResponseIntersectionMember1 copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountListResponseIntersectionMember1DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Details = new()
                    {
                        AccountName = "John Doe",
                        Type = "bank-account",
                        TillNumber = "123456",
                    },
                    Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                    Type = AccountListResponseIntersectionMember1DataDataType.Main,
                    AvailableBalance = "1500.00",
                    LedgerBalance = "1500.00",
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

        List<AccountListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Details = new()
                {
                    AccountName = "John Doe",
                    Type = "bank-account",
                    TillNumber = "123456",
                },
                Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                Type = AccountListResponseIntersectionMember1DataDataType.Main,
                AvailableBalance = "1500.00",
                LedgerBalance = "1500.00",
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
        var model = new AccountListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Details = new()
                    {
                        AccountName = "John Doe",
                        Type = "bank-account",
                        TillNumber = "123456",
                    },
                    Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                    Type = AccountListResponseIntersectionMember1DataDataType.Main,
                    AvailableBalance = "1500.00",
                    LedgerBalance = "1500.00",
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
        var deserialized = JsonSerializer.Deserialize<AccountListResponseIntersectionMember1Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Details = new()
                    {
                        AccountName = "John Doe",
                        Type = "bank-account",
                        TillNumber = "123456",
                    },
                    Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                    Type = AccountListResponseIntersectionMember1DataDataType.Main,
                    AvailableBalance = "1500.00",
                    LedgerBalance = "1500.00",
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
        var deserialized = JsonSerializer.Deserialize<AccountListResponseIntersectionMember1Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<AccountListResponseIntersectionMember1DataData> expectedData =
        [
            new()
            {
                ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                Currency = "ZMW",
                Details = new()
                {
                    AccountName = "John Doe",
                    Type = "bank-account",
                    TillNumber = "123456",
                },
                Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                Type = AccountListResponseIntersectionMember1DataDataType.Main,
                AvailableBalance = "1500.00",
                LedgerBalance = "1500.00",
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
        var model = new AccountListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Details = new()
                    {
                        AccountName = "John Doe",
                        Type = "bank-account",
                        TillNumber = "123456",
                    },
                    Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                    Type = AccountListResponseIntersectionMember1DataDataType.Main,
                    AvailableBalance = "1500.00",
                    LedgerBalance = "1500.00",
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
        var model = new AccountListResponseIntersectionMember1Data
        {
            Data =
            [
                new()
                {
                    ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                    CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
                    Currency = "ZMW",
                    Details = new()
                    {
                        AccountName = "John Doe",
                        Type = "bank-account",
                        TillNumber = "123456",
                    },
                    Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
                    Type = AccountListResponseIntersectionMember1DataDataType.Main,
                    AvailableBalance = "1500.00",
                    LedgerBalance = "1500.00",
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

        AccountListResponseIntersectionMember1Data copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountListResponseIntersectionMember1DataDataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
            Type = AccountListResponseIntersectionMember1DataDataType.Main,
            AvailableBalance = "1500.00",
            LedgerBalance = "1500.00",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        AccountListResponseIntersectionMember1DataDataDetails expectedDetails = new()
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };
        ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus> expectedStatus =
            AccountListResponseIntersectionMember1DataDataStatus.Active;
        ApiEnum<string, AccountListResponseIntersectionMember1DataDataType> expectedType =
            AccountListResponseIntersectionMember1DataDataType.Main;
        string expectedAvailableBalance = "1500.00";
        string expectedLedgerBalance = "1500.00";

        Assert.Equal(expectedID, model.ID);
        Assert.Equal(expectedCreatedAt, model.CreatedAt);
        Assert.Equal(expectedCurrency, model.Currency);
        Assert.Equal(expectedDetails, model.Details);
        Assert.Equal(expectedStatus, model.Status);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedAvailableBalance, model.AvailableBalance);
        Assert.Equal(expectedLedgerBalance, model.LedgerBalance);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
            Type = AccountListResponseIntersectionMember1DataDataType.Main,
            AvailableBalance = "1500.00",
            LedgerBalance = "1500.00",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<AccountListResponseIntersectionMember1DataData>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
            Type = AccountListResponseIntersectionMember1DataDataType.Main,
            AvailableBalance = "1500.00",
            LedgerBalance = "1500.00",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<AccountListResponseIntersectionMember1DataData>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        DateTimeOffset expectedCreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z");
        string expectedCurrency = "ZMW";
        AccountListResponseIntersectionMember1DataDataDetails expectedDetails = new()
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };
        ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus> expectedStatus =
            AccountListResponseIntersectionMember1DataDataStatus.Active;
        ApiEnum<string, AccountListResponseIntersectionMember1DataDataType> expectedType =
            AccountListResponseIntersectionMember1DataDataType.Main;
        string expectedAvailableBalance = "1500.00";
        string expectedLedgerBalance = "1500.00";

        Assert.Equal(expectedID, deserialized.ID);
        Assert.Equal(expectedCreatedAt, deserialized.CreatedAt);
        Assert.Equal(expectedCurrency, deserialized.Currency);
        Assert.Equal(expectedDetails, deserialized.Details);
        Assert.Equal(expectedStatus, deserialized.Status);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedAvailableBalance, deserialized.AvailableBalance);
        Assert.Equal(expectedLedgerBalance, deserialized.LedgerBalance);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
            Type = AccountListResponseIntersectionMember1DataDataType.Main,
            AvailableBalance = "1500.00",
            LedgerBalance = "1500.00",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
            Type = AccountListResponseIntersectionMember1DataDataType.Main,
        };

        Assert.Null(model.AvailableBalance);
        Assert.False(model.RawData.ContainsKey("availableBalance"));
        Assert.Null(model.LedgerBalance);
        Assert.False(model.RawData.ContainsKey("ledgerBalance"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
            Type = AccountListResponseIntersectionMember1DataDataType.Main,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
            Type = AccountListResponseIntersectionMember1DataDataType.Main,

            // Null should be interpreted as omitted for these properties
            AvailableBalance = null,
            LedgerBalance = null,
        };

        Assert.Null(model.AvailableBalance);
        Assert.False(model.RawData.ContainsKey("availableBalance"));
        Assert.Null(model.LedgerBalance);
        Assert.False(model.RawData.ContainsKey("ledgerBalance"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
            Type = AccountListResponseIntersectionMember1DataDataType.Main,

            // Null should be interpreted as omitted for these properties
            AvailableBalance = null,
            LedgerBalance = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataData
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            CreatedAt = DateTimeOffset.Parse("2024-01-15T10:30:00Z"),
            Currency = "ZMW",
            Details = new()
            {
                AccountName = "John Doe",
                Type = "bank-account",
                TillNumber = "123456",
            },
            Status = AccountListResponseIntersectionMember1DataDataStatus.Active,
            Type = AccountListResponseIntersectionMember1DataDataType.Main,
            AvailableBalance = "1500.00",
            LedgerBalance = "1500.00",
        };

        AccountListResponseIntersectionMember1DataData copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountListResponseIntersectionMember1DataDataDetailsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataDataDetails
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        string expectedAccountName = "John Doe";
        string expectedType = "bank-account";
        string expectedTillNumber = "123456";

        Assert.Equal(expectedAccountName, model.AccountName);
        Assert.Equal(expectedType, model.Type);
        Assert.Equal(expectedTillNumber, model.TillNumber);
    }

    [Fact]
    public void SerializationRoundtrip_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataDataDetails
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        string json = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<AccountListResponseIntersectionMember1DataDataDetails>(
                json,
                ModelBase.SerializerOptions
            );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataDataDetails
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        string element = JsonSerializer.Serialize(model, ModelBase.SerializerOptions);
        var deserialized =
            JsonSerializer.Deserialize<AccountListResponseIntersectionMember1DataDataDetails>(
                element,
                ModelBase.SerializerOptions
            );
        Assert.NotNull(deserialized);

        string expectedAccountName = "John Doe";
        string expectedType = "bank-account";
        string expectedTillNumber = "123456";

        Assert.Equal(expectedAccountName, deserialized.AccountName);
        Assert.Equal(expectedType, deserialized.Type);
        Assert.Equal(expectedTillNumber, deserialized.TillNumber);
    }

    [Fact]
    public void Validation_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataDataDetails
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetAreNotSet_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataDataDetails
        {
            AccountName = "John Doe",
            Type = "bank-account",
        };

        Assert.Null(model.TillNumber);
        Assert.False(model.RawData.ContainsKey("tillNumber"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesUnsetValidation_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataDataDetails
        {
            AccountName = "John Doe",
            Type = "bank-account",
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataDataDetails
        {
            AccountName = "John Doe",
            Type = "bank-account",

            // Null should be interpreted as omitted for these properties
            TillNumber = null,
        };

        Assert.Null(model.TillNumber);
        Assert.False(model.RawData.ContainsKey("tillNumber"));
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullValidation_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataDataDetails
        {
            AccountName = "John Doe",
            Type = "bank-account",

            // Null should be interpreted as omitted for these properties
            TillNumber = null,
        };

        model.Validate();
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var model = new AccountListResponseIntersectionMember1DataDataDetails
        {
            AccountName = "John Doe",
            Type = "bank-account",
            TillNumber = "123456",
        };

        AccountListResponseIntersectionMember1DataDataDetails copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class AccountListResponseIntersectionMember1DataDataStatusTest : TestBase
{
    [Theory]
    [InlineData(AccountListResponseIntersectionMember1DataDataStatus.Active)]
    [InlineData(AccountListResponseIntersectionMember1DataDataStatus.Inactive)]
    [InlineData(AccountListResponseIntersectionMember1DataDataStatus.Suspended)]
    public void Validation_Works(AccountListResponseIntersectionMember1DataDataStatus rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountListResponseIntersectionMember1DataDataStatus.Active)]
    [InlineData(AccountListResponseIntersectionMember1DataDataStatus.Inactive)]
    [InlineData(AccountListResponseIntersectionMember1DataDataStatus.Suspended)]
    public void SerializationRoundtrip_Works(
        AccountListResponseIntersectionMember1DataDataStatus rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }
}

public class AccountListResponseIntersectionMember1DataDataTypeTest : TestBase
{
    [Theory]
    [InlineData(AccountListResponseIntersectionMember1DataDataType.Main)]
    [InlineData(AccountListResponseIntersectionMember1DataDataType.Sub)]
    [InlineData(AccountListResponseIntersectionMember1DataDataType.Virtual)]
    public void Validation_Works(AccountListResponseIntersectionMember1DataDataType rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountListResponseIntersectionMember1DataDataType> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AccountListResponseIntersectionMember1DataDataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(AccountListResponseIntersectionMember1DataDataType.Main)]
    [InlineData(AccountListResponseIntersectionMember1DataDataType.Sub)]
    [InlineData(AccountListResponseIntersectionMember1DataDataType.Virtual)]
    public void SerializationRoundtrip_Works(
        AccountListResponseIntersectionMember1DataDataType rawValue
    )
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, AccountListResponseIntersectionMember1DataDataType> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountListResponseIntersectionMember1DataDataType>
        >(json, ModelBase.SerializerOptions);

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<
            ApiEnum<string, AccountListResponseIntersectionMember1DataDataType>
        >(JsonSerializer.SerializeToElement("invalid value"), ModelBase.SerializerOptions);
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<
            ApiEnum<string, AccountListResponseIntersectionMember1DataDataType>
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
