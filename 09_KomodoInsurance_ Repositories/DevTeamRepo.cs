using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KomodoInsurance__Repositories
{
    class DevTeamRepo
    {
        private List<DevTeam> _listOfDevTeam = new List<DevTeam>();

        //Create
        public void AddDevTeamToList(DevTeam content)
        {
            _listOfDevTeam.Add(content);


        }
        //Read


        public List<DevTeam> GetDevTeamList()
        {
            return _listOfDevTeam;
        }



        //Update

        public bool UpdateExistingContent(string originalName, DevTeam newContent)
        {
            //find the Content
            DevTeam oldContent = GetDevTeamByName(originalName);


            // Update the Content 
            if (oldContent != null)
            {
                oldContent.TeamName = newContent.TeamName;
                oldContent.TeamId = newContent.TeamId;
                oldContent.TeamMembers = newContent.TeamMembers;


                return true;
            }
            else
            {
                return false;
            }

        }


        // Delete
        public bool RemoveDevTeamFromList(string name)
        {
            DevTeam content = GetDevTeamByName(name);
            if (content == null)
            {

                return false;
            }

            int initialCount = _listOfDevTeam.Count;
            _listOfDevTeam.Remove(content);

            if (initialCount > _listOfDevTeam.Count)
            {
                return true;
            }
            else
            {
                return false;

            }


        }

        //Helper method
        private DevTeam GetDevTeamByName(string name)
        {
            foreach (DevTeam content1 in _listOfDevTeam)
            {
                if (content1.TeamName.ToLower() == name.ToLower())
                {
                    return content1;
                }
            }

            return null;
        }

    }
}
