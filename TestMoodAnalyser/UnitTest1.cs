using MSTestMoodCheck;

namespace TestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    MoodCheck objt = new MoodCheck("sad");
        //    string actualResult = objt.GetMood();
        //    Assert.AreEqual("sad", actualResult);
        //}
        //[TestMethod]
        //public void TestReturnHappy()
        //{
        //    MoodCheck objt = new MoodCheck("Happy");
        //    string actualResult = objt.GetMood();
        //    Assert.AreEqual("Happy", actualResult);
        //}
        [TestMethod]
        public void TestNullToReturnHappy()
        {
            try
            {
                MoodCheck objt = new MoodCheck(null);
                string actualResult = objt.GetMood();
            }
            catch(Exception ex)
            {
                Assert.AreEqual("Null Mood", ex);
            }
        }
    }
}