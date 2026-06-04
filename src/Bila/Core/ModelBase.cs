using System.Text.Json;
using Bila.Exceptions;
using Bila.Models.Accounts;
using Bila.Models.Resolve;
using Collections = Bila.Models.Collections;
using Transactions = Bila.Models.Transactions;
using TransferRecipients = Bila.Models.TransferRecipients;
using Transfers = Bila.Models.Transfers;
using Webhooks = Bila.Models.Webhooks;

namespace Bila.Core;

/// <summary>
/// The base class for all API objects with properties.
///
/// <para>API objects such as enums do not inherit from this class.</para>
/// </summary>
public abstract record class ModelBase
{
    protected ModelBase(ModelBase modelBase)
    {
        // Nothing to copy. Just so that subclasses can define copy constructors.
    }

    internal static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new FrozenDictionaryConverterFactory(),
            new ApiEnumConverter<string, Status>(),
            new ApiEnumConverter<string, Type>(),
            new ApiEnumConverter<string, AccountListResponseIntersectionMember1DataDataStatus>(),
            new ApiEnumConverter<string, AccountListResponseIntersectionMember1DataDataType>(),
            new ApiEnumConverter<string, TransferRecipients::DataType>(),
            new ApiEnumConverter<
                string,
                TransferRecipients::TransferRecipientListResponseIntersectionMember1DataDataType
            >(),
            new ApiEnumConverter<
                string,
                TransferRecipients::TransferRecipientCreateBankAccountResponseIntersectionMember1DataType
            >(),
            new ApiEnumConverter<
                string,
                TransferRecipients::TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType
            >(),
            new ApiEnumConverter<string, TransferRecipients::Type>(),
            new ApiEnumConverter<string, TransferRecipients::Country>(),
            new ApiEnumConverter<
                string,
                TransferRecipients::TransferRecipientCreateMobileMoneyParamsCountry
            >(),
            new ApiEnumConverter<string, TransferRecipients::Operator>(),
            new ApiEnumConverter<string, Transfers::DataStatus>(),
            new ApiEnumConverter<string, Transfers::DataType>(),
            new ApiEnumConverter<
                string,
                Transfers::TransferListResponseIntersectionMember1DataDataStatus
            >(),
            new ApiEnumConverter<
                string,
                Transfers::TransferListResponseIntersectionMember1DataDataType
            >(),
            new ApiEnumConverter<
                string,
                Transfers::TransferGetStatusByReferenceResponseIntersectionMember1DataStatus
            >(),
            new ApiEnumConverter<
                string,
                Transfers::TransferGetStatusByReferenceResponseIntersectionMember1DataType
            >(),
            new ApiEnumConverter<
                string,
                Transfers::TransferInitiateBankTransferResponseIntersectionMember1DataStatus
            >(),
            new ApiEnumConverter<
                string,
                Transfers::TransferInitiateBankTransferResponseIntersectionMember1DataType
            >(),
            new ApiEnumConverter<
                string,
                Transfers::TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
            >(),
            new ApiEnumConverter<
                string,
                Transfers::TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType
            >(),
            new ApiEnumConverter<string, Transfers::Status>(),
            new ApiEnumConverter<string, Transfers::Type>(),
            new ApiEnumConverter<string, Transfers::Country>(),
            new ApiEnumConverter<
                string,
                Transfers::TransferInitiateMobileMoneyTransferParamsCountry
            >(),
            new ApiEnumConverter<string, Transfers::Operator>(),
            new ApiEnumConverter<string, Collections::DataStatus>(),
            new ApiEnumConverter<string, Collections::FeeBearer>(),
            new ApiEnumConverter<
                string,
                Collections::CollectionListResponseIntersectionMember1DataDataStatus
            >(),
            new ApiEnumConverter<
                string,
                Collections::CollectionListResponseIntersectionMember1DataDataFeeBearer
            >(),
            new ApiEnumConverter<
                string,
                Collections::CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus
            >(),
            new ApiEnumConverter<
                string,
                Collections::CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer
            >(),
            new ApiEnumConverter<
                string,
                Collections::CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus
            >(),
            new ApiEnumConverter<
                string,
                Collections::CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer
            >(),
            new ApiEnumConverter<string, Collections::Status>(),
            new ApiEnumConverter<string, Collections::Country>(),
            new ApiEnumConverter<string, Collections::Operator>(),
            new ApiEnumConverter<string, Collections::Bearer>(),
            new ApiEnumConverter<string, Transactions::Status>(),
            new ApiEnumConverter<string, Transactions::DataType>(),
            new ApiEnumConverter<
                string,
                Transactions::TransactionListResponseIntersectionMember1DataDataStatus
            >(),
            new ApiEnumConverter<
                string,
                Transactions::TransactionListResponseIntersectionMember1DataDataType
            >(),
            new ApiEnumConverter<string, Transactions::Type>(),
            new ApiEnumConverter<string, Webhooks::Status>(),
            new ApiEnumConverter<string, Webhooks::Event>(),
            new ApiEnumConverter<string, Webhooks::WebhookUpdateParamsEvent>(),
            new ApiEnumConverter<string, Country>(),
            new ApiEnumConverter<string, ResolveMobileMoneyParamsCountry>(),
            new ApiEnumConverter<string, Operator>(),
        },
    };

    internal static readonly JsonSerializerOptions ToStringSerializerOptions = new(
        SerializerOptions
    )
    {
        WriteIndented = true,
    };

    /// <summary>
    /// Validates that all required fields are set and that each field's value is of the expected type.
    ///
    /// <para>This is useful for instances constructed from raw JSON data (e.g. deserialized from an API response).</para>
    ///
    /// <exception cref="BilaInvalidDataException">
    /// Thrown when the instance does not pass validation.
    /// </exception>
    /// </summary>
    public abstract void Validate();
}
