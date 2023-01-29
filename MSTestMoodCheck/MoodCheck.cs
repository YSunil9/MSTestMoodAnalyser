using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestMoodCheck
{
    public class MoodCheck
    {
        public string GetMood(string Mood)
        {
            if (Mood.Contains("sad"))
            {
                Console.WriteLine("Input Contains Sad");
                return "Sad";
            }
            else
            {
                Console.WriteLine("Input Contains Happy");
                return "Happy";
            }
        }
    }
}
