using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KomodoInsurance__Repositories
{
    class DevTeam
    {
        public string TeamName { get; set; }
        public int TeamId { get; set; }
        public List <Developer> TeamMembers { get; set; }

        public DevTeam() { }

        public DevTeam(string teamname, int teamid, List <Developer> teammembers)
        {
            TeamName = teamname;
            TeamId = teamid;
            TeamMembers = teammembers;
        }


    }
}
