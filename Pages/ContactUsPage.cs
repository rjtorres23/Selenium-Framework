using OpenQA.Selenium;
using SeleniumFramework.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
