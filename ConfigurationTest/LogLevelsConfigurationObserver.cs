using Tavisca.Platform.Common.ApplicationEventBus;

namespace ConfigurationTest
{
    public class LogLevelsConfigurationObserver : ApplicationEventObserver
    {
        private IConfigurationObserver _configurationObserver;

        public LogLevelsConfigurationObserver(IConfigurationObserver configurationObserver)
        {
            _configurationObserver = configurationObserver;
        }

        public override void Process(ApplicationEvent eventData)
        {
            _configurationObserver.Notify();
        }
    }
}
