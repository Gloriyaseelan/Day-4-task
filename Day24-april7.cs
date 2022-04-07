using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace lynq
{
    class Day24_april7
    {
       public static void Main()
        {
            IList<books> bdata = new List<books>()
            {
                new books(){bookid=1,title="The Guide",author="R.K.Narayan",price=175},
                new books(){bookid=1,title="2 States",author="Chetan Bhagat",price=171},
                new books(){bookid=1,title="Wings of Fire",author="A.P.J.Abdul Kalam ",price=499},

            };

            var bqry = from book in bdata
                       select book;
            foreach (var b in bqry)
                Console.WriteLine(b.bookid + "   " + b.title+"   "+b.author+"   "+b.price);

            var titqry = from book in bdata
                         where book.author.Contains("Chetan Bhagat")
                         select book;
            foreach (var names in titqry)
                Console.WriteLine(names.title);

            var booqry = from b in bdata
                         orderby b.price ascending
                         select b;
            foreach (var b in booqry)
                Console.WriteLine(b.price);

              var boqry= bdata.OrderBy(b => b.author);
            foreach (var b in bqry)
                Console.WriteLine(b.author+"   "+b.title);














        }
    }

    internal class books
    {
        public books()
        {
        }

        public int bookid { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int price { get; set; }
    }
}
