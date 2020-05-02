using PersonalManager.Data.Entities;
using PersonalManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalManager.Data
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly PersonalManagerContext _ctx;

        public ManagerRepository(PersonalManagerContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Team> FindTeamById()
        {
            return _ctx.Teams
                .OrderBy(p => p.Id)
                .ToList();
        }
    }
}
