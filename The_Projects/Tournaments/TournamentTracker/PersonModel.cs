using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The firstname of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The primary EmailAddress of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The Primary cellphone number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
