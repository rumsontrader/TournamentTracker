using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of a member of a team
        /// </summary>
        public string FirstName { get; set; }


        /// <summary>
        /// Represents the last name of a member of a team
        /// </summary>
        public string LastName { get; set; }


        /// <summary>
        /// Represents a team members email address
        /// </summary>
        public int EmailAddress { get; set; }


        /// <summary>
        /// Represents a team members cellphone number
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
