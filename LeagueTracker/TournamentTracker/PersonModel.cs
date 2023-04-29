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
    internal class PersonModel
    {
        /// The firstName of the person
        public string Name { get; set; }

        /// The lastName of the person
        public string LastName { get; set; }

        /// The Email Address of the person
        public string EmailAddress { get; set; }

        ///The person cellphone number
        public string CellphoneNumber { get; set; }
    }
}
