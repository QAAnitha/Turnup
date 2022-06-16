using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpProject.Pages;
using TurnUpProject.Utilities;

namespace TurnUpProject.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Test :CommonDriver
    {
        //Page Object initialization and Definition

        HomePage homePageObj = new HomePage();
        EmployeePage employeepageobj = new EmployeePage();
       

        [Test,Order(1),Description("Create Employee using Valid Credentials")]
        public void CreateEmployee()
        {
            homePageObj.GoToEmployeePage (driver);
            employeepageobj.CreateEmployee(driver);
        }


    }
}
