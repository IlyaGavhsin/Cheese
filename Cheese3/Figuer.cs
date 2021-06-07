using System;
// Гавшин Илья 220 шахматы 3.0 

namespace Chess
{
    using System;
    // Гавшин Илья 220 шахматы 3.0 

    namespace Chess
    {
        class Program
        {
            static void Main(string[] args)
            {
                King k = new King(1, 1);
                Console.WriteLine(k.Move(2, 2));
                Console.WriteLine(k.Move(1, 2));
                Console.WriteLine(k.Move(2, 2));
                Console.WriteLine(k.Move(3, 2));

                Queen q = new Queen(2, 2);
                Console.WriteLine(Environment.NewLine + q.Move(3, 2));
                Console.WriteLine(q.Move(2, 3));
                Console.WriteLine(q.Move(5, 5));
                Console.WriteLine(q.Move(5, 6));

                Bishop b = new Bishop(2, 2);
                Console.WriteLine(Environment.NewLine + b.Move(3, 2));
                Console.WriteLine(b.Move(2, 3));
                Console.WriteLine(b.Move(5, 5));
                Console.WriteLine(b.Move(5, 6));

                Rook r = new Rook(2, 2);
                Console.WriteLine(Environment.NewLine + r.Move(8, 2));
                Console.WriteLine(r.Move(2, 3));
                Console.WriteLine(r.Move(5, 5));
                Console.WriteLine(r.Move(5, 6));

                Knight n = new Knight(2, 2);
                Console.WriteLine(Environment.NewLine + n.Move(4, 3));
                Console.WriteLine(n.Move(2, 3));
                Console.WriteLine(n.Move(5, 5));
                Console.WriteLine(n.Move(5, 6));

            }
        }
    }
        class Figure
    {
        protected int x;
        protected int y;

        public virtual bool Move(int newX, int newY)
        {
            return false;
        }

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    
    class King: Figure
    {
        public King(int x, int y) : base(x, y){}
        
        public override bool Move(int newX, int newY)
        {
            if ((Math.Abs(x - newX) <= 1) && (Math.Abs(y - newY) <= 1))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Queen : Figure
    {
        public Queen(int x, int y) : base(x, y) { }

        public override bool Move(int newX, int newY)
        {
            if ((Math.Abs(x - newX) == Math.Abs(y - newY)) || ((x == newX) || (y == newY)))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Bishop : Figure
    {
        public Bishop(int x, int y) : base(x, y) { }

        public override bool Move(int newX, int newY)
        {
            if (Math.Abs(x - newX) == Math.Abs(y - newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Rook : Figure
    {
        public Rook(int x, int y) : base(x, y) { }

        public override bool Move(int newX, int newY)
        {
            if ((x == newX) || (y == newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Knight : Figure
    {
        public Knight(int x, int y) : base(x, y) { }

        public override bool Move(int newX, int newY)
        {
            if ((Math.Max(Math.Abs(x - newX), Math.Abs(y - newY)) == 2) && (Math.Min(Math.Abs(x - newX), Math.Abs(y - newY)) == 1))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
