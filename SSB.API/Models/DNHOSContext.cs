using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SSB.API.Models
{
    public class DNHOSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=srh_nuzz\SQLSERVER;Database=DNHOS;User ID=sa;Password=P@ssw0rd;");
            //optionsBuilder.UseSqlServer(@"Server=10.168.23.22\SQLSERVER;Database=DNHOS;User ID=sa;Password=P@ssw0rd;");
            optionsBuilder.UseSqlServer(@"Server=192.168.65.16;Database=DNHOS;User ID=sa;Password=P@ssw0rd;");
        }
        public virtual DbSet<V_NURSE> V_NURSE { get; set; }
        public virtual DbSet<V_WARD> V_WARD { get; set; }
        public virtual DbSet<V_DOCTOR> V_DOCTOR { get; set; }
        public virtual DbSet<V_SSBACCOUNT> V_SSBACCOUNT { get; set; }
        public virtual DbSet<V_IPD> V_IPD { get; set; }
    }
}
