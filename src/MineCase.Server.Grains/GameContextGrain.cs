﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MineCase.Engine;

namespace MineCase.Server.Grains
{
    public class GameContextGrain
    {
        private Context _context;

        public Task AddEntity(Entity entity)
        {
            return Task.CompletedTask;
        }

        public Task RemoveEntity(Guid guid)
        {
            return Task.CompletedTask;
        }
    }
}