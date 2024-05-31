using JWTAuthenticationDemo.Data;
using JWTAuthenticationDemo.Models;

namespace JWTAuthenticationDemo.Repositories
{
	public class BookRepository : IBookRepository
	{
		private readonly ApplicationDbContext db;
		public BookRepository(ApplicationDbContext db)
		{
			this.db = db;
		}
		public int AddBook(Book book)
		{
			int result = 0;
			db.Books.Add(book);
			result = db.SaveChanges();
			return result;
		}

		public int DeleteBook(int? id)
		{
			var book = db.Books.Find(id);
			if (book != null)
			{
				db.Books.Remove(book);
				int result = db.SaveChanges();
				return result;
			}
			else
			{
				return 0;
			}

		}

		public Book? GetBookById(int id)
		{
			var book = db.Books.Find(id);
			if (book != null)
			{
				return book;
			}
			else
			{
				return null;
			}
		}

		public IEnumerable<Book> GetBooks()
		{
			return db.Books.ToList();
		}

		public int UpdateBook(Book book)
		{
			var b = db.Books.Find(book.Id);
			if (b != null)
			{
				b.Name = book.Name;
				b.Author = book.Author;
				b.Price = book.Price;
				int result = db.SaveChanges();
				return result;
			}
			else
			{
				return 0;
			}
		}
	}


}
