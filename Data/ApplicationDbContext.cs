using JWTAuthenticationDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthenticationDemo.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Book> Books { get; set; }
	}
}
