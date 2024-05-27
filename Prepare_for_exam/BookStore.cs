using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepare_for_exam
{
    public class BookStore<T> where T : IBook
    {
        private List<T> books = new List<T>();
        public void AddBook(T book) { books.Add(book); }
        public void RemoveBook(T book) { books.Remove(book); }
        public IEnumerable<T> FindBooksByAutor(string autor) { return books.Where(b => b.Author == autor); }
        public IEnumerable<T> FindBooksByName(string name) { return books.Where(b => b.Title == name); }
        public IEnumerable<T> GetBooksSortedBy(Func<T, object> keySelector) { return books.OrderBy(keySelector); }
        public double CalculateTotalPriece() { return books.Sum(b => b.Price); }
        public T GetMostExpensiveBook() { return books.OrderByDescending(b => b.Price).FirstOrDefault(); }
    }
}
