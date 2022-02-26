using Microsoft.EntityFrameworkCore;
using TaskContext.Entities;

namespace TaskContext.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public  DataContext()
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               optionsBuilder.UseSqlServer("Server=LAPTOP-T5ETFQ2L;Database=TaskOneDB;Trusted_Connection=true;MultipleActiveResultSets=true;");
            }
        }

        //جدول الاشخاص وارقام التليفون
        public DbSet<tblUsersPhoneNumbers> tblUsersPhoneNumbers { get; set; }
        //جدول الرسائل
        public DbSet<tblSendMessage> tblSendMessage { get; set; }

    }
}
