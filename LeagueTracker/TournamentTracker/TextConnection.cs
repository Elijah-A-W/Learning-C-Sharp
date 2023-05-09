using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace TournamentTracker
{
    public class TextConnection : IDataConnection
    {
        // Actionalize the createPrize method for the text files
        PrizeModel IDataConnection.CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
