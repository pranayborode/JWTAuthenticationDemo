using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JWTAuthenticationDemo.Models
{
	[Table("Books")]
	public class Book
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Author { get; set; }
		public string? Description { get; set; }
		public decimal? Price { get; set; }

		public int? Stock { get; set; }

	}

}
