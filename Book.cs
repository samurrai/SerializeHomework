using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeHomework
{
    [Serializable]
    [Book(PagesAmount = 250)]
    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
