using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ChallengeDom
{
    [Binding]
    public sealed class Hooks1 : DriverHelper
    {
        private DriverHelper _driverHelper;

        public Hooks1(DriverHelper driverHelper)
        {
            this._driverHelper = driverHelper;   
        }

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
           _driverHelper.Driver = new ChromeDriver(@"C:\Users\Poojitha\source\repos\ChallengeDom\ChallengeDom\bin\Debug\net6.0");
           _driverHelper.Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/challenging_dom");
            
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Close();
            _driverHelper.Driver.Quit();
        }
    }
}