using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents a team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents the list of members in the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
