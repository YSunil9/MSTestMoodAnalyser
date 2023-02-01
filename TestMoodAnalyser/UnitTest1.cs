using MSTestMoodCheck;

namespace TestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodCheck objt = new MoodCheck("sad");
            string actualResult = objt.GetMood();
            Assert.AreEqual("sad",actualResult);
        }
        [TestMethod]
        public void TestReturnHappy()
        {
            MoodCheck objt = new MoodCheck("Happy");
            string actualResult = objt.GetMood();
            Assert.AreEqual("Happy", actualResult);
        }
        [TestMethod]
        public void TestNullToReturnHappy()
        {
            MoodCheck objt = new MoodCheck("Null");
            string actualResult = objt.GetMood();
            Assert.AreEqual("Happy", actualResult);
        }
    }
}