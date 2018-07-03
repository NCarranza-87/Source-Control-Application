using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*******************************************************************************************************
            For this assignment you will need to create a project and use source control. We will be using GitHub

            You will need to create a project repository for this project.Our goal is to get familiar with checking 
            in code(commit), and be familiar with the GitHub website portal for your projects. 
            I recommend you also explore GitHub issues for your project and branching.

            Minimum Requirements:

            You must do at least 3 commits to the project repository(you don't have to create a useful application 
            for this first assignment. Submit a direct link to your project repository
            ******************************************************************************************************/

            string name = "";
            int age = 0;
            string profession = "";

            Console.Write("Please enter your name: ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your profession: ");
            profession = Convert.ToString(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("My name is " + name + ".");
            Console.Write("I am " + age + " years old.");
            Console.Write("My profession is " + profession);
            Console.ReadKey();
        }
    }
}
