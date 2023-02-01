namespace MSTestMoodCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodCheck obj = new MoodCheck("sad");
            obj.GetMood();
        }
    }
}