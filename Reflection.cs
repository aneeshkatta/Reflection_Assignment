using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyserAssignmentuc3
{
     class Reflection_UC3
    {
        private static IEnumerable<MemberInfo> members;

        public static void ReflectionTest()
        {

            Type type = Type.GetType("ModeAnalyserAssignmentuc3.MoodAnalyserinfo1");
            Console.WriteLine("Full Name :{0}", type.FullName);
            Console.WriteLine("Class name is : {0}", type.Name);
            Console.WriteLine("Methods in above class are:");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Namespace + " " + method.Name);
            }
            Console.WriteLine("Properties in above class are:");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine("Constructors in above class are:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            Console.WriteLine("members in above class are:");
            MemberInfo[] members = type.GetMembers();
            foreach (MemberInfo member in members)
            {
                Console.WriteLine(members.ToString());
            }
        }
    }
}
