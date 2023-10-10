using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowLearning.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        //constructor
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By sbi_loan_button = By.XPath("//a[text()='SBI Loans']");
        By hower1 = By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[1]");
        By hower2 = By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[2]");
        By hower3 = By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[3]");
        By hower4 = By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[4]");
        By hower5 = By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[5]");

        

        public AutoLoans Sbiloan()
        {
            driver.FindElement(sbi_loan_button).Click();
            Actions actions = new Actions(driver);
            driver.FindElement(hower1).Click();
            driver.FindElement(hower2).Click();
            driver.FindElement(hower3).Click();
            driver.FindElement(hower4).Click();
            driver.FindElement(hower5).Click();
            actions.MoveToElement((IWebElement)hower1).MoveToElement((IWebElement)hower2).MoveToElement((IWebElement)hower3).MoveToElement((IWebElement)hower4).MoveToElement((IWebElement)hower5).Click().Perform();
            return new AutoLoans(driver);
          

        }


    }
}
