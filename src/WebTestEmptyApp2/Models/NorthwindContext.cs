using Microsoft.Data.Entity;
using System;

namespace WebTestEmptyApp2.Models
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}