using OpenQA.Selenium;
using Project_CSharp.Core.WebDriver;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Core
{
    public abstract class BasePage
    {
        protected IWebDriver driver = DriverManager.GetInstance().GetWebDriver();
        public BasePage()
        {
            PageFactory.InitElements(driver, this);
        }

        public string getTitle()
        {
            return DriverManager.GetInstance().GetWebDriver().Title;
        }
    }
}
