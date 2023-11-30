using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_18._11._2023
{
    internal class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set;}
        internal Books(string title, string author, string publishingHouse)
        {
            Title = title;
            Author = author;
            PublishingHouse = publishingHouse;
        }
        class BookContain
        {
            public Books[] book;
            public BookContain(Books[] book)
            {
                this.book = book;
            }
            public void SortBooks(Comparison<Books>comparison)
            {
                Array.Sort(book,comparison);
            }

            internal void SortBooks(Comparison<Books> sortByTitle)
            {
                throw new NotImplementedException();
            }
        }
    }
}
