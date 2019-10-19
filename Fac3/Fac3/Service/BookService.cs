using Fac3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fac3.Service
{

    public class BookService
    {
        public IEnumerable<Book> List()
        {
            IEnumerable<Book> result;
            using (var dataContext = new DataContext())
            {
                result = dataContext.Books.ToList();
            }
            return result;
        }
        public Book Insert(Book book)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Books.Add(book);
                dataContext.SaveChanges();
            }
            return book;
        }
        public Book Update(Book book)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Books.Update(book);
                dataContext.SaveChanges();
            }
            return book;
        }
        public Book Get(int id)
        {
            Book result;
            using (var dataContext = new DataContext())
            {
                result = dataContext.Books.Find(id);
            }
            return result;
        }
        public void Delete(int id)
        {
            Book result;
            using (var dataContext = new DataContext())
            {
                result = dataContext.Books.Find(id);
                dataContext.Books.Remove(result);
                dataContext.SaveChanges();
            }   
        }
    }
}
