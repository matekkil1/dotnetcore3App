using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalManager.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public DateTime CommentDate { get; set; }
    }
}
