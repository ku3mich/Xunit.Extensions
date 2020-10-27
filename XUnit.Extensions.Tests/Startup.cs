using Microsoft.Extensions.DependencyInjection;
using XUnit.Extensions.Essentials;

namespace XUnit.Extensions.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddXUnitEssentials();
        }
    }
}
