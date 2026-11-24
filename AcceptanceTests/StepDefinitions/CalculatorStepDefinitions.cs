using System;
using BPCalculator;
using Reqnroll;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        BloodPressure bp = new BloodPressure();

        [Given("the systolic value is {int}")]
        public void GivenTheSystolicValueIs(int p0)
        {
            bp.Systolic = p0;
        }

        [Given("the diastolic value is {int}")]
        public void GivenTheDiastolicValueIs(int p0)
        {
            bp.Diastolic = p0;
        }

        [Then("the result should be low")]
        public void ThenTheResultShouldBeLow()
        {
            Assert.AreEqual(BPCategory.Low, bp.Category);
        }

    }
}
