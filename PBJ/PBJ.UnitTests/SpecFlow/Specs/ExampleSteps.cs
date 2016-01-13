using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace PBJ.UnitTests.SpecFlow.Specs
{
    [Binding]
    public class ExampleSteps
    {
        private int _number = 0;
        
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _number = _number + p0;

        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //Should add the numbers (business logic stuff)
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(_number, p0);
        }
    }
}
