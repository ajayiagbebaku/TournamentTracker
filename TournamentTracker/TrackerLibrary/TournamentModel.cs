using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
   public class TournamentModel
    {   /// <summary>
    /// Name of the tournament
    /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Entry Fee for the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Prizes in the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Matchuo per rounds 
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
