using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project_CSharp.Core.WebDriver
{
    class Chrome : IDriver
    {
        public IWebDriver InitDriver()
        {
            String driverFolder = "Driver";
            String path = Path.GetDirectoryName(GetType().Assembly.Location);
            String chromeDriverPath = Path.Combine(path, driverFolder);
            ChromeOptions options = new ChromeOptions();
            return new ChromeDriver(chromeDriverPath, options);
        }
    }
}
