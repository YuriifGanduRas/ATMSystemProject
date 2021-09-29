using System;
using System.Collections.Generic;
using System.Text;
using ATMSystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ATMSystem.Data.Context
{
    public class ATMSystemContext : DbContext
    {
        private readonly IConfiguration Configuration;
        public ATMSystemContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountStatus> AccountStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.Cards).WithOne(c => c.User);
            modelBuilder.Entity<Card>().HasOne(c => c.CardType).WithMany(ct => ct.Cards);
            modelBuilder.Entity<Bank>().HasMany(b => b.Cards).WithOne(c => c.Bank);
            modelBuilder.Entity<Card>().HasOne(c => c.Account).WithOne(a => a.Card);
            modelBuilder.Entity<Account>().HasOne(a => a.AccountStatus).WithMany(acs => acs.Accounts);
        }
    }
}
