using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCompany.Domein
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Gebruikers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
    : base(options)
        {
        }
    }
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int CarModel { get; set; }
        public User User { get; set; }
        public Company Company { get; set; }

    }
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public IList<Car> Cars { get; set; }

    }
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Car> Cars { get; set; }
    }
}
