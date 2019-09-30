using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project_CSharp.Core.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_CSharp.Core
{
    class CommonActions
    {
        private static IJavaScriptExecutor javaScriptExecutor;

        static CommonActions()
        {
            javaScriptExecutor = DriverManager.GetInstance().GetWebDriver() as IJavaScriptExecutor;
        }
        public static string GetValueFromWebElement(IWebElement webElement, string value)
        {
            return webElement.GetAttribute(value);
        }

        public static void WaitUntilElementIsDisplayed(IWebElement webElement)
        {
            DriverManager.GetInstance().GetWebDriverWait().Until(elementToWait => webElement.Displayed);
        }

        public static void WaitUntilElementEnabled(IWebElement webElement)
        {
            DriverManager.GetInstance().GetWebDriverWait().Until(elementToWait => webElement.Enabled);
        }

        public static void ClickElementByJavaScript(IWebElement webElement)
        {
            WaitUntilElementIsDisplayed(webElement);
            javaScriptExecutor.ExecuteScript("arguments[0].click()", webElement);
        }
        public static void ClickElement(IWebElement webElement)
        {
            WaitUntilElementIsDisplayed(webElement);
            webElement.Click();
        }

        public static void SetInputField(IWebElement webElement, string value)
        {
            WaitUntilElementIsDisplayed(webElement);
            webElement.Clear();
            webElement.SendKeys(value);
        }

        public static void WaitFixedTime(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        public static string GetText(IWebElement webElement)
        {
            WaitUntilElementIsDisplayed(webElement);
            return webElement.Text;
        }

        public static bool IsDisplayed(IWebElement webElement)
        {
            WaitUntilElementIsDisplayed(webElement);
            return webElement.Displayed;
        }

        public static bool Enabled(IWebElement webElement)
        {
            WaitUntilElementEnabled(webElement);
            return webElement.Enabled;
        }

        public static bool IsEnabled(IWebElement webElement)
        {
            WaitUntilElementIsDisplayed(webElement);
            return webElement.Enabled;
        }

        public static void PressEscapeKey(IWebElement webElement)
        {
            WaitUntilElementIsDisplayed(webElement);
            webElement.SendKeys(Keys.Escape);
            WaitUntilElementIsDisplayed(webElement);
        }

        /// <summary>
        /// Selects a item about comboBox.
        /// </summary>
        /// <param name="element">ComboBox Webelement</param>
        /// <param name="value">Value to Select in a ComboBox</param>
        public static void SelectComboBox(IWebElement element, string value)
        {
            WaitUntilElementIsDisplayed(element);
            SelectElement dropdown = new SelectElement(element);
            dropdown.SelectByText(value.Trim());
        }
    }
}
