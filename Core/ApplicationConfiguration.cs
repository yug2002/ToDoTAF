using Core.Helpers;
using Microsoft.Extensions.Configuration;

namespace Core
{
    public class ApplicationConfiguration
    {
        private IConfigurationRoot GetConfigurationRoot()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("settings.json")
                .AddEnvironmentVariables()
                .Build();

            return configuration;
        }

        public T GetApplicationConfiguration<T>() where T : ITestSettings
        {
            var configuration = ObjectFactory.Get<T>();
            var iConfig = GetConfigurationRoot();
            iConfig.GetSection(typeof(T).Name)
                .Bind(configuration);
            return configuration;
        }
    }
}

