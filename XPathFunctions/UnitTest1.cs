using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace XPathFunctions
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindXpathByText()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://techexpozed.co.nz";
            // full screen
            driver.Manage().Window.FullScreen();
            Thread.Sleep(3000);

            //scroll down the window
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript("window.scrollBy(0,450)");

            //find xpath by text 
            var str1 = driver.FindElement(By.XPath(".//h6[text()='Our company']")).Text;
            Console.WriteLine(str1);
        }

        [TestMethod]
        public void FindXpathByStartsWith()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.ankpro.com/Account/Login";
            // full screen
            driver.Manage().Window.FullScreen();
            Thread.Sleep(3000);

            //click on remember me
            driver.FindElement(By.XPath(".//input[starts-with(@id, 'Rem')]")).Click();
            Thread.Sleep(3000);

            driver.Quit();
        }

        [TestMethod]
        public void FindXpathByContains()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.ankpro.com/Account/Login";
            // full screen
            driver.Manage().Window.FullScreen();
            Thread.Sleep(3000);

            //click on remember me
            driver.FindElement(By.XPath(".//input[contains(@id, 'Me')]")).Click();
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
