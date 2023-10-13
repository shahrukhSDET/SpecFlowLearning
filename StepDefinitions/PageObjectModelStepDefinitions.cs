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
            homePage = new HomePage(driver);
            autoloans = homePage.Sbiloan();
            Thread.Sleep(5000);

            autoloans = new AutoLoans(driver);
            agriculturalLoan = autoloans.GetlinkofAgri_rural();


        }


        [Then(@"Clicking on Agri_Rural link fromAutoLoans page")]
        public void ClickingonAgri_RurallinkfromAutoLoanspage()
        {
            //autoloans = new AutoLoans(driver);
            //agriculturalLoan = autoloans.GetlinkofAgri_rural();


        }



    }
}
