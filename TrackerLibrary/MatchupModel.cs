using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// List of Matchups
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Winner of the particular matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The current round in the tournament
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
