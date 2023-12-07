using System;
using System.Collections.Generic;
using System.Linq;

namespace EX7_2_
{
    public class Cars
    {
        public string name { get; set; }
        public int Price { get; set; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> lstcar = new List<Cars>
            {
                new Cars{name ="Audi",Price= 52642},
                new Cars{name ="Mercedes",Price= 57127},
                new Cars{name ="Skoda",Price= 9000},
                new Cars{name ="Volvo",Price= 29000},
                new Cars{name ="Bentley",Price= 350000},
                new Cars{name ="Citroen",Price= 21000},
                new Cars{name ="Hummer",Price= 41400},
                new Cars{name ="Volkswagen",Price= 21600},
            };
            IEnumerable<Cars> result = from c in lstcar
                                       where c.Price > 30000 && c.Price < 100000
                                       select c;
            foreach (Cars c in result)
            {
                Console.WriteLine($"{c.name} {c.Price}");
            }
            Console.ReadKey();
        }
    }
}
