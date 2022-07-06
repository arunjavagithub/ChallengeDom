using ChallengeDom.CommonMethods;
using System;
using TechTalk.SpecFlow;

namespace ChallengeDom.StepDefinitions
{
    [Binding]
    public class ButtonElementStepDefinitions 
    {
       
        CommonValidation commonValidation;
        public ButtonElementStepDefinitions(DriverHelper driverHelper)
        {
            
            commonValidation = new CommonValidation(driverHelper.Driver);
        }


        [Given(@"check whether landing page is loaded properly")]
        public void GivenCheckWhetherLandingPageIsLoadedProperly()
        {
            try
            {
                commonValidation.verifyName();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [When(@"the button element is clicked")]
        public void WhenTheButtonElementIsClicked()
        {
            try
            {
                commonValidation.ClickButtonOne();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [Then(@"alert button should be displayed")]
        public void ThenAlertButtonShouldBeDisplayed()
        {
            try
            {
                commonValidation.validateButtonAlert();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [When(@"the alert button element is clicked")]
        public void WhenTheAlertButtonElementIsClicked()
        {
            try
            {
                commonValidation.ClickButtonAlert();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        [Then(@"success button is displayed")]
        public void ThenSuccessButtonIsDisplayed()
        {
            try
            {
                commonValidation.validateButtonSuccess();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        [When(@"the success button element is clicked")]
        public void WhenTheSuccessButtonElementIsClicked()
        {
            try
            {
                commonValidation.ClickButtonSuccess();

            }
            catch
            {
                throw new Exception("Success Button was not clicked");
            }
            
        }


        [Then(@"button element is displayed")]
        public void ThenButtonElementIsDisplayed()
        {
            try
            {
                commonValidation.validateButtonOne();

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }


    }
}
