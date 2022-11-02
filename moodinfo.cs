using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyserAssignmentUC1
{
    class moodinfo
    {
        
        public string message { get; set; }
       
      
        public moodinfo(string message)
        {
            
            this.message = message;
        }

        
        public string analysemood(string message)
        {
            Console.WriteLine("message input is " + this.message);
            if (message.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }

        }
        
    }
    
}
    
      
 


