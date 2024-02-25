
namespace Class_in_c_
{
    internal class Fraction
    {
        private int suret, mexrec;
        public Fraction()
        {
            this.suret = 0;
            this.mexrec = 1;
        }
        public Fraction(int suret, int mexrec)
        {
            this.Suret = suret;
            this.Mexrec = mexrec;
        }
        public int Suret
        {
            get { return suret; }
            set
            {
                if (value >= 0)
                {
                    suret = value;

                }
                else
                    Console.WriteLine("Suret minimum 0 ola biler");

            }

        }

        public int Mexrec
        {
            get { return mexrec; }
            set
            {
                if (value > 0)
                {
                    mexrec = value;

                }
                else
                    Console.WriteLine("Mexrec  0 ola bilmez");

            }

        }

        public Fraction cem(Fraction fraction)
        {
            int yeniSuret = this.suret * fraction.mexrec + this.mexrec * fraction.suret;
            int yeniMexrec = this.mexrec * fraction.mexrec;
            return new Fraction(yeniSuret, yeniMexrec);
        }
        public Fraction ferq(Fraction fraction)
        {
            int yeniSuret = this.suret * fraction.mexrec - this.mexrec * fraction.suret;
            int yeniMexrec = this.mexrec * fraction.mexrec;
            return new Fraction(yeniSuret, yeniMexrec);
        }
        public Fraction hasil(Fraction fraction)
        {
            int yeniSuret = this.suret * fraction.suret;
            int yeniMexrec = this.mexrec * fraction.mexrec;
            return new Fraction(yeniSuret, yeniMexrec);
        }
        public Fraction qaliq(Fraction fraction)
        {
            int yeniSuret = this.suret * fraction.mexrec;
            int yeniMexrec = this.mexrec * fraction.suret;
            return new Fraction(yeniSuret, yeniMexrec);
        }
        public override string ToString()
        {
            return suret + "/" + mexrec;
        }
    }
}

