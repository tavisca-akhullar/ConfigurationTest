using Microsoft.Extensions.Configuration;

namespace ConfigurationTest
{
    public class ConfigurationSource : IConfigurationSource
    {
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new LogLevelsConfiguraionProvider(new Tavisca.Common.Plugins.Configuration.ConfigurationProvider("logging_test"));
        }
    }
}
