using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Core.WebDriver
{
    class IExplorer : IDriver
    {
        public IWebDriver InitDriver()
        {
            string driverPath = AppDomain.CurrentDomain.BaseDirectory;
            System.Environment.SetEnvironmentVariable("webdriver.ie.driver", driverPath + "\\IEDriverServer.exe");
            return new InternetExplorerDriver();
        }
    }
}
