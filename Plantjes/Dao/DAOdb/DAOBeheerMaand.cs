﻿using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantjes.Dao.DAOdb
{
    public class DAOBeheerMaand : DAOGeneric
    {
        public DAOBeheerMaand() : base()
        {
            //ctor
        }


        public List<BeheerMaand> FillBeheerdaad()
        {
            var selection = base.Context.BeheerMaands.ToList();
            return selection;
        }

        

        //Get a list of all the Beheermaand types
        public List<BeheerMaand> GetBeheerMaanden()
        {
            var beheerMaanden = base.Context.BeheerMaands.ToList();
            return beheerMaanden;
        }
    }
}
