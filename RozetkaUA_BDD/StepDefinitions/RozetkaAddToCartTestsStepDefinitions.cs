using RozetkaUA_BDD.Pages;
using System;
using TechTalk.SpecFlow;

namespace RozetkaUA_BDD.StepDefinitions
{
    [Binding]
    public class RozetkaAddToCartTestsStepDefinitions
    {
        [Given(@"I open official Rozetka web site")]
        public void OpenOfficialRozetkaWebSite()
        {
            HomePage.Instance.OpenRozetkaHomePage();
        }

        [When(@"I entered name of product from the Home Page")]
        public void EnteredNameOfProductFromThe()
        {
            HomePage.Instance.EnterSearchText();
            Thread.Sleep(2000);
        }

        [When(@"I buy Product from the Search Page")]
        public void BuyProductFromTheSearchPage()
        {
            SearchPage.Instance.BuyItem();
        }

        [When(@"I click on Cart")]
        public void WhenIClickOnCart()
        {
            SearchPage.Instance.CartButton();
            Thread.Sleep(2000);
        }

        [Then(@"I verify the item is in a cart from Cart Page")]
        public void VerifyTheItemIsInACartFromCartPage()
        {
            CartPage.Instance.CheckTextInTitle();
        }

    }
}
