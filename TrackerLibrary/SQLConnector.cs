using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class SQLConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //throw new NotImplementedException();
            model.Id = 1;
            return model;
        }
    }
}
