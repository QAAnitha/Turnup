using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpProject.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            // Select and Click Employee CreateButton
            //IWebElement createbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            //createbutton.Click();
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            Thread.Sleep(1000);
            //Identify NameTextBox and and EnterValidCredential
            //IWebElement nametextbox = driver.FindElement(By.Id("Name"));
            //nametextbox.SendKeys("Anitha");
            driver.FindElement(By.Id("Name")).SendKeys("Anitha");

            Thread.Sleep(1000);
            //Identify UserName TextBox and Enter valid Credential
            driver.FindElement(By.Id("Username")).SendKeys("Anitha123");

            //Identify ContactTextBox and Enter Valid Credentials
            //driver.FindElement(By.Id("ContactDisplay")).Click();


            //Identify EditContact Button and Click
            //driver.FindElement(By.Id("EditContactButton")).Click();
            driver.SwitchTo().Frame(0);

            //Enter Valid Credential For EditTextBox
            driver.FindElement(By.Id("FirstName")).SendKeys("Anitha");
            driver.FindElement(By.Id("LastName")).SendKeys("Varadhan");
            driver.FindElement(By.Id("PreferedName")).SendKeys("Ani");
            driver.FindElement(By.Id("Phone")).SendKeys("0205286235456");
            driver.FindElement(By.Id("Mobile")).SendKeys("0205286235456");
            //driver.Fin


        }
    }
}

