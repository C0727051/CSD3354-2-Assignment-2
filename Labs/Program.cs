using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class DelegateExercises
    {
        // Student ID:Manveer Singh Walia  Student ID:C0727051
        //Student ID:Jashandeep Singh Dhillon  Student ID:C0725713
        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
