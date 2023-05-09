using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace TournamentTracker.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // Actionalize the createPrize method for the text files
        PrizeModel IDataConnection.CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
