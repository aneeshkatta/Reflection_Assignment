using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyserAssignmentuc2
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to reflection Demo");
            string message = "i am happy";
            MoodAnalyserinfo newmoodinfo = new MoodAnalyserinfo(message);

            ReflectionUc2.ReflectionTest();
            Console.ReadKey();
        }
    }
}