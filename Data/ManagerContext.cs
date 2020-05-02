using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using PersonalManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalManager.Data
{
    public class ManagerContext : DbContext
    { 
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {

        }
       
    }
}
