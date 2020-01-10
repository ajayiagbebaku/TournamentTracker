using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {/// <summary>
    /// Place number of each team in the tournament (1st, 2nd, etc..)
    /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Place name of each team in the tournament ( champions, runner up , etc)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Prize amount in the tournament 
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Prize percentage in the tournament 
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
