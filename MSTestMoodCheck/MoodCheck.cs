using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestMoodCheck
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
    public class MoodCheck
    {
        public string mood;
        public MoodCheck(string mood)
        {
            this.mood = mood;
        }
        public string GetMood()
        {
            try
            {
                if (this.mood.Contains("sad"))
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
            catch
            {
                Console.WriteLine("Null Value Present");
                return "sad";
            }
        }
    }
}
