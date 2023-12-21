using OpenQA.Selenium;
using SeleniumFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC011
    {
        private IWebDriver _driver;

        public TC011(IWebDriver driver)
        {
            _driver = driver;
            TestCase();
        }
        public void TestCase()
        {
            ProductsPage productsPage = new ProductsPage(_driver);

            Assert.That(productsPage.inputSearchProduct("sampl"), Is.True, "Input product done");
            Assert.That(productsPage.clickSearch(), Is.True, "Clicking search done");
        }
    }
}
