using MarsRover.Actions;
using MarsRover.Constant;
using MarsRover.Enums;
using MarsRover.Interfaces;
using System;

namespace MarsRover
{
    public class Rover : IRover
    {
        public IMars Mars { get; set; }
        public IPosition Position { get; set; }
        public Directions Direction { get; set; }
        public Step Step { get; set; }
        public Rover(IMars mars, IPosition position, Directions direction)
        {
            Mars = mars;
            Position = position;
            Direction = direction;
            Step = new Step(this);
        }
        public void Go(string actions)
        {
            if (Position.X > PositionState.MaxX || Position.Y > PositionState.MaxY || Position.X < PositionState.MinX || Position.Y < PositionState.MinY)
            {
                Console.WriteLine("You are out of mars!!");
            }
            else
            {
                Step.Action(actions);
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Position.X, Position.Y, Direction);
        }
    }
}
