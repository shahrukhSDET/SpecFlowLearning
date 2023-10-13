using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowLearning.Pages
{
    public class AutoLoans
    {
        private IWebDriver driver;
        public AutoLoans(IWebDriver driver) 
        { 
            this.driver = driver;

        }

        public AgriculturalLoan GetlinkofAgri_rural() 
        {

            int currentwindowhandle = driver.WindowHandles.Count;
            TestContext.Progress.WriteLine(currentwindowhandle);
            string childWindow = driver.WindowHandles[1];
            driver.SwitchTo().Window(childWindow);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("3")).Click();
            
            return new AgriculturalLoan(driver);
        }


        

    }
}
