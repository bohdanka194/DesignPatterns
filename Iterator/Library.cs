using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Library :IBookNumerable
    {
        public Book[] books;
        public Library()
        {
            books = new Book[]
            {
                new Book { Name = "Origin" },
                new Book { Name = "Nanotechnology" },
                new Book { Name = "CLR via C#" },
                new Book { Name = "Book4"},
                new Book { Name = "Book5"},
                new Book { Name = "Book6"},
            };


        }

        public Book this[int index]
        {
            get { return books[index]; }
        }

        public int Count
        {
            get { return books.Length; }
        }

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    
    }
}
