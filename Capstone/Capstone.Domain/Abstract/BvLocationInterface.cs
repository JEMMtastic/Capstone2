﻿using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface BvLocationInterface
    {
         BvLocation GetBvLocation(int locId);
         IQueryable<BvLocation> GetBvLocations();
         void AddBvLocation(BvLocation bvLocation);
         BvLocation DeleteBvLocation(int bvLocationId);
         BvLocation GetBvLocation(string storeNum);
         void SaveBvLocation(BvLocation l);
    }
}
