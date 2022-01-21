using December2021.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December2021.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // Go to TM page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            Waitclas.WaitTobeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            // Navigate to Employee Page
        }
    }
}
