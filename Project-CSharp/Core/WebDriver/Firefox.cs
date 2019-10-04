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
            
            FirefoxOptions options = new FirefoxOptions();
            return new FirefoxDriver(options);
        }
    }
}
