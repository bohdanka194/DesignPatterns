using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class BookStore :IBook
    {
        PageContext db;
        public BookStore()
        {
            db = new PageContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Page GetPage(int number)
        {
            return db.Pages.FirstOrDefault(p => p.Number == number);
        }
    }
}
