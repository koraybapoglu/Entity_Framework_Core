using Entity_VeriGetirme.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_VeriGetirme
{
	public class ETicaretDbContext : DbContext
	{
		public DbSet<Urun> Urunler { get; set; }
		public DbSet<Parca> Parcalar { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			optionsBuilder.UseSqlServer("Server=DESKTOP-RN1V6Q9;Database=ETicaretDB;Trusted_Connection=True;TrustServerCertificate=true;");
		}
	}
}
