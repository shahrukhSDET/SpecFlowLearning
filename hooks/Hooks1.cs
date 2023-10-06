using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowLearning.Hooks1
{
    [Binding]
    public sealed class Hooks1

    {
       
        private readonly IObjectContainer _container;

        //constructor
        public Hooks1(IObjectContainer container) 
        {
            _container = container;
        }

        [BeforeScenario("@X-box_Gaming_Console")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("This is a specflow BDD Framework Learning Tutorial");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();

            if (driver != null ) 
            {
            driver.Quit();
            }
            
        }
    }
}