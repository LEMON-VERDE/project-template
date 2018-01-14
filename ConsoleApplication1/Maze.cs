using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Maze
    {
        public class Coordinates
        {
            public uint x;
            public uint y;

            public Coordinates(uint x, uint y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public const int BLOCKED = -1;
        public const int NOMINAL = 1;
        public const int FREE = 0;

        int[][] grid;

        Coordinates startPosition;
        Coordinates endPosition;

        public int valueAt(uint x, uint y)
        {
            int value;

            value = grid[x][y];

            return value;
        }
        public int valueAt(Coordinates position)
        {
            return valueAt(position.x, position.y);
        }

        public bool isTraversible(uint x, uint y)
        {
            return grid[x][y] >= 0;
        }

        public bool isTraversible(Coordinates position)
        {
            return grid[position.x][position.y] < 0;
        }
    }
}
