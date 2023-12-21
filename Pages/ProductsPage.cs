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

        //########### Products View #############

        private By viewProducts = By.CssSelector("//a[href='/product_details/1']");
        private By productName = By.CssSelector("//h2[normalize-space()='Blue Top']");
        private By productAmount = By.CssSelector("//span[normalize-space()='Rs. 500']");
        private By productQuantity = By.CssSelector("//input[@id='quantity']");
        private By productAvailability = By.CssSelector("//b[normalize-space()='Availability:']");
        private By productCondition = By.CssSelector("//b[normalize-space()='Condition:']");
        private By productBrand = By.CssSelector("//b[normalize-space()='Brand:']");
        private By productBtnAddToCart = By.CssSelector("//button[normalize-space()='Add to cart']");

        //########### Write Review #############

        private By productReviewHeader = By.XPath("//a[normalize-space()='Write Your Review']");
        private By productReviewName = By.XPath("//input[@id='name']");
        private By productReviewEmail = By.XPath("//input[@id='email']");
        private By productReviewInput = By.XPath("//textarea[@id='review']");
        private By productReviewBtnSubmit = By.XPath("//button[@id='button-review']");


        public bool isSVisibleProductText()
        {
            return Helper.IsElementVisible(allProductsText);
        }
        public bool ProductLink()
        {
            return Helper.ClickElement(productsLink);
        }
        public bool SearchProduct()
        {
            return Helper.EnterText(searchProdcuts, "BlueTop");
        }
        public bool SubmitSearch()
        {
            return Helper.ClickElement(submitSearch);
        }

        public bool ViewProducts()
        {
            return Helper.ClickElement(viewProducts);
        }
        public bool isSVisibleProductName()
        {
            return Helper.IsElementVisible(productName);
        }
        public bool isSVisibleProductAmount()
        {
            return Helper.IsElementVisible(productAmount);
        }
        public bool isSVisibleProductQty()
        {
            return Helper.IsElementVisible(productQuantity);
        }
        public bool isSVisibleProductAvailability()
        {
            return Helper.IsElementVisible(productAvailability);
        }
        public bool isSVisibleProductCondition()
        {
            return Helper.IsElementVisible(productCondition);
        }
        public bool isSVisibleProductBrand()
        {
            return Helper.IsElementVisible(productBrand);
        }
        public bool ProductAddToCart()
        {
            return Helper.ClickElement(productBtnAddToCart);
        }

        //Review Product
        public bool isSVisibleProductHeader()
        {
            return Helper.IsElementVisible(productReviewHeader);
        }
        public bool ReviewName()
        {
            return Helper.EnterText(productReviewName, "Juan");
        }
        public bool ReviewEmail()
        {
            return Helper.EnterText(productReviewEmail, "Juan@gmail.com");
        }
        public bool ReviewFeedbackInput()
        {
            return Helper.EnterText(productReviewInput, "This is sample review feedback");
        }
        public bool SubmitReview()
        {
            return Helper.ClickElement(productReviewBtnSubmit);
        }




    }


}
