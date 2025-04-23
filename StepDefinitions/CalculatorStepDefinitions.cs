using NUnit.Framework;

namespace ReqnrollProject2.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly Calculator calculator = new Calculator();
        private int _result;

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {

            calculator.FirstNumber = number;
            
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int secondnumber)
        {
            calculator.SecondNumber = secondnumber;
        
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = calculator.Addition();
        
        }

        [When("the two numbers are subtracted")]

        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = calculator.Subtraction();
        }

        
        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = calculator.Multiplication();
        }

        [When("the two numbers are divided")]
        
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = calculator.Division();
        }


        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.That(_result, Is.EqualTo(result));
        
        }
    }
}
