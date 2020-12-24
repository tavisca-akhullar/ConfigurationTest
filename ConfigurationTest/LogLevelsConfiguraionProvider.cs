using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tavisca.Platform.Common.Configurations;

namespace ConfigurationTest
{
    public class LogLevelsConfiguraionProvider : LoggingConfigurationProvider
    {
        private readonly IConfigurationProvider _configurationProvider;
        private readonly IConfigurationObserver _observer;

        public LogLevelsConfiguraionProvider(IConfigurationProvider configurationProvider)
        {
            _configurationProvider = configurationProvider;
            _observer = new ConfigurationObserver(this);
        }

        public override Dictionary<string, string> GetSettingsAsync()
        {
            return _configurationProvider.GetGlobalConfiguration<Dictionary<string, string>>("logging", "log_levels");
        }
    }
}
