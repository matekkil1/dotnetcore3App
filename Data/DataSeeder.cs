using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using PersonalManager.Data.Entities;
using PersonalManager.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalManager.Data
{
    public class DataSeeder
    {
        private readonly PersonalManagerContext _ctx;
        private readonly IHostingEnvironment _hosting;

        public DataSeeder(PersonalManagerContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }
        public void Seed()
        {
            
            var filepath = Path.Combine(_hosting.ContentRootPath, "Data/seed.json");
            var json = File.ReadAllText(filepath);
            var teams = JsonConvert.DeserializeObject<IEnumerable<Team>> (json);
            _ctx.Teams.AddRange(teams);
            _ctx.SaveChanges();
    }
    }
    
}
