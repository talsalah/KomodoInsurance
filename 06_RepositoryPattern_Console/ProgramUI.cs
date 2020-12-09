using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository 
       StreamingContentRepository content = new StreamingContentRepository();
        /*private object streamingContent;*/

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
                    "1.Create New Content\n" +
                    "2. View All Content \n" +
                    "3. View Content By Title \n" +
                    "4. Update Exisiting Content \n" +
                    "5. Delete Exisiting Content\n" +
                    "6. Exit");
                //Get the user's input and act accordingly
                string input = Console.ReadLine();

                //Evaluate the user's input and act accordingly


                switch (input)
                {
                    case "1":
                        //Create new contrent
                        CreateNewContent();
                        break;
                    case "2":
                        // View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        // View Content By Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        // Update Exisiting Content 
                        UpdateExistingContent();
                        break;
                    case "5":
                        DeletExistingContent();

                        // Delete Exisiting Content 

                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        //Exit
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
        // Create new StreamingContent
        private void CreateNewContent()
        {
            /*Console.Clear();*/
            StreamingContent newContent = new StreamingContent();
            //Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G,PG,PG-13,etc):");
            newContent.MaturityRating = Console.ReadLine();


            //Star Rating
            Console.WriteLine("Enter the star Count for the conten (5.8,10,1.5):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);
            //Is FamilyyFriendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();
            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }



            //GenreType
            Console.WriteLine("Enter the Genre Numbr\n" +
                "1.Horror\n" +
                "2.RomCom\n" +
                "3.SciFi\n" +
                "4.Documentary\n" +
                "5.Bromance\n" +
                "6.Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeofGenre = (GenreType)genreAsInt;

            _contentRepo.AddContentToList(newContent);




            /*
              Horror =1,
            RomCom,
            SciFi,
            Documentary,
            Bromance, 
            Drama,
            Action, 
            */
        }


        // View Current Streaming Content by title
        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _contentRepo.GetContentList();

            foreach (StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title:{content.Title}\n" +
                    $"Description:{content.Description}");



            }


        }


        // View Current Streaming Content by title
        private void DisplayContentByTitle()
        {
            Console.Clear();
            //Prompt the user to give me a title
            Console.WriteLine("Enter the title of the content you'd like to see:");
            //Get the user's input
            string title = Console.ReadLine();

            //Find the Content by that title
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            //Display said content if it isnt' null
            if (content != null)
            {
                Console.WriteLine($"Title:{content.Title}\n" +
                    $"Description:{content.Description}\n" +
                    $"Maturity Rating:{content.MaturityRating}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Is Family Friendly:{content.IsFamilyFriendly}\n" +
                    $"Genre:{content.TypeofGenre}");
            }
            else
            {
                Console.WriteLine("No content by that title.");

            }





        }

        //Update Existing content
        private void UpdateExistingContent()
        {
            // Dsipaly all contnet 

            DisplayAllContent();

            //Ask for the title of the contetn to update
            Console.WriteLine("Enter the title of the content you'd like to update");

            //Get the title

            string oldTitle = Console.ReadLine();


            //build a new object

            StreamingContent newContent = new StreamingContent();
            //Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G,PG,PG-13,etc):");
            newContent.MaturityRating = Console.ReadLine();


            //Star Rating
            Console.WriteLine("Enter the star Count for the conten (5.8,10,1.5):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);
            //Is FamilyyFriendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();
            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }



            //GenreType
            Console.WriteLine("Enter the Genre Numbr\n" +
                "1.Horror\n" +
                "2.RomCom\n" +
                "3.SciFi\n" +
                "4.Documentary\n" +
                "5.Bromance\n" +
                "6.Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeofGenre = (GenreType)genreAsInt;
            // verify the update work
            bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("Content sucessfuly Updated");

            }
            else
                Console.WriteLine("Coudl not update content");
        }






        //Delet Existing Cntent 
        private void DeletExistingContent()
        {



            DisplayAllContent();

            //Get the title they want to remove
            Console.WriteLine(" \n Enter the title of the content you'd like to remove:");

            string input = Console.ReadLine();
            //Call the delete method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);
            //If  the content was deleted, say so
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully delted");
            }
            else
            {
                Console.WriteLine("The contnet could not be deleted");

            }
            // Other
        }
        //see method 
        private void seedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados but withsharks.", "TV_12", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Bankers", "G", 4.7, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tirecomes to Lift", "R", 5.8, false, GenreType.Action);


            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(theRoom);
            _contentRepo.AddContentToList(rubber);




        }
    }
}


