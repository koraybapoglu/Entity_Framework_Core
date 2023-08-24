using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_CRUD_Islemleri.Entity;

namespace Entity_CRUD_Islemleri
{
	class SchoolDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RN1V6Q9;Database=School;Trusted_Connection=True;TrustServerCertificate=true;");
		}
	}
}
