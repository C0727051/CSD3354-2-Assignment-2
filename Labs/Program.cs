using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    // Student ID:Manveer Singh Walia  Student ID:C0727051
    //Student ID:Jashandeep Singh Dhillon  Student ID:C0725713
    // Assignment2
    // March 7,2019
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();


        }


    }
    public delegate void MyDelegate();
    public class DelegateExercises

    {

        void Method1()

        {

            System.Console.WriteLine("Method1");

        }



        public void Method3()

        {

            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
            System.Console.WriteLine(myDelegate.ToString());


        }




    }
}