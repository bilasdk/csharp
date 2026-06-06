using Bila.Examples;

string example = args.Length > 0 ? args[0] : "banks";

try
{
    switch (example)
    {
        case "accounts":
            await AccountsExample.Run();
            break;
        case "banks":
            await BanksExample.Run();
            break;
        case "collections":
            await CollectionsExample.Run();
            break;
        case "resolve":
            await ResolveExample.Run();
            break;
        case "transactions":
            await TransactionsExample.Run();
            break;
        case "transfer-recipients":
            await TransferRecipientsExample.Run();
            break;
        case "transfers":
            await TransfersExample.Run();
            break;
        case "webhooks":
            await WebhooksExample.Run();
            break;
        default:
            Console.Error.WriteLine($"Unknown example: {example}");
            Console.Error.WriteLine();
            Console.Error.WriteLine("Available examples:");
            Console.Error.WriteLine("  accounts, banks, collections, resolve, transactions,");
            Console.Error.WriteLine("  transfer-recipients, transfers, webhooks");
            Environment.Exit(1);
            break;
    }
}
catch (Exception ex)
{
    Console.Error.WriteLine(ex);
    Environment.Exit(1);
}
