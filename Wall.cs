using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame
{
    public class Wall
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Wall(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
