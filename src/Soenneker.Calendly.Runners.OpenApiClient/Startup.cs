using Microsoft.Extensions.DependencyInjection;
using Soenneker.Managers.Runners.Registrars;
using Soenneker.Calendly.Runners.OpenApiClient.Utils;
using Soenneker.Calendly.Runners.OpenApiClient.Utils.Abstract;

namespace Soenneker.Calendly.Runners.OpenApiClient;

/// <summary>
/// Console type startup
/// </summary>
public static class Startup
{
    // This method gets called by the runtime. Use this method to add services to the container.
    public static void ConfigureServices(IServiceCollection services)
    {
        services.SetupIoC();
    }

    public static IServiceCollection SetupIoC(this IServiceCollection services)
    {
        services.AddHostedService<ConsoleHostedService>()
                .AddScoped<IFileOperationsUtil, FileOperationsUtil>()
                .AddRunnersManagerAsScoped()
                .AddScoped<StoplightOpenApiBundler>();

        return services;
    }
}
