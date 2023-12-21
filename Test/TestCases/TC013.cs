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
            TC013_Verify_Feedack_Review_Form();
        }

        public void TC013_Verify_Feedack_Review_Form()
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
