using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalManager.Data.Entities
{
    public class Work
    {   public int Id { get; set; }

        public DateTime WorkStartDate { get; set; }

        public DateTime WorkEndDate { get; set; }
        public Boolean IsDone { get; set; }


    }
}
