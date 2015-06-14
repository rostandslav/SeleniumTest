using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
    [TestClass]
    public class TestSuite1
    {
        FirefoxDriver firefox;
        //InternetExplorerDriver ie;

        [TestMethod]
        public void TestMethod1()
        {
            firefox = new FirefoxDriver();
            firefox.Navigate().GoToUrl("https://modulbank.ru/");
            Assert.AreEqual("Modulbank: умный банк для предпринимателей", firefox.Title);

            /*ie = new InternetExplorerDriver();
            ie.Navigate().GoToUrl("https://modulbank.ru/");
            Assert.AreEqual("Modulbank: умный банк для предпринимателей", ie.Title);*/
        }

        [TestCleanup]
        public void TearDown()
        {
            firefox.Quit();
            //ie.Quit();
        }
    }
}
