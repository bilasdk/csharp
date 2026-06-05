using System.Threading.Tasks;
using Usebila.Models.Webhooks;

namespace Usebila.Tests.Services;

public class WebhookServiceTest : TestBase
{
    [Fact(Skip = "Mock server tests are disabled")]
    public async Task Create_Works()
    {
        var webhook = await this.client.Webhooks.Create(
            new()
            {
                Events = [Event.PaymentCompleted, Event.WithdrawalCompleted],
                UrlValue = "https://example.com/webhooks",
            },
            TestContext.Current.CancellationToken
        );
        webhook.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task Update_Works()
    {
        var webhook = await this.client.Webhooks.Update(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        webhook.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task List_Works()
    {
        var webhooks = await this.client.Webhooks.List(
            new(),
            TestContext.Current.CancellationToken
        );
        webhooks.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task Deactivate_Works()
    {
        var response = await this.client.Webhooks.Deactivate(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task GetDeliveries_Works()
    {
        var response = await this.client.Webhooks.GetDeliveries(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task ListEvents_Works()
    {
        var response = await this.client.Webhooks.ListEvents(
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task RotateSecret_Works()
    {
        var response = await this.client.Webhooks.RotateSecret(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
