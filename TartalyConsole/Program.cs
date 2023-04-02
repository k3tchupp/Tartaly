using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TartalyConsole
{
    class Tartaly
    {
        string nev;
        int a;
        int b;
        int c;
        double aktLiter;

        public Tartaly(string nev, int a, int b, int c)
        {
            this.nev = nev;
            this.a = a;
            this.b = b;
            this.c = c;
            this.aktLiter = 0;
        }

        public Tartaly(string nev)
        {
            this.a = 10;
            this.b = 10;
            this.c = 10;
            this.nev = nev;
            this.aktLiter = 0;
        }

        public int A { get { return a; } }
        public int B { get { return b; } }
        public int C { get { return c; } }
        public double Terfogat
        {
            get { return a * b * c; }
        }

        public void DuplazMeretet()
        {
            a = a * 2;
        }
        public void TeljesLeengedes()
        {
            aktLiter = 0;
        }

        public double Toltottseg
        {
            get { return (aktLiter / (Terfogat / 1000)) * 100; }
        }

        public void Tolt(double liter)
        {
            double toltesszazalek = ((aktLiter + liter) / (Terfogat / 1000)) * 100;

            if (toltesszazalek > 100)
            {
                throw new OverflowException("Több van a tartáyban mint amennyi lehet");
            }
            else
            {
                aktLiter += liter;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Tartaly nagytartaly, literes;

                nagytartaly = new Tartaly("nagytartaly", 500, 200, 120);
                literes = new Tartaly("literes", 10, 10, 10);


            }
        }
    }
}
