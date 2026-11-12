using BPCalculator;

namespace unittestBP
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BloodPressure bloodPressure = new BloodPressure()
            { Systolic = 70, Diastolic = 40 };

            Assert.AreEqual(BPCategory.Low, bloodPressure.Category);

            bloodPressure.Systolic = 120; 
            bloodPressure.Diastolic = 80;

            Assert.AreEqual(BPCategory.Ideal, bloodPressure.Category);


            bloodPressure.Systolic = 140; 
            bloodPressure.Diastolic = 90;

            Assert.AreEqual(BPCategory.PreHigh, bloodPressure.Category);

            
            bloodPressure.Systolic = 190;
            bloodPressure.Diastolic =100;

            Assert.AreEqual(BPCategory.High, bloodPressure.Category);


        }
    }
}
