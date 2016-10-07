using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary
{
  public class Film
    {
        public string Title { get; private set; }
        public string Producer { get; private set; }
        public string Genre { get; private set; }

        public Film(string title, string producer, string genre)
        {
            Title = title;
            Producer = producer;
            Genre = genre;

        }
     
        
    }
}
