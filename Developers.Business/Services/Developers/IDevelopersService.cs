﻿using Developers.DataModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Developers.Business.Services.Developers
{
    public interface IDevelopersService : IService
    {
        IEnumerable<Developer> ReadAll();
        Task<IEnumerable<Developer>> ReadAllAsync();
    }
}