using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Data;

public class ConsolAppContext : DbContext
{
    private DbSet<Product> products { get; set; } = null!;

    private DbSet<Order> orders { get; set; } = null!;

    public DbSet<Customer> Customers { get; set; } = null!;

    private DbSet<OrderDetail> orderDetails { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ConsolAppContext");
    }

}

