using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Alkalmazottak
    {
        public int Id { get; set; }
        public string? Nev { get; set; }
        public int Kor { get; set; }
        public string? Varos { get; set; }
        public string? Munka { get; set; }
        public int Bevetel { get; set; }

        public Alkalmazottak() { }

        public Alkalmazottak(string sor)
        {
            var a = sor.Split(";");
            Nev = a[0];
            Kor = Convert.ToInt32(a[1]);
            Varos = a[2];
            Munka = a[3];
            Bevetel = Convert.ToInt32(a[4]);
        }

        public override string? ToString()
        {
            return $"Név: {Nev}, Kor {Kor}, Város: {Varos}, Munka: {Munka},  Bevetel {Bevetel}";
        }
    }
}
