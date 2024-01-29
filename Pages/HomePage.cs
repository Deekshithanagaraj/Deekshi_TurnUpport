using Deekshi_TurnUpport.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deekshi_TurnUpport.Pages
{
    public class HomePage
    {
        private object logoutForm;

        public void GoTOTMPage(IWebDriver driver) 
        {
            //Navigate to Time & Material module (Click on Administration -> Time & Material link)
            IWebElement administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationdropdown.Click();

            IWebElement tmOption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
            tmOption.Click();
        }

        public void verifyLoggedInUser(IWebDriver driver) 
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='logoutForm']/ul/li/a", 5);

            //Thread.Sleep(5000);

            //Check if user has logged in successfully
            IWebElement verificationText = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (verificationText.Text != "hello Hari")

            {
                Console.WriteLine("User logged in Successfully");
            }
            else
            {
                Console.WriteLine("User hasn't logged in.");
            }
        }
    }
}
