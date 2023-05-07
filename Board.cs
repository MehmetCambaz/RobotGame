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
        public List<Wall> WallList = new List<Wall>();
        public Board(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
        }

        public Board()
        {

        }

        public bool isCoordinateValid(int x, int y)
        {
            if (x < rows & x > 1)
                if (y < cols & y > 1)
                    return true;
            return false;
        }

        public void PlaceWall(int row, int col)
        {
            // Check if the given coordinates are valid
            if (row < 1 || row > rows || col < 1 || col > cols)
            {
                Console.WriteLine("Invalid coordinates!");
                return;
            }

            WallList.Add(new Wall(row, col));
        }
            
    }
}
