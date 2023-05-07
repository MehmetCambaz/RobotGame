﻿using System;
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

        public void Move()
        {
            int newRow = Position.Row;
            int newColumn = Position.Column;

            switch (Facing)
            {
                case Direction.NORTH:
                    newRow++;
                    break;
                case Direction.SOUTH:
                    newRow--;
                    break;
                case Direction.EAST:
                    newColumn++;
                    break;
                case Direction.WEST:
                    newColumn--;
                    break;
            }
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