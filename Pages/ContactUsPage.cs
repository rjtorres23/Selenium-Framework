using OpenQA.Selenium;
using SeleniumFramework.Pages.Base;
using SeleniumFramework.Utility;
using System.Xml.Linq;


namespace SeleniumFramework.Pages
{
    public class ContactUsPage(IWebDriver driver) : BasePage(driver)
    {

        //########### Element Definition #############

        private By txtName = By.XPath("//input[@placeholder='Name']");
        private By txtEmail = By.XPath("//input[@placeholder='Email']");
        private By txtSubject = By.XPath("//input[@placeholder='Subject']");
        private By txtMessage = By.XPath("//textarea[@id='message']");
        private By btnChooseFile = By.XPath("//input[@name='upload_file']");
        private By btnSubmit = By.XPath("//input[@name='submit']");

     
        
        //######### Function Definition #################
    
        public bool inputName()
        {
         
            return Helper.EnterText(txtName, "Test");
        }


        public bool inputEmail()
        {
            return Helper.EnterText(txtEmail, "test@gmail.com");

        }

        public bool inputSubject()
        {
            return Helper.EnterText(txtSubject, "This is subject");

        }

        public bool inputMessage()
        {
            return Helper.EnterText(txtMessage, "This is sample message");

        }

        public bool clickChooseFile()
        {
            return Helper.ClickElement(btnChooseFile);
        }

        public bool clickSubmit()
        {
            return Helper.ClickElement(btnSubmit);
        }

        //Assert


    }
}
