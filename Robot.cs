using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame
{
    class Robot
    {
        public enum Direction
        {
            NORTH,
            SOUTH,
            EAST,
            WEST
        }

        public Position Position { get; set; }
        public Direction Facing { get; set; }

        public Robot(Position position, Direction facing)
        {
            Position = position;
            this.Facing = facing;
        }

        public Robot()
        {
   
        }

        public void Move(Board board)
        {
            int newRow = Position.Row;
            int newColumn = Position.Column;

            switch (Facing)
            {
                case Direction.NORTH:
                    var wall = board.WallList.FirstOrDefault(o => o.Row == newRow++);

                    if(wall == null)
                        newRow++;
                    break;
                case Direction.SOUTH:
                    var wall_south = board.WallList.FirstOrDefault(o => o.Row == newRow--);

                    if (wall_south == null)
                        newRow--;
                    break;
                case Direction.EAST:
                    var wall_east = board.WallList.FirstOrDefault(o => o.Row == newColumn++);

                    if (wall_east == null)
                        newColumn++;
                    break;
                case Direction.WEST:
                    var wall_west = board.WallList.FirstOrDefault(o => o.Row == newColumn--);

                    if (wall_west == null)
                        newColumn--;
                    break;
            }
            Position.Row = newRow;
            Position.Column = newColumn;
        }

        public void TurnLeft()
        {
            // turn the robot 90 degrees to its left
        }

        public void TurnRight()
        {
            // turn the robot 90 degrees to its right
        }

        public void Report()
        {
            Console.WriteLine("{0},{1},{2}", Position.Row, Position.Column, Facing);
        }
    }
}
