using MSTestMoodCheck;

namespace TestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodCheck objt = new MoodCheck();
            string actualResult = objt.GetMood("sad");
            Assert.AreEqual("sad",actualResult);
        }
    }
}