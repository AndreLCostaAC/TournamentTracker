﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);

        PersonModel CreatePerson(PersonModel model);

        List<PersonModel> GetPerson_ALL();
    }
}
