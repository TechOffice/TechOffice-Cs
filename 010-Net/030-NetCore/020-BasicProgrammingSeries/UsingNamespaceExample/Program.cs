using System;
using com.techoffice.test.testpackage;

namespace com.techoffice.test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Test test = new Test();
			test.sayHi();
        }
    }
}
