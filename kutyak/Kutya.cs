using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutyak
{
    class Kutya
    {
        int id;
        string nev;
        string fajta;
        int suly;
        DateTime szulDatum;

        public string Nev { get => nev; set => nev = value; }
        public string Fajta { get => fajta; set => fajta = value; }
        public int Suly { get => suly; set => suly = value; }
        public DateTime SzulDatum { get => szulDatum; set => szulDatum = value; }
        public int Id { get => id; set => id = value; }

        public Kutya(int id,string nev, string fajta, int suly, DateTime szulDatum)
        {
            Id = id;
            Nev = nev;
            Fajta = fajta;
            Suly = suly;
            SzulDatum = szulDatum;
        }

        public override string ToString()
        {
            return nev;
        }
    }
}
