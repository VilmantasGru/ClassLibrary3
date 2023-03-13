using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Net.WebRequestMethods;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.DevTools.V108.CSS;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace ClassLibrary3
{
    public class Testai

    {
        static WebDriver driver = new ChromeDriver();
      

        [SetUp]
        public static void SETUP()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.aic.lt/";
            driver.FindElement(By.XPath("//button[@id='lgcookieslaw_accept']")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
          
        }
            [Test]
            public static void newUserRegistration()
            {

            By newUserRegistration = By.XPath("//a[@class=\'u-link-body\']");
            driver.FindElement(newUserRegistration).Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 250)");

            Thread.Sleep(2000); 

            By registrationButton = By.XPath("//div[@class=\'no-account\']//a");
            driver.FindElement(registrationButton).Click();

        }
        
          


            }

      
        }



    
