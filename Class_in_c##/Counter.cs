namespace Class_in_c_
{
    public class Counter
    {
        private int min, max, current;

        public Counter(int min, int max)
        {
            this.Min = min;
            this.Max = max;
            this.current = min;
        }
        public int Min
        {
            get { return min; }
            set
            {
                if (value >= 0)
                {
                    min = value;
                    return;

                }
                else
                    Console.WriteLine("Minimum 0 daxil edile biler");
            }
        }
        public int Max
        {
            get { return max; }
            set
            {
                if (value <= 100)
                {
                    max = value;
                    return;

                }
                else
                    Console.WriteLine("Maksimum 100 daxil edile biler");
            }
        }
        public void increment()
        {
            if (current == max)
            {
                Console.WriteLine("Max ededi kecmek olmaz");

            }
            else
                current++;
        }
        public void decrement()
        {
            if (current == min)
            {
                Console.WriteLine("Min ededi kecmek olmaz");

            }
            else
                current--;
        }
        public void showdata()
        {
            Console.WriteLine($"Min-->{min},Max-->{max},Current-->{current}");
        }
    }
}