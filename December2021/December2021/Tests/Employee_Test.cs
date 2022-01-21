using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December2021.Tests
{
    [TestFixture]
    [Parallelizable]
    class Employee_Test : CommonDriver
    {

        [Test, Order(1), Description("Check if user is able to new employee record")]
        public void CreateEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageob = new HomePage();
            homePageob.GoToTMPage(driver);

            // EmployeePage object intialization and defintion
            EmployeePage employeePageob = new EmployeePage();
            employeePageob.CreateEmployee(driver);

        }
        [Test, Order(2), Description("Check if user is able to edit existed employee record")]
        public void EditEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageob = new HomePage();
            homePageob.GoToTMPage(driver);

            // EmployeePage object intialization and defintion
            EmployeePage employeePageob = new EmployeePage();
            employeePageob.EditEmployee(driver);

        }
        [Test, Order(3), Description("Check if user is able to delete existed employee record")]
        public void DeleteEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageob = new HomePage();
            homePageob.GoToTMPage(driver);


            // TMPage object intialization and defintion
            EmployeePage employeePageob = new EmployeePage();
            employeePageob.DeleteEmployee(driver);

        }

    }

}

