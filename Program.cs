using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using OtterCMSDotNet.Database;


namespace OtterCMSDotNet;

public static class  Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        //**************************************************************
        // This block sets up an API Endpoint (I think), not sure I
        // actually need it.
        // builder.Services.AddControllers();
        // builder.Services.AddEndpointsApiExplorer();
        // builder.Services.AddSwaggerGen();
        //**************************************************************
        builder.Services.AddSqlite<DbCmsContext>("Data Source=OtterCMS.db");

        builder.Services.AddScoped<DbQueries>();

        var app = builder.Build();
        app.UseGraphQLAltair();

        await app.RunAsync().ConfigureAwait(false);
    }
}
