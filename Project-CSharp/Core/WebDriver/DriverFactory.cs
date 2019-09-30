
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Project_CSharp.Core.WebDriver
{
    class DriverFactory
    {
        public static IWebDriver GetDriver(DriverTypes driver)
        {
            Dictionary<DriverTypes, IDriver> drivers = new Dictionary<DriverTypes, IDriver>();
            drivers.Add(DriverTypes.CHROME, new Chrome());
            drivers.Add(DriverTypes.FIREFOX, new Firefox());
            drivers.Add(DriverTypes.IEXPLORER, new IExplorer());
            return drivers[driver].InitDriver();
        }
    }
}
