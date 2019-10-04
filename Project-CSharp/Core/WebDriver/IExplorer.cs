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
            InternetExplorerOptions options = new InternetExplorerOptions();
            return new InternetExplorerDriver(options);
        }
    }
}
