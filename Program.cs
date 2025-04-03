using GraphQL;
using GraphQL.Server.Ui.Altair;
using Microsoft.AspNetCore.Builder;

namespace OtterCMSDotNet;

public static class  Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        var app = builder.Build();
        app.UseGraphQLAltair();

        await app.RunAsync().ConfigureAwait(false);
    }
}
