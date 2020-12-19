// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace Xunit.Extensions.Logger
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddXunitLogger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddLogging(loggingBuilder =>
                {
                    loggingBuilder.ClearProviders();
                    loggingBuilder.SetMinimumLevel(LogLevel.Trace);
                    loggingBuilder.AddNLog();
                })
                .AddSingleton(s => s.GetRequiredService<ILoggerFactory>().CreateLogger(string.Empty));

            NLog.LogManager.Configuration = new NLogLoggingConfiguration(configuration.GetSection("NLog"));
            return services;
        }
    }
}
