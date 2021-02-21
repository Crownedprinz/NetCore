using System;
using DebbyTest.Models.Customers;
using Microsoft.EntityFrameworkCore;

namespace DebbyTest.DATA
{
    public class MainContext: DbContext
    {

        public virtual DbSet<Tbl_Customer> Tbl_Customer { get; set; }

        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
        }
    }
}
