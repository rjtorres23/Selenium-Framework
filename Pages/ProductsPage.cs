using OpenQA.Selenium;
using SeleniumFramework.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class ProductsPage(IWebDriver driver) : BasePage(driver)
    {

        //########### Element Definition #############

        private By productsLink = By.XPath("//a[@href='/products']");
        private By searchProdcuts = By.XPath("//input[@id='search_product']");
        private By submitSearch = By.XPath("//button[@id='submit_search']");
        private By btnLogin = By.XPath("//button[normalize-space()='Login']");
        private By allProductsText = By.XPath("//h2[normalize-space()='All Products']]");
    }
}
