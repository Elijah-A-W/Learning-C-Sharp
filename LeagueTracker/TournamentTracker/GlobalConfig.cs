using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public static class GlobalConfig
    {
        /// <summary>
        ///     Created a connections list(Connections) that 
        ///     helps to hold anything that holds the IDataConnections 
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);

            }

            if (textFiles)
            {
                // TODO - create the textfile connection
                TextConnection text = new TextConnection();
                Connections.Add(text); 
            }
        }
    }
}
