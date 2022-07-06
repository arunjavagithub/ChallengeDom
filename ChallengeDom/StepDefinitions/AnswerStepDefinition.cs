using ChallengeDom.CommonMethods;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ChallengeDom.StepDefinitions
{
    [Binding]
    public class AnswerStepDefinition  
    {
        AnswerElements answerElements;
        CommonValidation commonValidation;
        String oldAnswer;
        String newAnswer;

        public AnswerStepDefinition(DriverHelper driverHelper)
        {
            commonValidation = new CommonValidation(driverHelper.Driver);
            answerElements = new AnswerElements(driverHelper.Driver);
        }

        [Given(@"get the '([^']*)' from the landing page")]
        public void GivenGetTheFromTheLandingPage(string oldanswer)
        {
            
            oldAnswer = answerElements.OldAnswer();
        }

        [When(@"refresh the page '([^']*)' is displayed")]
        public void WhenRefreshThePageIsDisplayed(string newanswer)
        {
            answerElements.RefreshPage();
            newAnswer = answerElements.NewAnswer();
        }


        [Then(@"validate the old answer and new answer")]
        public void ThenValidateTheOldAnswerAndNewAnswer()
        {
            Assert.AreNotEqual(oldAnswer, newAnswer);
        }
    }
}
