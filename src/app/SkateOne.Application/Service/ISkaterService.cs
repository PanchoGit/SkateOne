﻿using System.Collections.Generic;
using SkateOne.Domain;

namespace SkateOne.Application.Service
{
    public interface ISkaterService
    {
        IEnumerable<Skater> GetAll();
    }
}
