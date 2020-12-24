using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationTest
{
    public interface IConfigurationObserver
    {
        void Notify();
    }
}
