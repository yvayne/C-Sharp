using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Core.WebDriver
{
    interface IDriver
    {

        /// <summary>
        /// Initialize the selenium driver
        /// </summary>
        /// <returns>IWebDriver</returns>
        IWebDriver InitDriver();
    }
}
