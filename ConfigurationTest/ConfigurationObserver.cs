using Tavisca.Common.Plugins.Configuration;
using Tavisca.Platform.Common.ApplicationEventBus;
using Tavisca.Platform.Common.Configurations;

namespace ConfigurationTest
{
    public class ConfigurationObserver : IConfigurationObserver
    {
        private IApplicationEventBus _applicationEventBus;
        private ApplicationEventObserver _observer;
        private IConfigurationProvider _configurationProvider;
        private LoggingConfigurationProvider _loggingConfigurationProvider;

        public ConfigurationObserver(LoggingConfigurationProvider loggingConfigurationProvider)
        {
            _loggingConfigurationProvider = loggingConfigurationProvider;
            _observer = new LogLevelsConfigurationObserver(this);
            _applicationEventBus = new ApplicationEventBus();
            _applicationEventBus.Register("consul-update", _observer);
            _configurationProvider = new ConfigurationProvider("logging_test");
        }

        public void Notify()
        {
            _loggingConfigurationProvider.Load();
        }
    }
}