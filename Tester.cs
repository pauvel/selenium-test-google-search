using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    public class Tester
    {
        private IWebDriver Driver;

        [SetUp]
        public Tester StartBrowser(){
            Driver = new ChromeDriver();
            return this;
        }

        [Test]
        public Tester RunTest(string url){
            Driver.Url = url;
            Driver.Manage().Window.Maximize();
            SearchInSite();
            return this;
        }

        [TearDown]
        public void CloseBrowser(){
            this.Driver.Close();
        }

        private void SearchInSite(){
            var searchBox = this.Driver.FindElement(By.CssSelector("input[type=text]"));
            searchBox.SendKeys("Paul Guadalupe Veliz Lopez Linkedin");
            searchBox.Submit();
        }

        public void Wait(int milliseconds){
            Thread.Sleep(milliseconds);
        }
    }
}