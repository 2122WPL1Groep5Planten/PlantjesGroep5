﻿using Plantjes.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantjes.Dao.DAOdb
{
    class DAOPlant : DAOGeneric
    {
        public DAOPlant() : base()
        {
            //ctor
        }

        //get a list of all the plants
        ///Kenny-1st year wrote this
        public List<Plant> getAllPlants()
        {
            // kijken hoeveel er zijn geselecteerd
            var plants = base.Context.Plants.ToList();
            return plants;
        }
    }
}
