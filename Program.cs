﻿
using ModeAnalyserAssignmentuc3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ModeAnalyserAssignmentUC3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to reflection Demo");
            string message = "i am happy";
            MoodAnalyserinfo1 moodinfo = new MoodAnalyserinfo1(message);

            Reflection_UC3.ReflectionTest();
            Console.ReadKey();
        }
    }
}