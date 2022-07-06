using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDom.CommonMethods
{
    public class CommonValidation
    {
        private IWebDriver Driver;

        public CommonValidation(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement button => Driver.FindElement(By.XPath("//*[@class='large-2 columns']/child::a[1]"));
        IWebElement title => Driver.FindElement(By.XPath("//h3[text()='Challenging DOM']"));

        IWebElement buttonAlert => Driver.FindElement(By.XPath("//*[@class='large-2 columns']/child::a[2]"));

        IWebElement buttonSuccess => Driver.FindElement(By.XPath("//*[@class='large-2 columns']/child::a[3]"));

        public void verifyName()
        {
            
            Assert.AreEqual(title.Text, "Challenging DOM", "Title does not match");
        }

        public void ClickButtonOne()
        {
            button.Click();
            
        }
        public string validateButtonOne()
        {
            var buttonText = button.Text;
            return buttonText;

        }

        public void ClickButtonAlert()
        {
            buttonAlert.Click();
        }
        public void validateButtonAlert()
        {
           
            Assert.That(buttonAlert.Displayed, "First Button is displayed");
        }
        public void ClickButtonSuccess()
        {
            buttonSuccess.Click();
        }
        public void validateButtonSuccess()
        {
           
            Assert.That(buttonSuccess.Displayed,"First Button is displayed");
        }
    }
}
