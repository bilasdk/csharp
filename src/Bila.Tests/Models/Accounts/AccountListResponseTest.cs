using System;
using System.Collections.Generic;
using System.Text.Json;
using Bila.Core;
using Bila.Models;
using Accounts = Bila.Models.Accounts;

namespace Bila.Tests.Models.Accounts;

public class AccountListResponseTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Accounts::AccountListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
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
                        Status = Accounts::Status.Active,
                        Type = Accounts::Type.Main,
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
        Accounts::Data expectedData = new()
        {
            DataValue =
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
                    Status = Accounts::Status.Active,
                    Type = Accounts::Type.Main,
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
        var model = new Accounts::AccountListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
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
                        Status = Accounts::Status.Active,
                        Type = Accounts::Type.Main,
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
        var deserialized = JsonSerializer.Deserialize<Accounts::AccountListResponse>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Accounts::AccountListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
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
                        Status = Accounts::Status.Active,
                        Type = Accounts::Type.Main,
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
        var deserialized = JsonSerializer.Deserialize<Accounts::AccountListResponse>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        string expectedMessage = "Operation completed successfully";
        bool expectedStatus = true;
        Accounts::Data expectedData = new()
        {
            DataValue =
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
                    Status = Accounts::Status.Active,
                    Type = Accounts::Type.Main,
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
        var model = new Accounts::AccountListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
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
                        Status = Accounts::Status.Active,
                        Type = Accounts::Type.Main,
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
        var model = new Accounts::AccountListResponse
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
        var model = new Accounts::AccountListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
        };

        model.Validate();
    }

    [Fact]
    public void OptionalNonNullablePropertiesSetToNullAreNotSet_Works()
    {
        var model = new Accounts::AccountListResponse
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
        var model = new Accounts::AccountListResponse
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
        var model = new Accounts::AccountListResponse
        {
            Message = "Operation completed successfully",
            Status = true,
            Data = new()
            {
                DataValue =
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
                        Status = Accounts::Status.Active,
                        Type = Accounts::Type.Main,
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

        Accounts::AccountListResponse copied = new(model);

        Assert.Equal(model, copied);
    }
}

public class DataTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var model = new Accounts::Data
        {
            DataValue =
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
                    Status = Accounts::Status.Active,
                    Type = Accounts::Type.Main,
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

        List<Accounts::AccountResponseDto> expectedDataValue =
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
                Status = Accounts::Status.Active,
                Type = Accounts::Type.Main,
                AvailableBalance = "1500.00",
                LedgerBalance = "1500.00",
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
        var model = new Accounts::Data
        {
            DataValue =
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
                    Status = Accounts::Status.Active,
                    Type = Accounts::Type.Main,
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
        var deserialized = JsonSerializer.Deserialize<Accounts::Data>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(model, deserialized);
    }

    [Fact]
    public void FieldRoundtripThroughSerialization_Works()
    {
        var model = new Accounts::Data
        {
            DataValue =
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
                    Status = Accounts::Status.Active,
                    Type = Accounts::Type.Main,
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
        var deserialized = JsonSerializer.Deserialize<Accounts::Data>(
            element,
            ModelBase.SerializerOptions
        );
        Assert.NotNull(deserialized);

        List<Accounts::AccountResponseDto> expectedDataValue =
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
                Status = Accounts::Status.Active,
                Type = Accounts::Type.Main,
                AvailableBalance = "1500.00",
                LedgerBalance = "1500.00",
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
        var model = new Accounts::Data
        {
            DataValue =
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
                    Status = Accounts::Status.Active,
                    Type = Accounts::Type.Main,
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
        var model = new Accounts::Data
        {
            DataValue =
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
                    Status = Accounts::Status.Active,
                    Type = Accounts::Type.Main,
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

        Accounts::Data copied = new(model);

        Assert.Equal(model, copied);
    }
}
