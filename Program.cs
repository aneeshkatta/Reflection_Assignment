
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ModeAnalyserAssignmentUC1
{
   class Program
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to reflection Demo");
            string message = "i am happy";
            moodinfo newmoodinfo = new moodinfo(message);
          
            moodref.ReflectionTest();
            Console.ReadKey();
        }
    }
}