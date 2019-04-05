using System.Collections.Generic;

namespace snake
{
    internal class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            //отрисовка рамочки
            HLine upLine = new HLine(0, mapWidth - 2, 0, '+');
            HLine downLine = new HLine(0, mapWidth - 2, mapHeight - 1, '+');
            VLine leftLine = new VLine(0, mapHeight - 1, 0, '+');
            VLine rightLine = new VLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;

        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }

        }
    }
}