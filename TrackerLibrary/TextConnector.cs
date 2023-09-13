using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.TextHelpers;

namespace TrackerLibrary
{
    class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";

        private const string PersonsFile = "PersonsFile.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> person = PersonsFile.FullFilePath().LoadFile().convertToPersonModel();


            // Find the max ID
            int currentId = 1;

            if (person != null && person.Count > 0)
            {
                currentId = person.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            currentId += 1;

            // Add the new record with the new ID(max + 1)
            person.Add(model);


            // Convert the prizes to list <String>
            // Save the list <string> to the text file
            person.SaveToPersonFile(PersonsFile);

            return model;
        }


        // TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file 
            // Convert the text to List<Prize Model>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().convertToPrizeModel();


            // Find the max ID
            int currentId = 1;

            if(prizes != null && prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
                
            model.Id = currentId;

            currentId += 1;

            // Add the new record with the new ID(max + 1)
            prizes.Add(model);


            // Convert the prizes to list <String>
            // Save the list <string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;



        }
    }
}
