using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy_EFCourseSection4Exercise
{
    class MercuryContext : DbContext
    {
        public MercuryContext() : base("name=DefaultConnection") { ; }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
