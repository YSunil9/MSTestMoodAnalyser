using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestMoodCheck
{
    public class MoodCheck
    {
        public string mood;
        public MoodCheck(string mood)
        {
            this.mood = mood;
        }
        public string GetMood()
        {
            if (mood.Contains("sad"))
            {
                Console.WriteLine("Input Contains Sad");
                return "sad";
            }
            else
            {
                Console.WriteLine("Input Contains Happy");
                return "Happy";
            }
        }
    }
}
