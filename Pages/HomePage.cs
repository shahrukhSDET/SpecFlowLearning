using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
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

        //IWebElement sbi_loan_button = driver.FindElement(By.XPath("//a[text()='SBI Loans']"));
        string hower1 ="//ul[@class='dropdown-menu sm-nowrap']//li[1]";
        //By hower2 = By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[2]");
        //By hower3 = By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[3]");
        //By hower4 = By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[4]");
        //By hower5 = By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[5]");



        public AutoLoans Sbiloan()
        {
            driver.FindElement(By.XPath("//a[text()='SBI Loans']")).Click();

            IWebElement hower1 = driver.FindElement(By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[1]"));
            IWebElement hower2 = driver.FindElement(By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[2]"));
            IWebElement hower3 = driver.FindElement(By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[3]"));
            IWebElement hower4 = driver.FindElement(By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[4]"));
            IWebElement hower5 = driver.FindElement(By.XPath("//ul[@class='dropdown-menu sm-nowrap']//li[5]"));


            /*driver.FindElement(sbi_loan_button).Click();
            Actions actions = new Actions(driver);
            driver.FindElement(hower1);
            Thread.Sleep(1000);
            driver.FindElement(hower2);
            Thread.Sleep(1000);

            driver.FindElement(hower3);
            Thread.Sleep(1000);

            driver.FindElement(hower4);
            Thread.Sleep(1000);

            driver.FindElement(hower5);
            Thread.Sleep(1000);
            */
            Actions actions = new Actions(driver);
            actions.MoveToElement(hower1).MoveToElement(hower2).MoveToElement(hower3).MoveToElement(hower4).MoveToElement(hower5).Click().Perform();
            return new AutoLoans(driver);

        }

        
        

        


        







    }
}
