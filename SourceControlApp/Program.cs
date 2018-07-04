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
            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine("My profession is " + profession);
            pickYourFavoriteTypeOfVehicle();
            Console.Write("Thank you, GoodBye " + name);
            Console.ReadKey();
        }

        public static void pickYourFavoriteTypeOfVehicle()
        {
            // code for the response from the user of
            // what is there favorite type of vehical
            string favoriteVehicleType = "";

            Console.WriteLine();
            Console.Write("What is your favorite type of vehical? ");
            favoriteVehicleType = Convert.ToString(Console.ReadLine());
            switch (favoriteVehicleType)
            {
                case "1":
                    favoriteVehicleType = "Car";
                    break;
                case "2":
                    favoriteVehicleType = "Van";
                    break;
                case "3":
                    favoriteVehicleType = "Truck";
                    break;
                case "4":
                    favoriteVehicleType = "SUV";
                    break;
                default:
                    favoriteVehicleType = "bicycle";
                    break;
            }
            Console.WriteLine("My favorite type of vehical is a " + favoriteVehicleType);
            Console.WriteLine();
            
        }
    }
}
