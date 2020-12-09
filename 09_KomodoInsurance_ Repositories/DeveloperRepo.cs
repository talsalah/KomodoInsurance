using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KomodoInsurance__Repositories
{
    public class DeveloperRepo
    {
        private List<Developer> _listOfDeveloper = new List<Developer>();

        //Create
        public void AddDeveloperToList(Developer content)
        {
            _listOfDeveloper.Add(content);


        }
        //Read


        public List<Developer> GetDeveloperList()
        {
            return _listOfDeveloper;
        }



        //Update

        public bool UpdateExistingContent(string originalName, Developer newContent)
        {
            //find the Content
            Developer oldContent = GetDeveloperByName(originalName);


            // Update the Content 
            if (oldContent != null)
            {
                oldContent.Name = newContent.Name;
                oldContent.IdNumber = newContent.IdNumber;
                oldContent.HaveAccess = newContent.HaveAccess;
               

                return true;
            }
            else
            {
                return false;
            }

        }


        // Delete
        public bool RemoveDeveloperFromList(string name)
        {
            Developer content = GetDeveloperByName(name);
            if (content == null)
            {

                return false;
            }

            int initialCount = _listOfDeveloper.Count;
            _listOfDeveloper.Remove(content);

            if (initialCount > _listOfDeveloper.Count)
            {
                return true;
            }
            else
            {
                return false;

            }


        }

        //Helper method
        public Developer GetDeveloperByName(string name)
        {
            foreach (Developer content in _listOfDeveloper)
            {
                if (content.Name.ToLower() == name.ToLower())
                {
                    return content;
                }
            }

            return null;
        }

        public Developer GetDeveloperByIdNumber(int idNumber)
        {
            foreach (Developer content in _listOfDeveloper)
            {
                if (content.IdNumber == idNumber)
                {
                    return content;
                }
            }

            return null;
        }




    }
}
