namespace Class_in_c_
{
    public class Class_Point
    {

        private int x;
        public int x_
        {
            get { return x; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Menfi eded daxil edile bilmez");
                    return;
                }
                x = value;

            }
        }
        private int y;
        public int y_
        {
            get { return y; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Menfi eded daxil edile bilmez");
                    return;
                }
                y = value;

            }
        }

        public void showdata()
        {
            Console.WriteLine($"x-->{x}, y-->{y}");
        }
        public Class_Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Class_Point(int x, int y)
        {
            this.x_ = x;
            this.y_ = y;
        }
    }
}
