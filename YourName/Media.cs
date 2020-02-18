using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourName
{
    public abstract class Media
    {
        // PROPERTIES
        public long Id { get; set; }
        public string Title { get; set; }
        public List<string> Genres { get; set; }
        
        // CONSTRUCTOR
        public Media()
        {

        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}");
        }
    }
}
