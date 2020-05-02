using PersonalManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalManager.Data
{
    public class Event
    {
        public int Id { get; set; }
        public ICollection<Work> Works { get; set; }

        public string Description { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
