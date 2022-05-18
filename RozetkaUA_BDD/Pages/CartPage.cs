using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaUA_BDD.Pages
{
    public class CartPage: BasePage
    {
        private static CartPage cartPage;
        public static CartPage Instance => cartPage ?? (cartPage = new CartPage());

        private readonly By _title = By.XPath("//div[@class='cart-product__main']//a");

        public void CheckTextInTitle() => FindElement(_title).Text.Contains("Мобильный телефон Samsung Galaxy");


    }
}
