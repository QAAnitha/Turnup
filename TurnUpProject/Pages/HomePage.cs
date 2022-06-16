using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpProject.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // After Login Successfully click on Administration tab
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();

            // select Time & Materials from dropdown list
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }

       public void GoToEmployeePage(IWebDriver driver)
        {
            //After Login Sucessfully  Click on Administration Tab
            IWebElement abministrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            abministrationTab.Click();

            // IWebElement abministrationTab = driver.FindElement(By.LinkText("Administration ");LinkText <a heref="#" select copy and paste it will show Administration"
            //abministrationTab.Click();



            //Select Employees from Dropdown List
            IWebElement employeesdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeesdropdown.Click();

        }
    }
}