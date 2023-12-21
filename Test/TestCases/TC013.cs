using OpenQA.Selenium;
using SeleniumFramework.Utility;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Test.TestCases
{
    internal class TC013
    {
        private IWebDriver _driver;

        public TC013(IWebDriver driver)
        {
            _driver = driver; ;
            TestCase();
        }

        public void TestCase()
        {
            Helpers helpers = new Helpers(_driver);
            ProductsPage productsPage = new ProductsPage(_driver);

            productsPage.ReviewName();
            productsPage.ReviewEmail();
            productsPage.ReviewFeedbackInput();
            productsPage.SubmitReview();

        }
    }
}
