using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
     class Film
    {
        public string FilmId { get; set; }
        public string FilmName { get; set;}
        public int Price { get; set;}

        public override string ToString()
        {
            return FilmId + ":" + FilmName + ":" + Price;
        }
    }

}
