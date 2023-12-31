﻿using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
	public class BookDAO
	{
		public static List<Book> GetBooks()
		{
			var listBooks = new List<Book>();
			try
			{
				using (var context = new ApplicationDbContext())
				{
					//listBooks = context.Books.Where(x => x.IsDeleted == false).ToList();
					listBooks = context.Books.Include(b => b.Genre).Include(b => b.Author).Include(b => b.Publisher).Where(b => b.IsDeleted == false)
						.OrderByDescending(b => b.BookLastUpdated)
						.Select(b => new Book
						{
							BookId = b.BookId,
							BookTitle = b.BookTitle,
							BookPrice = b.BookPrice,
							BookOriginalPrice = b.BookOriginalPrice,
							SalePercent = b.SalePercent,
							BookStock = b.BookStock,
							BookImage = b.BookImage,
							Genre = b.Genre,
							Author = b.Author,
							Publisher = b.Publisher,
						}).ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
			return listBooks;
		}

		public static Book FindBookById(int bookID)
		{
			Book book = new Book();
			try
			{
				using (var context = new ApplicationDbContext())
				{
					book = context.Books.Include(g => g.Genre).Include(a => a.Author).Include(p => p.Publisher).SingleOrDefault(x => x.BookId == bookID);
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
			return book;
		}

		public static void SaveBook(Book book)
		{
			try
			{
				using (var context = new ApplicationDbContext())
				{
					var obj = context.Books.SingleOrDefault(x => x.BookTitle == book.BookTitle);
					if (obj != null)
					{
						obj.IsDeleted = false;
						context.Entry<Book>(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
					}
					else
					{
						context.Books.Add(book);
					}
					context.SaveChanges();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public static void UpdateBook(Book book)
		{
			try
			{
				using (var context = new ApplicationDbContext())
				{
					context.Entry<Book>(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
					context.SaveChanges();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public static void DeleteBook(Book book)
		{
			try
			{
				using (var context = new ApplicationDbContext())
				{
					var b = context.Books.SingleOrDefault(c => c.BookId == book.BookId);
					//context.Genres.Remove(c);
					b.IsDeleted = true;
					context.Entry<Book>(b).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
					context.SaveChanges();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
	}
}
