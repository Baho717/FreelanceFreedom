using System;
using System.Collections.Generic;
using FreelaneApplication.AddNewProjects;
using FreelaneApplication.ArchivedProjects;
using FreelaneApplication.CurrentProjects;

namespace FreelaneApplication.MainMenu
{
    public class MainMenu
    {
        static void Main(string[] args)
        {
            var newclientProject = new List<NewProjects>();

            {
                bool keepGoing = true;
                while (keepGoing)

                {
                    keepGoing = MainMenu(newclientProject);
                }
                Console.WriteLine(" Press any key to exit!");
                Console.ReadKey();
                Console.WriteLine(" Program Exited");


                static bool MainMenu(List<NewProjects> plist, List<NewProjects> newclientProject)
                {
                    Console.WriteLine("Main Menu:");
                    Console.WriteLine("Please Select One of the listed options");
                    Console.WriteLine("1. Create A New Project");
                    Console.WriteLine("2. View Current Projects");
                    Console.WriteLine("3. Exit");

                    var userChoice = Console.ReadKey().KeyChar;
                    Console.WriteLine($" You chose {userChoice}");
                    Console.WriteLine("");

                    NewProjects NewProjects = new NewProjects();


                    switch (userChoice)

                    {
                        case '1':

                            Console.WriteLine("What is the name of your project?");
                            var ProjectName = Console.ReadLine();
                            NewProjects.ProjectName = ProjectName;

                            Console.WriteLine("What is your fullname?");
                            var ClientName = Console.ReadLine();
                            NewProjects.ClientName = ClientName;

                            Console.WriteLine("What is your email?");
                            var ClientEmail = Console.ReadLine();
                            NewProjects.ClientEmail = ClientEmail;

                            Console.WriteLine("What was the agreed upon price of your project?(Please write in numerical value)");
                            try
                            {
                                var ProjectPrice = Convert.ToInt32(Console.ReadLine());
                                NewProjects.ProjectPrice = ProjectPrice;
                            }
                            catch (Exception e)
                            {
                                string errorMessage = e.Message;
                                Console.WriteLine("Please Enter A Number");
                            }

                            Console.WriteLine("When is your project due? Example: (09/08/2021)");
                            try
                            {
                                var ProjectDeadline = Convert.ToDateTime(Console.ReadLine());
                                NewProjects.ProjectDeadline = ProjectDeadline;
                            }
                            catch (Exception e)
                            {
                                string errorMessage = e.Message;
                                Console.WriteLine("Please Enter Date in the Correct Format");
                            }

                            Console.WriteLine("Please describe your project in detail?");
                            var ProjectDescription = Console.ReadLine();
                            NewProjects.ProjectDescription = ProjectDescription;

                            Console.WriteLine("What is the size of your project?");
                            try
                            {
                                var ProjectSize = Convert.ToInt32(Console.ReadLine());
                                NewProjects.ProjectSize = ProjectSize;
                            }
                            catch (Exception e)
                            {
                                string errorMessage = e.Message;
                                Console.WriteLine("Please Enter A Number");
                            }

                            Console.WriteLine("Are there any concluding notes you would like to make?");
                            var ConcludingNotes = Console.ReadLine();
                            NewProjects.ConcludingNotes = ConcludingNotes;

                            Console.WriteLine("If this information is correct press 'Y' to save. If it is not, press 'N' to delete.");
                            if (userChoice == 'Y')
                            {
                                plist.Add(NewProjects);
                                Console.WriteLine("Your Project Has Been Added");
                            }
                            else
                            {
                                Console.WriteLine("Project is deleted");
                            }

                            break;


                        case '2':

                            Console.WriteLine("You Have Chosen to View Current Projects");

                            Console.WriteLine($"{newclientProject}");


                            break;
                        case '3':

                            return false;

                        default:
                            Console.WriteLine($"{userChoice} was not valid. Please choose a valid number between 1-4 ");
                            break;
                    }

                    return true;
                }
            }
        }
    }
}
    