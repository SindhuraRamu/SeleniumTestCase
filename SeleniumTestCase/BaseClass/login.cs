using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeleniumTestCase
{
    public class login
    {
        //public IWebDriver Driver { get; set; }
            
            public static void loginmethod(IWebDriver driver, String userName, String pwd)
            {
                driver.Navigate().GoToUrl("http://localhost:24129/");
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(3000));

                driver.FindElement(By.Id("Email")).SendKeys("admin@shs.com");
                driver.FindElement(By.Id("Pasword")).SendKeys("Password");
                driver.FindElement(By.XPath("/html/body/div/div/div/div/div/form/fieldset/div[5]/button")).Click();
                NUnit.Framework.Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[1]/div/div/a[2]/span/img")).Displayed,
                   "Login failed, home page did not display");
             }
            public static void logoutmethod(IWebDriver driver)
            {
                // Find an element and define it
                IWebElement elementToClick = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/ul/li/a"));
                // Scroll the browser to the element's Y position
                (driver as IJavaScriptExecutor).ExecuteScript(string.Format("window.scrollTo(0, {0});", elementToClick.Location.Y));
                // Click the element
                elementToClick.Click();
                //Click dropdown to logout.
                //driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/ul/li/a")).Click();
               // Click logout.
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/ul/li/ul/li[2]/a")).Click();
            
            }

    }
}