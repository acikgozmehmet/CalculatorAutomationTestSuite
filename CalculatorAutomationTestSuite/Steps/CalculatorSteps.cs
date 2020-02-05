using CalculatorAutomationTestSuite.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CalculatorAutomationTestSuite.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator = null;

        [Given(@"I have the calculator")]
        public void GivenIHaveTheCalculator()
        {
            calculator = new Calculator();
        }

        [When(@"I enter (.*) into the calculator")]
        public void WhenIEnterIntoTheCalculator(int number)
        {
            calculator.Number = number; 
        }

        [When(@"I press subtraction sign")]
        public void WhenIPressSubtractionSign()
        {
            calculator.Subtract();
        }

        [When(@"I press Equals sign")]
        public void WhenIPressEqualsSign()
        {
            calculator.IsEqualTo();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, calculator.Result);
        }


        [When(@"I press addition sign")]
        public void WhenIPressAdditionSign()
        {
            calculator.Add();
        }

        [When(@"I press multiplication sign")]
        public void WhenIPressMultiplicationSign()
        {
            calculator.Multipy();
        }

        [When(@"I press division sign")]
        public void WhenIPressDivisionSign()
        {
            calculator.Divide();
        }


    } // end of class
}
