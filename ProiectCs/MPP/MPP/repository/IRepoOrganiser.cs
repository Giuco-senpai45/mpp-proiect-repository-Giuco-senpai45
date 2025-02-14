﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP.model;

namespace MPP.repository
{
    public interface IRepoOrganiser : Repository<Organiser, int>
    {
        Organiser findByNameAndPassword(String name, String password);
    }
}
