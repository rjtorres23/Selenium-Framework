using OpenQA.Selenium;
using SeleniumFramework.Pages;
using SeleniumFramework.Utility;


namespace SeleniumFramework.Test.TestCases
{
    internal class TC012
    {
        private IWebDriver _driver;

        public TC012(IWebDriver driver)
        {
            _driver = driver;
            TestCase();
        }

        public void TestCase()
        {
            Helpers helpers = new Helpers(_driver);
            ProductsPage productsPage = new ProductsPage(_driver);

            productsPage.isSVisibleProductText();
            Thread.Sleep(1000);
            helpers.ScrollDown(_driver, 2000);
            productsPage.ViewProducts();

            bool productName = productsPage.isSVisibleProductName();
            bool productAmount = productsPage.isSVisibleProductAmount();
            bool productQty = productsPage.isSVisibleProductQty();
            bool productAvailability = productsPage.isSVisibleProductAvailability();
            bool productCondition = productsPage.isSVisibleProductCondition();
            bool producBrand = productsPage.isSVisibleProductBrand();

            Assert.Multiple(() =>
            {
                // Add  assertions 
                Assert.That(productName, Is.True, "Amount is visible.");
                Assert.That(productAmount, Is.True, "Amount field is visible.");
                Assert.That(productQty, Is.True, "Quantity is visible.");
                Assert.That(productCondition, Is.True, "Conditions is visble.");
                Assert.That(producBrand, Is.True, "Brand is visble.");
            });


        }





    }
}
