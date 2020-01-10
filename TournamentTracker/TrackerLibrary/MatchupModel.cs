using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {   /// <summary>
    /// Matchup list
    /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Winner of each matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Matchup in each round
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
