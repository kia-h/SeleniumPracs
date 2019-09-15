using Selenium_1.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_1.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetWebsite();
    }
}
