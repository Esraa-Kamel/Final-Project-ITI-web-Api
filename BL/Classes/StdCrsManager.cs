﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL.Classes
{
    public class StdCrsManager : Repository<std_Crs>
    {
        public StdCrsManager(SchoolDBEntities ctx) : base(ctx)
        {
        }
    }
}
