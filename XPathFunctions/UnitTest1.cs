using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace XPathFunctions
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindXpathUsingText()
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
        public void FindXpathUsingStartsWith()
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
        public void FindXpathUsingContains()
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

        [TestMethod]
        public void FindXpathUsingNot()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.ankpro.com/Account/Login";
            // full screen
            //driver.Manage().Window.FullScreen();
            Thread.Sleep(2000);

            //click on remember me 
            driver.FindElement(By.XPath(".//input[@type='checkbox' and not(@checked)]")).Click();
            Thread.Sleep(3000);

            driver.Quit();
        }

        [TestMethod]
        public void FindXpathUsingLast()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.ankpro.com/Home/Training";
            // maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // last element on the table
            var lastElement = driver.FindElement(By.XPath(".//tbody/tr[last()]")).Text;
            Console.WriteLine(lastElement);
            Thread.Sleep(3000);

            driver.Quit();
        }

        [TestMethod]
        public void FindXpathUsingLast1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.ankpro.com/Home/Training";
            // maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // second last element on the table
            var lastElement = driver.FindElement(By.XPath(".//tbody/tr[last()-1]")).Text;
            Console.WriteLine(lastElement);
            Thread.Sleep(3000);

            driver.Quit();
        }

        [TestMethod]
        public void FindXpathUsingLast2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.ankpro.com/Home/Training";
            // maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // JQuery on the table
            var lastElement = driver.FindElement(By.XPath(".//tbody/tr[last()-4]")).Text;
            Console.WriteLine(lastElement);
            Thread.Sleep(3000);

            driver.Quit();
        }

        [TestMethod]
        public void FindXpathUsingPosition()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.ankpro.com/Account/Register";
            // maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("(.//input[@type='password'])[position()=1]")).SendKeys("abcde");
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
