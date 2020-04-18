using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a prize.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents where the team finished the tournament.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name for the place, i.e. "Champion", "Runner up" etc
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents how much the team has won.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the tournament income the team has won.
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
