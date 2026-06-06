using Bila;
using Bila.Core;
using Bila.Models.Webhooks;

namespace Bila.Examples;

/// <summary>
/// Webhooks examples
///
/// To demonstrate how to configure webhooks
/// and manage delivery history.
/// </summary>
static class WebhooksExample
{
    const string WebhookId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

    public static async Task Run()
    {
        BilaClient client = new()
        {
            ApiKey = Environment.GetEnvironmentVariable("BILA_API_KEY") ?? "sk_test_your_api_key_here",
            BaseUrl = EnvironmentUrl.Sandbox,
        };

        /********************************************
         * Create webhook
         *********************************************/
        WebhookCreateParams createParams = new()
        {
            Events =
            [
                Event.PaymentCompleted,
                Event.WithdrawalCompleted,
                Event.TransferCompleted,
            ],
            UrlValue = "https://example.com/webhooks",
        };

        WebhookCreateResponse created = await client.Webhooks.Create(createParams);
        Console.WriteLine("create: {0}", created);

        /********************************************
         * Update webhook
         *********************************************/
        WebhookUpdateParams updateParams = new()
        {
            Events =
            [
                WebhookUpdateParamsEvent.PaymentCompleted,
                WebhookUpdateParamsEvent.CollectionCompleted,
                WebhookUpdateParamsEvent.TransferFailed,
            ],
            UrlValue = "https://example.com/webhooks/v2",
            IsActive = true,
        };

        WebhookUpdateResponse updated = await client.Webhooks.Update(WebhookId, updateParams);
        Console.WriteLine("update: {0}", updated);

        /********************************************
         * List webhooks
         *********************************************/
        WebhookListResponse webhooks = await client.Webhooks.List();
        Console.WriteLine("list: {0}", webhooks);

        /********************************************
         * Get webhook deliveries
         *********************************************/
        WebhookGetDeliveriesParams deliveriesParams = new()
        {
            StartDate = "2026-04-01T00:00:00.000Z",
            EndDate = "2026-04-30T23:59:59.999Z",
            EventType = "payment.completed",
            Page = 1,
            PerPage = 20,
            Status = "DELIVERED",
        };

        WebhookGetDeliveriesResponse deliveries =
            await client.Webhooks.GetDeliveries(WebhookId, deliveriesParams);
        Console.WriteLine("getDeliveries: {0}", deliveries);

        /********************************************
         * List webhook events
         *********************************************/
        WebhookListEventsResponse events = await client.Webhooks.ListEvents();
        Console.WriteLine("listEvents: {0}", events);

        /********************************************
         * Rotate webhook secret
         *********************************************/
        WebhookRotateSecretResponse rotated = await client.Webhooks.RotateSecret(WebhookId);
        Console.WriteLine("rotateSecret: {0}", rotated);

        /********************************************
         * Deactivate webhook
         *********************************************/
        WebhookDeactivateResponse deactivated = await client.Webhooks.Deactivate(WebhookId);
        Console.WriteLine("deactivate: {0}", deactivated);
    }
}
