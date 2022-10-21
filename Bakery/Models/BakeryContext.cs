using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
	public class BakeryContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Treat> Treats {get; set;}
		public DbSet<Flavor> Flavors {get; set;}
		public DbSet<TreatFlavor> TreatFlavor {get; set;}

		public BakeryContext (DbContextOptions options) : base(options) {}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseLazyLoadingProxies();
		}
	}
}
