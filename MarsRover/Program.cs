using MarsRover.Constant;
using MarsRover.Enums;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Mars mars = new Mars(new Position(PositionState.MaxX, PositionState.MaxY));

            //Rover 1
            Rover one = new Rover(mars, new Position(1, 2), Directions.N);
            one.Go("LMLMLMLMM");
            Console.WriteLine(one.ToString());

            //Rover 2
            Rover two = new Rover(mars, new Position(3, 3), Directions.E);
            two.Go("MMRMMRMRRM");
            Console.WriteLine(two.ToString());  
        }
    }
}
