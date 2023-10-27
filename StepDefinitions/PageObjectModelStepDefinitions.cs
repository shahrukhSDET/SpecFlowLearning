using OpenQA.Selenium;
using SpecFlowLearning.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowLearning.StepDefinitions
{
    [Binding]
    public class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;

        HomePage homePage;
        AutoLoans autoloans;
        AgriculturalLoan agriculturalLoan;



        //constructor
        public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }



        [Given(@"Input URL of sbi web application")]
        public void GivenInputURLOfSbiWebApplication()
        {
            driver.Url = "https://www.onlinesbi.sbi/#";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        [When(@"Hovering on SBI Loans")]
        public void WhenHoveringOnSBILoans()
        {
            //creating object of HomePage
            homePage = new HomePage(driver);

            autoloans = homePage.Sbiloan();
            Thread.Sleep(2000);

            

            //creating object of AutoLoans
            autoloans = new AutoLoans(driver);

            agriculturalLoan = autoloans.GetlinkofAgri_rural();
            Thread.Sleep(2000);

        }


        [Then(@"Clicking on Agri_Rural link fromAutoLoans page")]
        public void ClickingonAgri_RurallinkfromAutoLoanspage()
        {

            //autoloans = new AutoLoans(driver);
            //agriculturalLoan = autoloans.GetTitle();
 

        }



        // Scenario-2

        [Given(@"Type in end point of Application")]
        public void TypeinendpointofApplication()
        {
            driver.Url = "https://www.onlinesbi.sbi/#";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Then(@"Click on the Login button")]
        public void ClickontheLoginbutton()
        {
            driver.FindElement(By.XPath("//a[@href='https://retail.onlinesbi.sbi/retail/login.htm']")).Click();

        }






    }
}
