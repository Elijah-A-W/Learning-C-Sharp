using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace TournamentTracker
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Functionalize CreatePrize to save to database  
        /// <summary>
        ///  Saving a new Price to the database
        /// </summary>
        /// <param name="model"> The Prize information </param>
        /// <returns> The prize information including e Unique Identifier </returns>
        /// <exception cref="NotImplementedException"></exception>
        
        PrizeModel IDataConnection.CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
