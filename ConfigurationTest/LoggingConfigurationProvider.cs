using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using TaviscaConfigurationProvider = Tavisca.Platform.Common.Configurations.IConfigurationProvider;

namespace ConfigurationTest
{
    public abstract class LoggingConfigurationProvider : ConfigurationProvider
    {
        public abstract Dictionary<string, string> GetSettingsAsync();

        public override void Load()
        {
            Data = GetSettingsAsync();
        }
    }
}
