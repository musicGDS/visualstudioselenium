using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace visualstudioselenium
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("http:www.google.com");

            //Maximize the window
            driver.Manage().Window.Maximize();

            //Find the Search text box using xpath
            IWebElement element = driver.FindElement(By.XPath("//*[@title='Search']"));

            //Enter some text in search text box
            element.SendKeys("asdf");

            element.SendKeys(Keys.Enter);

            
            IWebElement list = driver.FindElement(By.Id("rso"));

            IWebElement second_link = driver.FindElement(By.CssSelector("#rso:nth-child(2)"));

            second_link.Click();

            
            string wait = Console.ReadLine();
            Console.WriteLine(wait);

            //Close the browser
            driver.Close();
            //driver.Quit();

        }
    }
}

