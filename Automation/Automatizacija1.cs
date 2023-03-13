
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V108.CSS;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace ClassLibrary3
{
    public class Class1

    {
        static WebDriver driver = new ChromeDriver();


        [SetUp]
        public static void SETUP()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/text-box";