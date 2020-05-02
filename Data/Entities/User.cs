using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalManager.Data.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nick { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Work> Works { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public User user {get ; set;}

    }
}
