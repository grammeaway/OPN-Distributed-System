using Microsoft.EntityFrameworkCore;
using backend1.Model;

namespace backend1
{ 
    public class PostgresContext : DbContext
    { 
        public DbSet<Person> Persons {get; set;}

        public PostgresContext(DbContextOptions options)
            : base(options) { }

    }
}