using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RozetkaUA_BDD.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaUA_BDD.Pages
{
    public class HomePage: BasePage
    {
        private string URL => "https://rozetka.com.ua/";

        public readonly By _searchField = By.XPath("//input[@name='search']");
        

        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage());

        public void OpenRozetkaHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
        }

        public void EnterSearchText() => FindElement(_searchField).SendKeys("Телефон" + Keys.Enter);
    }
}
