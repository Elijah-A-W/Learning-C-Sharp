using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // create the SQL connection 
            }

            if (textFiles)
            {
                // create the textfile connection 
            }
        }
    }
}
