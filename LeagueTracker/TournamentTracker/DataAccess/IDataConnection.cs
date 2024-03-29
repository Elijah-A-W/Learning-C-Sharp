﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace TournamentTracker.DataAccess
{
    public interface IDataConnection
    {
        /// <summary>
        ///  Whoever implements IDataConnection will have 
        ///    access to the CreatePrize method.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        PrizeModel CreatePrize(PrizeModel model);
    }
}
