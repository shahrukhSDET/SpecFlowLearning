using NUnit.Framework;
using OpenQA.Selenium;
using System.Net;
using System.Net.Http;
using OpenQA.Selenium.DevTools.V114.Network;
using OpenQA.Selenium.Interactions;

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
            int currentWindowHandle = driver.WindowHandles.Count;
            TestContext.WriteLine("window number opened is " + currentWindowHandle);


            //switching to window-2
            string childWindow = driver.WindowHandles[1];
            driver.SwitchTo().Window(childWindow);
            Thread.Sleep(1000);

            //Validating image from UI
            //IWebElement image_element = driver.FindElement(By.XPath("//a[@href='/web/personal-banking/home']"));
            //string imgSrc = image_element.GetAttribute("/o/SBI-Theme/images/custom/logo.png");
            //HttpClient client = new HttpClient();
            //HttpResponseMessage message = client.GetAsync(imgSrc).Result;
            //if (message.StatusCode == HttpStatusCode.OK)
            //{
            //    Console.WriteLine("Image is accesible");
            //}
            //else
            //{
            //    Console.WriteLine("Image is not accesible");

            //}



            driver.FindElement(By.Id("3")).Click();

            string title = driver.Title;
            TestContext.WriteLine("title of page is " + title);
            Assert.AreEqual("Get Agricultural & Rural Banking Help Online in India | SBI - Agri & Rural", driver.Title);
            IWebElement get_text = driver.FindElement(By.XPath("//div[@class='card-header sbi-acr-card-header d-none d-lg-block d-xl-block']"));
            string get_text1 = get_text.Text;
            Console.WriteLine("The text of the element is " + get_text1);  
            return new AgriculturalLoan(driver);

            


        }

        


        

    }
}
