using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {/// <summary>
    /// List of Team Members in the tournament
    /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Names of Teams in tournament
        /// </summary>
        public string TeamName { get; set; }


    }
}
