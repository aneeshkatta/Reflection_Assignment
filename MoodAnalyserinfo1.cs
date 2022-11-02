using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyserAssignmentuc3
{
    public class MoodAnalyserinfo1
    {
        public string message { get; set; }
        public MoodAnalyserinfo1(string message)
        {
            this.message = message;
        }
        public string analyseMood(string message)
        {

            if (message.Equals(string.Empty))
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
            }
            else if (message.Contains("Sad"))
            { return "Sad"; }
            else if (message.Contains("Null"))
            { throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.INVALID_MOOD, "INVALID_MOOD"); }
            else
            {
                return "Happy";
            }

        }




    }
}
