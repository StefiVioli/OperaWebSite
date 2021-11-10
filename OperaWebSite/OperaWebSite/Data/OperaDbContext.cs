using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OperaWebSite.Models;
using System.Data.Entity;
namespace OperaWebSite.Data
{
    public class OperaDbContext:DbContext
    {
        public OperaDbContext() : base("KeyDB") { }
        public DbSet<Opera> Operas { get; set; }
    }
}