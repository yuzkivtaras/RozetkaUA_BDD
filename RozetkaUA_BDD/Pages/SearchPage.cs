using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaUA_BDD.Pages
{
    public class SearchPage: BasePage
    {
        public readonly By _buyItem = By.XPath("//div[@data-goods-id='320849056']//app-buy-button//button");
        public readonly By _cartButton = By.XPath("//rz-icon-counter//parent::button");

        private static SearchPage searchPage;
        public static SearchPage Instance => searchPage ?? (searchPage = new SearchPage());

        public void BuyItem() => FindElement(_buyItem).Click();
        public void CartButton() => FindElement(_cartButton).Click();
    }
}
