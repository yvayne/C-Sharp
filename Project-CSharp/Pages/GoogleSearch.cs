using OpenQA.Selenium;
using Project_CSharp.Core;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Pages
{
    class GoogleSearch : Core.BasePage
    {
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement _searchTextField;

        [FindsBy(How = How.CssSelector, Using = ".FPdoLc center .gNO89b")]
        private IWebElement _searchButton;

        public void SetSearchTextField(String text)
        {
            CommonActions.SetInputField(_searchTextField, text);
        }

        public void ClickSearchButton()
        {
            CommonActions.ClickElement(_searchButton);
        }
    }
}
