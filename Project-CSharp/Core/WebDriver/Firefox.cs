using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Core.WebDriver
{
    class Firefox : IDriver
    {
        public IWebDriver InitDriver()
        {
            string driverPath = AppDomain.CurrentDomain.BaseDirectory;
            System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", driverPath + "\\geckodriver.exe");
            FirefoxOptions options = new FirefoxOptions();
            return new FirefoxDriver(driverPath, options);
        }
    }
}
