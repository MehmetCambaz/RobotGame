using System;

namespace RobotGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(5, 5);
            Position position;
            Robot robot = new Robot(); ;

            while (true)
            {
                string[] read = Console.ReadLine().Split(' ');
                string command = read[0].ToString();
                string specs, facing = "";
                string[] q;
                int row = 0, col = 0;

                if (read.Length > 1)
                {
                    specs = read[1].ToString();
                    q = specs.Split(',');
                    row = Int32.Parse(q[0]);
                    col = Int32.Parse(q[1]);
                    facing = q[2].ToString();
                }

                switch (command)
                {
                    case "PLACE_ROBOT":
                        if(board.isCoordinateValid(col, row) & facing != null)
                        {
                            position = new Position(row, col);

                            Robot.Direction direction;

                            Enum.TryParse<Robot.Direction>(facing, out direction);

                            robot = new Robot(position, direction);
                        }
                        break;
                    case "REPORT":
                        robot.Report();
                        break;

                }
            }


        }
    }
}
