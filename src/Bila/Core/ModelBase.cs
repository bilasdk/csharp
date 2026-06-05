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
            new ApiEnumConverter<string, TransferRecipients::RecipientResponseDtoType>(),
            new ApiEnumConverter<string, TransferRecipients::Type>(),
            new ApiEnumConverter<string, TransferRecipients::Country>(),
            new ApiEnumConverter<
                string,
                TransferRecipients::TransferRecipientCreateMobileMoneyParamsCountry
            >(),
            new ApiEnumConverter<string, TransferRecipients::Operator>(),
            new ApiEnumConverter<string, Transfers::TransferResponseDtoStatus>(),
            new ApiEnumConverter<string, Transfers::TransferResponseDtoType>(),
            new ApiEnumConverter<string, Transfers::Status>(),
            new ApiEnumConverter<string, Transfers::Type>(),
            new ApiEnumConverter<string, Transfers::Country>(),
            new ApiEnumConverter<
                string,
                Transfers::TransferInitiateMobileMoneyTransferParamsCountry
            >(),
            new ApiEnumConverter<string, Transfers::Operator>(),
            new ApiEnumConverter<string, Collections::BilaCollectionResponseDtoStatus>(),
            new ApiEnumConverter<string, Collections::FeeBearer>(),
            new ApiEnumConverter<string, Collections::Status>(),
            new ApiEnumConverter<string, Collections::Country>(),
            new ApiEnumConverter<string, Collections::Operator>(),
            new ApiEnumConverter<string, Collections::Bearer>(),
            new ApiEnumConverter<string, Transactions::Status>(),
            new ApiEnumConverter<string, Transactions::TransactionResponseDtoType>(),
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
