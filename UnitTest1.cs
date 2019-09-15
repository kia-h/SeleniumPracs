using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Selenium_1.Configuration;
using Selenium_1.Interfaces;

namespace Selenium_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver  cd = new ChromeDriver();
            
            cd.Navigate().GoToUrl("http://way2automation.com/angularjs-protractor/banking/#/login");
            cd.Close();
            cd.Quit();
        }

        [TestMethod]
        public void TestMethod2()
        {
            IConfig reader = new AppConfigReader();
            string b= ConfigurationManager.AppSettings.Get("browser");
            Console.WriteLine("read from app settings: "+b);
            Console.WriteLine("read from enum: "+ BrowserType.chrome);
        }
    }
}
