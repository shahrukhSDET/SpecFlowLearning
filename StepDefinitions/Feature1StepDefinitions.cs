using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Security.Policy;


namespace SpecFlowLearning.StepDefinitions
{
    [Binding]

    public sealed class Feature1StepDefinations
    {
        private IWebDriver driver;


        //constructor
        public Feature1StepDefinations(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Test Data
        string test_data = "xbox series x";

        //Scenario-1

        [Given(@"Open the browser")]
        public void Openthebrowser()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();

        }

        [When(@"Enter URL of Application")]
        public void EnterURLofApplication()
        {
            driver.Url = "https://www.microsoft.com/en-ww/store/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Thread.Sleep(4000);

        }

        [Then(@"Search for X-box product in Search field of Microsoft Official Website")]
        public void SearchforX_boxproductinSearchfieldofMicrosoftOfficialWebsite()
        {
            Thread.Sleep(6000);

            driver.FindElement(By.Id("search")).Click();
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(test_data);
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(Keys.Enter);
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//button[text()='Stay in United States - English']")).Click();
            Thread.Sleep(6000);
            //Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//h4[@class='my-0 py-0']//a[@href='https://www.microsoft.com/en-us/d/xbox-series-x/8wj714n3rbtl']")));
            IWebElement explore_condition = driver.FindElement(By.XPath("//ul[@class='nav']/li[2]//a[text()='Explore']"));
            Assert.AreEqual("Explore Microsoft.com", driver.Title);
            Assert.AreEqual("Explore", explore_condition.Text);

        }


        //Scenario-2

        [When(@"Enter URL of Website")]
        public void EnterURLofWebsite()
        {
            driver.Url = "https://www.microsoft.com/en-ww/store/";
            //Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        [Then(@"Veiwing the product page")]
        public void ThenVeiwingTheProductPage()
        {
            driver.FindElement(By.Id("search")).Click();
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(test_data);
            driver.FindElement(By.Id("cli_shellHeaderSearchInput")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Stay in United States - English']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[text()='Shop']")).Click();
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//a[text()='Xbox Series X – Diablo® IV Bundle']")).Click();
            driver.FindElement(By.XPath("//button[@aria-label='Close dialog window']")).Click();
            Thread.Sleep(2000);
        }


        //Scenerio 3
        [When(@"URL of Home Page")]
        public void WhenURLofHomepage()

        {

            driver.Url = "https://www.microsoft.com/en-ww/store/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


        }


        [Then(@"Count the links on the main page")]
        
        public void AndCountthelinksonthemainpage() 
        {
            ReadOnlyCollection<IWebElement> total_links = driver.FindElements(By.TagName ("a"));
            Console.WriteLine(total_links.Count);
            Assert.AreEqual(91, total_links.Count);

        }

        
        













    }        
}