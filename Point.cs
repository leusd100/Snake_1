using System;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;

        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
                x += offset;
            else if (direction == Direction.Left)
                x -= offset;
            else if (direction == Direction.Up)
                y -= offset;
            else if (direction == Direction.Down)
                y += offset;

        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        internal bool isHit(Point p)
        {
            return this.x == p.x && this.y == p.y;
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
