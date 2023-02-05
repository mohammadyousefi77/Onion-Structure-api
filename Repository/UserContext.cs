using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class UserContext:DbContext
    {

        public UserContext(DbContextOptions<UserContext> options)
        : base(options)
        {
        }
        public DbSet<User> user { get; set; }
    }
}
