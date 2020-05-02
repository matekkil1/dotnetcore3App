using System.Collections.Generic;
using PersonalManager.Data.Entities;

namespace PersonalManager.Data
{
    public interface IManagerRepository
    {
        IEnumerable<Team> FindTeamById();
    }
}