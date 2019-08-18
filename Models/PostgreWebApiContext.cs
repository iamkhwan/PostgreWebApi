using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace PostgreWebApi.Models
{
	public class PostgreWebApiContext : DbContext
	{
		public PostgreWebApiContext(DbContextOptions<PostgreWebApiContext> options) : base(options)
		{

		}

		public DbSet<UserProfile> UserProfile { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserProfile>()
				.Property(p => p.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
