using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter_Library
{
    public class Settings_Adapter: ISettings_Adapter
    {
        readonly ApplicationSettingsBase Settings;

        public Settings_Adapter(ApplicationSettingsBase _Settings)
        {
            Settings = _Settings;
        }

        public object this[string propertyName]
        {
            get
            {
                return Settings[propertyName];
            }
        }
    }
}
