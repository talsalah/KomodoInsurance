using _09_KomodoInsurance__Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KomodoInsurance_Console
{
    class ProgramUI
    {
        private DeveloperRepo _listOfDeveloper = new DeveloperRepo();
       // private object Developer;

        public void Run()
        {
            seedContentList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {



                //Display our options to the user
                Console.WriteLine("Select a menue option:\n" +
                    "1. Create New Developer\n" +
                    "2. Display ALL Developer \n" +
                    "3. View Developer by Employee ID \n" +
                    "4. View Developer By Name \n" +
                    "5. Update Exisiting Developer \n" +
                    "6. Delete Exisiting Developer\n" +
                    "7. Creat New Team \n" +
                    "8. View All Teams \n" +
                    "9. Update a Team \n" +
                    "10. Exit");
                //Get the user's input and act accordingly
                string input = Console.ReadLine();

                //Evaluate the user's input and act accordingly


                switch (input)
                {
                    case "1":
                        //Create new contrent
                        CreateNewDeveloper();
                        break;
                    case "2":
                        // View All Developer
                        DisplayAllDeveloper();
                        break;
                    case "3":
                        // View All Content
                        ViewDeveloperByIdNumber();
                        break;
                    case "4":
                        // View Content By Title
                        ViewDeveloperByName();
                        break;
                    case "5":
                        // Update Exisiting Content 
                        UpdateExistingDeveloper();
                        break;
                    case "6":
                        DeleteExisitingDeveloper();

                        // Delete Exisiting Content 

                        break;
                    case "7":

                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;




                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        /*private void DisplayDeveloperbyID()
        {
            throw new NotImplementedException();
        }*/

        private void CreateNewDeveloper()
        {
            /*Console.Clear();*/
            Developer newContent = new Developer();
            //Name
            Console.WriteLine("Enter the Name of the Developer:");
            newContent.Name = Console.ReadLine();

            //ID Rating
            Console.WriteLine("Enter the Developer ID Number:");
            /*newContent.IdNumber = Console.ReadLine();*/

            string starAsIntiger = Console.ReadLine();
            //newContent.IdNumber = int.Parse(starAsIntiger);
            int Idnumber;
            Int32.TryParse(starAsIntiger, out Idnumber);



            //Is has Access
            Console.WriteLine("Is this Developer has an access to ? (y/n)");
            string HaveAccess = Console.ReadLine().ToLower();
            if (HaveAccess == "y")
            {
                newContent.HaveAccess = true;
            }
            else
            {
                newContent.HaveAccess = false;
            }
        }


        private void DisplayAllDeveloper()
        {
            Console.Clear();
            List<Developer> listOfContent = _listOfDeveloper.GetDeveloperList();

            foreach (Developer content in listOfContent)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"IDNumber:{content.IdNumber} \n" +
                    $"HaveAccess:{content.HaveAccess}" 
                    );


            }

        }


        private void ViewDeveloperByIdNumber()
        {

            Console.Clear();
       //     Developer content = new Developer();
            Console.WriteLine("Enter the Develpoer IdNumber:");
            string input = Console.ReadLine();
            int inputAsInt = int.Parse(input);
            Developer content = _listOfDeveloper.GetDeveloperByIdNumber(inputAsInt);

            if (inputAsInt == content.IdNumber)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"IDNumber:{content.IdNumber} \n" +
                    $"HaveAccess:{content.HaveAccess}");


            }
            else
            {

                Console.WriteLine("Please Enter a valid Developer ID:");
            }

            Console.ReadKey();

        }

        private void ViewDeveloperByName()
        {
            Console.Clear();
            //List<Developer> listOfContent = _contentRepo.GetDeveloperList();
            //Developer content = new Developer();

            // Prompt Developer NAme
            Console.WriteLine("Enter the Develpoer Name:");

            // Get user's Inputs
            string name = Console.ReadLine();

            // Find Develper by Name
           Developer content = _listOfDeveloper.GetDeveloperByName(name);

            if (name == content.Name)
            //if (content != null)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"IDNumber:{content.IdNumber} \n" +
                    $"HaveAccess:{content.HaveAccess}");

            }
            else
            {

                Console.WriteLine("Please Enter a valid Developer Name:");
            }

            Console.ReadKey();
        }
        




        private void UpdateExistingDeveloper()
        {

            // Dsipaly all contnet 

            DisplayAllDeveloper();

            //Ask for the title of the contetn to update
            Console.WriteLine("Enter the Name of the Developer you'd like to update");

            //Get the title

            string oldTitle = Console.ReadLine();
            /*Console.Clear();*/
            Developer newContent = new Developer();
            //Name
            //ID Rating
            Console.WriteLine("Enter the Developer ID Number:");
            /*newContent.IdNumber = Console.ReadLine();*/

            string starAsIntiger = Console.ReadLine();
            //newContent.IdNumber = int.Parse(starAsIntiger);
            int Idnumber;
            Int32.TryParse(starAsIntiger, out Idnumber);

            bool wasUpdated = _listOfDeveloper.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("Content sucessfuly Updated");

            }
            else
                Console.WriteLine("Coudl not update content");
        }
        private void DeleteExisitingDeveloper()
        {
            DisplayAllDeveloper();

            //Get the title they want to remo3

            Console.WriteLine(" \n Enter the Developer you'd like to remove:");

            string input = Console.ReadLine();
            //Call the delete method
            bool wasDeleted = _listOfDeveloper.RemoveDeveloperFromList(input);
            //If  the content was deleted, say so
            if (wasDeleted)
            {
                Console.WriteLine("The Developer was successfully delted");
            }
            else
            {
                Console.WriteLine("The Developer could not be deleted");

            }
        }



        private void seedContentList()
        {
            Developer Mark = new Developer("Mark Armstrong", 103, true);
            Developer Sami = new Developer("The Sami Yan", 203, false);
            Developer Joe = new Developer("Joe earnest", 303, true);


            _listOfDeveloper.AddDeveloperToList(Mark);
            _listOfDeveloper.AddDeveloperToList(Sami);
            _listOfDeveloper.AddDeveloperToList(Joe);




        }
    }

}
