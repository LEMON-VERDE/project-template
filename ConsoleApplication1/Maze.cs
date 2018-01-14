using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Maze
    {
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
            int value;

            value = valueAt(position.x, position.y);

            return value;
        }

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
    }
}
