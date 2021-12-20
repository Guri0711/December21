using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December2021.Pages
{
   public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on Create New Button 
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Select Material from TypeCode dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            Thread.Sleep(2000);

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materialOption.Click();


            // Identify the Code Textbox and input a code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Test codetextbox");

            // Identify the Description Textbox and input a description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("description");

            // Identify the Price Textbox and input a price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("3021");

            //Click on Save Button 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(2000);

            // Click on go to last page button 

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            
            // Check if record created is present in the table and has expected value 
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualCode.Text == "Test codetextbox")
            {
                Console.WriteLine("Material record has been created successfully, test passed");

            }

            else
            {
                Console.WriteLine("Test failed");
            }

        }

        public void EditTM(IWebDriver driver)
        {

            // Click on Edit Button 
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            // Edit existing data
            IWebElement editCode = driver.FindElement(By.Id("Code"));
            driver.FindElement(By.Id("Code")).Clear();
            editCode.SendKeys("Hello Coding");

            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            driver.FindElement(By.Id("Description")).Clear();
            editDescription.SendKeys("Hello Description 2");

            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();

            
        }

        public void DeleteTM(IWebDriver driver)
        {

            // Click on Delete Button 
            Thread.Sleep(2000);

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
            deleteButton.Click();

            // Click on OK
            driver.SwitchTo().Alert().Accept();
            
        }

    }
}
