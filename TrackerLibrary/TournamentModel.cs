using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the current tournament
        /// </summary>
        public string TournamentName { get; set; }
        
        /// <summary>
        /// Represents the amount in dollors it costs each
        /// team to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }


        /// <summary>
        /// Represents a list of the names of all the teams entered
        /// in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();


        /// <summary>
        /// Represents a list of all the prizes for this particular tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents embedded lists of all the brackets in the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
