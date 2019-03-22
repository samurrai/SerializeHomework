using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                Name = "Harry Potter",
                Price = 4500,
                Author = "J.K.Rowling", 
                Year = 2011
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream writer = new FileStream("data.txt", FileMode.Create))
            {
                formatter.Serialize(writer, book);
            }
            Book newBook = new Book();
            using (FileStream writer = new FileStream("data.txt", FileMode.Open))
            {
                newBook = formatter.Deserialize(writer) as Book;
            }
            Console.WriteLine(newBook.Name);
            var type = typeof(Book);
            var val = type.CustomAttributes;
            foreach (var element in val)
            {
                Console.WriteLine(element);
            }
        }
    }
}
