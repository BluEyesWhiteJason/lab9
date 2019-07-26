using System;
using System.Collections.Generic;


namespace Lab9
{
	class Program
	{
		static void Main(string[] args)
		{
			//create student objects
			Student s1 = new Student("Dakota", "Kent City", "Pho", "Dancer");
			Student s2 = new Student("Joshua", "Grand Rapids", "Cheese Tortellini", "Human");
			Student s3 = new Student("Tommy", "Raleigh", "Chicken Curry", "Dancer");
			Student s4 = new Student("James", "Grand Rapids", "Burgers and Fries", "Dancer");
			Student s5 = new Student("Maricela", "Morelia", "Tacos", "Human");
			Student s6 = new Student("Bob", "Detroit", "Burgers", "Dancer");
			Student s7 = new Student("KymVe", "Grand Rapids", "Sushi", "Dancer");
			Student s8 = new Student("Flaka", "Pristina", "Thai", "Human");


			// Place into list
			List<Student> students = new List<Student> { s1, s2, s3, s4, s5, s6, s7, s8 };


			// Get input on which student, catch exceptions
			Console.WriteLine("Welcome to our C# class.");

			do
			{
                Console.WriteLine("Would you like to learn about a student, or add a new one?");
				Console.WriteLine("Enter 'new' or 'learn'");
                string task = Console.ReadLine();
                if (task == "new")
                {
                    //TODO reject bad input
                    Console.WriteLine("What is the new students' name?");
                    string name = Console.ReadLine();

                    Console.WriteLine("Hometown?");
                    string hometown = Console.ReadLine();

                    Console.WriteLine("Favorite food?");
                    string food = Console.ReadLine();

                    string dancer = "";
                    while (dancer != "dancer" && dancer != "human" && dancer != "Dancer" && dancer != "Dancer")
                    {
                        Console.WriteLine("Are they human? Or are they dancer?");

                        dancer = Console.ReadLine();
                    }
                    

                   

                    Student s9 = new Student(name, hometown, food, dancer);

                    students.Add(s9);

                    Console.WriteLine("Alright, I have made it so.");

                }
                else if (task == "learn")
                {
                    Console.WriteLine("Which student would you like to learn more about ? (enter a number 1 - {0}):", students.Count);
                    for (int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + students[i].GetName());
                    }

                    int input = 0;
                    while (true) //idea for loop from stack overflow: https://stackoverflow.com/questions/7920657/repeating-a-function-in-c-sharp-until-it-no-longer-throws-an-exception
                    {
                        try
                        {
                            input = int.Parse(Console.ReadLine());
                            Console.WriteLine("What about {0} would you like to know?", students[input - 1].GetName());
                            Console.WriteLine("Try 'hometown' for hometown , 'food' for favorite food, ");
                            Console.WriteLine("or 'existence' for whether they are human, or they are dancer");
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid input, please enter a number");
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.WriteLine("Invalid input, please enter a number from 1-{0}", students.Count);
                        }
                    }

                    // get what info user wants, ask until input valid

                    while (true)
                    {
                        string info = Console.ReadLine();

                        if (info == "hometown")
                        {
                            Console.WriteLine("{0} is from {1}", students[input - 1].GetName(), students[input - 1].GetHometown());
                            break;
                        }
                        else if (info == "food")
                        {
                            Console.WriteLine("{0}'s favorite food is {1}", students[input - 1].GetName(), students[input - 1].GetFavoriteFood());
                            break;

                        }
                        else if (info == "existence")
                        {
                            Console.WriteLine("{0} is {1}", students[input - 1].GetName(), students[input - 1].GetHumanDancer());
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, please enter either 'hometown', 'food', or 'existence'");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
			}
			while (Proceed() == true);
		}

		public static bool Proceed()
		{
			Console.WriteLine("Learn about a different student? y/n : ");
			string contEnter = Console.ReadLine();

			// Check if they want to continue
			if (contEnter == "y" || contEnter == "Y")
			{
				return true;
			}
			else if (contEnter == "n" || contEnter == "N")
			{
				return false;
			}
			else
			{
				Console.WriteLine("Invalid input, please enter y or n");
				Proceed();
				return false;
			}
		}
	}
}