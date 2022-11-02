using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyserAssignmentuc2
{
    public class MoodAnalyserinfo
    {
        public string message { get; set; }
        public MoodAnalyserinfo(string message)
        {
            this.message = message;
        }
        public string analyseMood(string message)
        {

            if (message.Equals(string.Empty))
            {
                return "Mood should not be empty";
            }
            else if (message.Contains("Sad"))
            { return "Sad"; }
            else if (message.Contains("Null"))
            { return "Happy"; }
            else
            {
                return "Happy";
            }

        }




    }

}
