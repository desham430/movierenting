using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DBcontext:DbContext
    {
        public DBcontext()
            :base("name=videoapp")
        { }

        public DbSet<Customer>mycustomers  { get; set; }
        public DbSet<MembershipType> mymembership { get; set; }
        public DbSet<Movie> mymovie { get; set; }
    }
}