using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame
{
    class Board
    {
        private int rows;
        private int cols;
        public Board(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
        }
        public bool isCoordinateValid(int x, int y)
        {
            if (x < rows & x > 1)
                if (y < cols & y > 1)
                    return true;
            return false;
        }
    }
}
