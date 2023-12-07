using System;
using System.Collections.Generic;
using System.Linq;

namespace EX7
{
    public class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string add { get; set; }
        public string DoB { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<User> listuser = new List<User>
            {
                new User{ID = 1,name= "John",add = "London",DoB = "2001-04-01" },
                new User{ID = 2,name=  "Lenny",add =  "New York",DoB = "1997 - 12 - 11" },
                new User{ID = 3,name=  "Andrew",add =  "Boston",DoB =  "1987-02-22" },
                new User{ID = 4,name=  "Peter",add =  "Prague",DoB =  "1936-03-24" },
                new User{ID = 5,name=  "Anna",add =  "Bratislava",DoB =  "1973-11-18" },
                new User{ID = 6,name=  "Albert",add =  "Bratislava",DoB =  "1940-12-11" },
                new User{ID = 7,name=  "Adam",add =  "Trnava ",DoB =  "1983-12-01" },
                new User{ID = 8,name=  "Robert",add =  "Bratislava",DoB =  "1935-05-15" },
                new User{ID = 9,name=  "Robert",add =  "Prague",DoB =  "1998-03-14" },
            };
            IEnumerable<User> reult = from u in listuser
                                      where u.add == "Bratislava"
                                      select u;
            foreach(User u in reult)
            {
                Console.WriteLine($"{u.ID} {u.name} {u.add} {u.DoB}");
            }
            Console.ReadKey();
        }
    }
}
