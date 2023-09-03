using Microsoft.EntityFrameworkCore;
using webapiMySQL.Data.Entities;

namespace webapiMySQL.Data
{
    public class MyWorldDBContext : DbContext
    {

        public MyWorldDBContext(DbContextOptions<MyWorldDBContext> options) : base(options)
        { }

       

        public DbSet<Gadget> Gadgets { get; set; }

    }
}