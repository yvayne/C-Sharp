using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Core.WebDriver
{
    class DriverManager
    {
        private static DriverManager instance;
        private IWebDriver webDriver;
        private WebDriverWait webDriverWait;
        public static string ForceBrowser;

        /// <summary>
        /// This method will create required instance for webdriver.
        /// </summary>
        private DriverManager()
        {
            InitializeDriver();
        }

        /// <summary>
        /// This method will return an instance of DriverManager
        /// </summary>
        /// <returns>DriverManager instance</returns>
        public static DriverManager GetInstance()
        {
            if (instance is null)
            {
                instance = new DriverManager();
            }
            return instance;
        }

        /// <summary>
        /// This method will initalize the webdriver.
        /// </summary>
        public void InitializeDriver()
        {
            DriverTypes driverType;
            if (ForceBrowser != null)
            {
                driverType = (DriverTypes)Enum.Parse(typeof(DriverTypes), ForceBrowser);
            }
            else
            {
                driverType = (DriverTypes)Enum.Parse(typeof(DriverTypes), EnvironmentManager.GetEnvironment().Browser);
            }

            int implicitWait = int.Parse(ConfigurationManager.AppSettings["ImplicitTime"].ToString());
            int explicitWait = int.Parse(ConfigurationManager.AppSettings["ExplicitTime"].ToString());

            webDriver = DriverFactory.GetDriver(driverType);
            webDriver.Manage().Window.Maximize();

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(explicitWait));
        }

        /// <summary>
        /// This method will close webdriver window.
        /// </summary>
        public void QuitWebDriver()
        {
            webDriver.Quit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IWebDriver GetWebDriver()
        {
            return webDriver;
        }

        public WebDriverWait GetWebDriverWait()
        {
            return webDriverWait;
        }
    }
}
