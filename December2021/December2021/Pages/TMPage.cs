using December2021.Utilities;
using NUnit.Framework;
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
            priceTextbox.SendKeys("12");

            //Click on Save Button 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(4000);
            //Waitclas.WaitTobeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);


            // Click on go to last page button 

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(3000);
            

            //Option 1
            //Assert.That(actualCode.Text == "Test codetextbox", "Actual code and expected code do not match.");
            //Assert.That(actualTypeCode.Text == "M", "Actual typecode and expected code do not match.");
            //Assert.That(actualDescription.Text == "description", "Actual description and expected code do not match.");
            //Assert.That(actualPrice.Text == "$12.00", "Actual price and expected code do not match.");

            //Option 2
            //if (actualCode.Text == "Test codetextbox")
            //{
            //    Assert.Pass("Material record has been created successfully, test passed");

            //}

            //else
            //{
            //    Assert.Fail("Test failed");
            //}

        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }

        public string GetTypeCode(IWebDriver driver)
        {
            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return actualTypeCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualPrice.Text;
        }


        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(2000);
            // Click on go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            goToLastPageButton.Click();

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "Test codetextbox")
            {
                //Click on edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }
            else
            {
                Assert.Fail("Record hasn't been found. Record not edited");
            }

           

            // Edit code 
            IWebElement editCode = driver.FindElement(By.Id("Code"));
            driver.FindElement(By.Id("Code")).Clear();
            editCode.SendKeys("Hello Coding");

            // Edit Description
            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            driver.FindElement(By.Id("Description")).Clear();
            editDescription.SendKeys("Hello Description 2");

            // Clieck on Save button
            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(4000);

            // Click on go to last page button
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            goToLastPageButton1.Click();
            Thread.Sleep(2000);

            // Assertion 
            IWebElement CreatedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement CreatedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement CreatedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            //Assertion 
            Assert.That(CreatedCode.Text == "Hello Coding", "Not edited");
            Assert.That(CreatedTypeCode.Text == "M", "Not edited");
            Assert.That(CreatedDescription.Text == "Hello Description 2", "Not edited");





        }

        public void DeleteTM(IWebDriver driver)
        {

           Thread.Sleep(2000);
            // Click on go to last Page Button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            goToLastPageButton.Click();

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "Hello Coding")
            {
                // Click on Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(3000);

                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted");
            }

            // Assertion of deleted record
            IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            goToLastPageBtn1.Click();
            Thread.Sleep(3000);

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            //Assertion 
            Assert.That(editedCode.Text == "Hello Coding", "Not delted");
            Assert.That(editedDescription.Text == "Hello Description 2", "Not deleted");
            Assert.That(editedPrice.Text == "$12.00", "Not deleted");


        }

    }
}
