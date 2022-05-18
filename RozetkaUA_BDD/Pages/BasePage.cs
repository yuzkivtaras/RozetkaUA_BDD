using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RozetkaUA_BDD.Tests;
using System.Collections.ObjectModel;


namespace RozetkaUA_BDD.Pages
{
    public class BasePage
    {
        public BasePage()
        {

        }

        public IWebElement FindElement(By locator)
        {
            return DriverManager.Instance().FindElement(locator);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return DriverManager.Instance().FindElements(locator);
        }
    }
}
