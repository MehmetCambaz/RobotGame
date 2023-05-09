using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGame
{
    public class Robot
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

            // move robot to the facing if there is no wall or border
            switch (Facing)
            {
                case Direction.NORTH:
                    var wall = board.WallList.FirstOrDefault(o => o.Row == newRow + 1 & o.Column == newColumn);

                    if(wall == null & board.isCoordinateValid(newRow + 1, newColumn))
                    {
                        newRow++;
                    }
                    break;
                case Direction.SOUTH:
                    var wall_south = board.WallList.FirstOrDefault(o => o.Row == newRow - 1 & o.Column == newColumn);

                    if (wall_south == null & board.isCoordinateValid(newRow - 1, newColumn))
                        newRow--;
                    break;
                case Direction.EAST:
                    var wall_east = board.WallList.FirstOrDefault(o => o.Row == newRow & o.Column == newColumn + 1);

                    if (wall_east == null & board.isCoordinateValid(newRow, newColumn + 1))
                        newColumn++;
                    break;
                case Direction.WEST:
                    var wall_west = board.WallList.FirstOrDefault(o => o.Row == newRow & o.Column == newColumn - 1);

                    if (wall_west == null & board.isCoordinateValid(newRow, newColumn - 1))
                        newColumn--;
                    break;
            }
            Position.Row = newRow;
            Position.Column = newColumn;
        }

        public void TurnLeft()
        {
            // turn the robot 90 degrees to its left
            switch (Facing)
            {
                case Direction.NORTH:
                    Facing = Direction.WEST;
                    break;
                case Direction.SOUTH:
                    Facing = Direction.EAST;
                    break;
                case Direction.EAST:
                    Facing = Direction.NORTH;
                    break;
                case Direction.WEST:
                    Facing = Direction.SOUTH;
                    break;
            }
        }

        public void TurnRight()
        {
            // turn the robot 90 degrees to its right
            switch (Facing)
            {
                case Direction.NORTH:
                    Facing = Direction.EAST;
                    break;
                case Direction.SOUTH:
                    Facing = Direction.WEST;
                    break;
                case Direction.EAST:
                    Facing = Direction.SOUTH;
                    break;
                case Direction.WEST:
                    Facing = Direction.NORTH;
                    break;
            }
        }

        public void Report()
        {
            Console.WriteLine("{0},{1},{2}", Position.Row, Position.Column, Facing);
        }
    }
}
