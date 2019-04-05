using System;
using System.Collections.Generic;
using System.Linq;

namespace snake
{
    class Snake : Figure
    {
        Direction _direction;

        public Snake(Point tail, int length, Direction direction)
        {
            _direction = direction;

            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear();
            head.Draw();

        }

        internal bool IsHitTail()
        {
            Point head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.isHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;

        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.isHit(food))
            {
                food.Clear();
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                _direction = Direction.Left;
            if (key == ConsoleKey.RightArrow)
                _direction = Direction.Right;
            if (key == ConsoleKey.UpArrow)
                _direction = Direction.Up;
            if (key == ConsoleKey.DownArrow)
                _direction = Direction.Down;
        }
    }
}
