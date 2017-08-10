using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection
    {
        //TODO - Wire up the CreatePrize form for text files
        /// <summary>
        /// Saves a new text file
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns></returns>
        public PrizeModel CreatPrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
