using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDom.CommonMethods
{
    public class AnswerElements
    {
        private IWebDriver Driver;

        public AnswerElements(IWebDriver driver)
        {
            Driver = driver;
        }

 
        public string OldAnswer()
        {
            String oldAnswerXpath = Driver.FindElement(By.XPath("//div[@id='content']/script")).GetAttribute("innerHTML");
            return oldAnswerXpath;
            
        }

        public string NewAnswer()
        {

            String newAnswerXpath = Driver.FindElement(By.XPath("//div[@id='content']/script")).GetAttribute("innerHTML");
            return newAnswerXpath;
        }

        public void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }
    }
}
