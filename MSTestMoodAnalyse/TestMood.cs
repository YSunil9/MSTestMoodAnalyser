namespace MSTestMoodAnalyse
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodCheck moodCheck = new MoodCheck();
            string actualResult = moodCheck.ToString();
            Assert.AreEqual("sad",actualResult);
        }
    }
}