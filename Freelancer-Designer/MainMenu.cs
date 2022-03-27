using System;
using System.Collections.Generic;
using FreelaneApplication.AddNewProjects;
using FreelaneApplication.UserSetup;


namespace FreelaneApplication.MainMenu
{
    public class MainMenu
    {
        static void Main(string[] args)
        {
            var newclientProject = new List<NewProjects>();
            var userSetup = new List<UserSetup.UserSetup>();

            bool keepGoing = true;
            while (keepGoing)
            {
                keepGoing = ShowMainMenu(newclientProject, userSetup);
            }
            Console.WriteLine(" Press Any Key to Exit!");
            Console.ReadKey();
            Console.WriteLine(" Program Exited");
        }

        static bool ShowMainMenu(List<NewProjects> plist, List<UserSetup.UserSetup> list)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("Please Select One of the Listed Options");
            Console.WriteLine("1. Create A User Profile");
            Console.WriteLine("2. Create A New Project");
            Console.WriteLine("3. View Current Projects");
            Console.WriteLine("4. See Timeline");
            Console.WriteLine("5. Exit");

            var userChoice = Console.ReadKey().KeyChar;
            Console.WriteLine($" You chose {userChoice}");
            Console.WriteLine("");


            UserSetup.UserSetup UserSetup = new UserSetup.UserSetup();
            NewProjects NewProjects = new NewProjects();


            switch (userChoice)

            {
                case '1':

                    Console.WriteLine("You Have Chosen to Create a User Profile");
                    Console.WriteLine("What is your name?");
                    var UserFullName = Console.ReadLine();
                    UserSetup.userName = UserFullName;

                    Console.WriteLine("What is your email?");
                    var UserEmail = Console.ReadLine();
                    UserSetup.userEmail = UserEmail;

                    Console.WriteLine("What is your address?");
                    var UserAddress = Console.ReadLine();
                    UserSetup.userAddress = UserAddress;

                    Console.WriteLine("What is Your Phone Number?");
                    var UserPhone = Console.ReadLine();
                    UserSetup.userPhone = (UserPhone);

                    Console.WriteLine($"\nUSER INFORMATION:\nName: {UserFullName}\nEmail: {UserEmail}\nAddress: {UserAddress}\nPhone: {UserPhone}");
                    Console.WriteLine("If this information is correct press '1' to save. If it is not, press '2' to delete.");
                    Console.ReadLine();
                    if (userChoice == '1')
                    {
                        list.Add(UserSetup);
                        list.ForEach(UserSetup => Console.Write(UserSetup.ToString()));
                        Console.WriteLine("\nUser added");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("User information is deleted");
                    }

                    break;

                case '2':

                    Console.WriteLine("You Have Chosen to Create a Project");

                    Console.WriteLine("What is your Project Name?");
                    var ProjectName = Console.ReadLine();
                    NewProjects.projectName = ProjectName;

                    Console.WriteLine("What is your fullname?");
                    var ClientName = Console.ReadLine();
                    NewProjects.clientName = ClientName;
                    Console.WriteLine("What is your email?");
                    var ClientEmail = Console.ReadLine();
                    NewProjects.clientEmail = ClientEmail;

                    Console.WriteLine("What was the agreed upon price of your project?(Please write in numerical value)");
                    try
                    {
                        var ProjectPrice = Convert.ToInt32(Console.ReadLine());
                        NewProjects.projectPrice = ProjectPrice;
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
                        NewProjects.projectDeadline = ProjectDeadline;
                    }
                    catch (Exception e)
                    {
                        string errorMessage = e.Message;
                        Console.WriteLine("Please Enter Date in the Correct Format");
                    }

                    Console.WriteLine("Please describe your project in detail?");
                    var ProjectDescription = Console.ReadLine();
                    NewProjects.projectDescription = ProjectDescription;

                    Console.WriteLine("What is the size of your project?");
                    try
                    {
                        var ProjectSize = Convert.ToInt32(Console.ReadLine());
                        NewProjects.projectSize = ProjectSize;
                    }
                    catch (Exception e)
                    {
                        string errorMessage = e.Message;
                        Console.WriteLine("Please Enter A Number");
                    }

                    Console.WriteLine("Are there any concluding notes you would like to make?");
                    var ConcludingNotes = Console.ReadLine();
                    NewProjects.concludingNotes = ConcludingNotes;
                    Console.WriteLine(NewProjects);

                    Console.WriteLine("If this information is correct press '1' to save. If it is not, press '2' to delete.");
                    userChoice = Console.ReadKey().KeyChar;
                    if (userChoice == '1')
                    {
                        plist.Add(NewProjects);
                        plist.ForEach(UserSetup => Console.Write(NewProjects.ToString()));
                        Console.WriteLine("\nYour Project is Added");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("This Project is deleted");
                    }

                    break;


                case '3':

                    Console.WriteLine("You Have Chosen to View Current Projects");
                    Console.WriteLine("Would you like to view your Current Projects? If yes, press '1'. Press '2' to return to the Main Menu.");
                    userChoice = Console.ReadKey().KeyChar;
                    if (userChoice == '1')
                    {
                        plist.ForEach(newclientProject => Console.Write(newclientProject.ToString()));
                    }
                    else if (userChoice == '2')
                    {
                        Console.WriteLine("Return to Main Menu");
                    }

                    break;

                case '4':

                    Console.WriteLine("You Have Chosen to See Timeline");
                    Console.WriteLine("Would You Like To See Your Project Timeline? If yes, press '1.' If no, press '2.'");
                    userChoice = Console.ReadKey().KeyChar;
                    if (userChoice == '1')
                    {
                        plist.ForEach(newclientProject => Console.WriteLine(newclientProject.ToArray()));
                        break;
                    }
                    else if (userChoice == '2')
                    {
                        Console.WriteLine("Return to Main Menu");
                        break;
                    }
                    return false;

                default:
                    Console.WriteLine($"{userChoice} was not valid. Please choose a valid number between 1-4 ");
                    break;
            }

            return true;
        }
    }
}