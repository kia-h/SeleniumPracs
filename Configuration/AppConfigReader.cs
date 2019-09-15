using Selenium_1.Interfaces;
using Selenium_1.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_1.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string b= ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)(Enum.Parse(typeof(BrowserType),b));
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
    }
}
