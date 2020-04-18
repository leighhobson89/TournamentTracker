using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents the teams in the match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Represents the match winner.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents which round of the tournament this match was in.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
