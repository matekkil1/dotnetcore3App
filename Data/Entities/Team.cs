using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalManager.Data.Entities
{
    public class Team
    {   public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Event> Events { get; set; }

    }
}
