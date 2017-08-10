using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents where the team finished
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents how the places will be named e.g.
        /// "1st place" or "Winner", "2nd place" or "First 
        /// runner up"        /// 
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount of money a particular
        /// place will recieve
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the total pot
        /// the particular place will recieve
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
