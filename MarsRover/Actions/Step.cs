using MarsRover.Enums;
using MarsRover.Interfaces;
using System;
using System.Collections.Generic;

namespace MarsRover.Actions
{
    public class Step
    {
        Dictionary<char, Action> StepList;
        private readonly IRover _rover;
        public Step(Rover rover)
        {
            StepList = new Dictionary<char, Action>
            {
                { 'L', Left },
                { 'R', Right },
                { 'M', Rotary }
            };

            _rover = rover;
        }
        private void Right()
        {
            _rover.Direction = (_rover.Direction + 1) > Directions.W ? Directions.N : _rover.Direction + 1;
        }
        private void Left()
        {
            _rover.Direction = (_rover.Direction - 1) < Directions.N ? Directions.W : _rover.Direction - 1;
        }

        private void Rotary()
        {
            if (_rover.Direction == Directions.N)
            {
                _rover.Position.Y++;
            }
            else if (_rover.Direction == Directions.S)
            {
                _rover.Position.Y--;
            }
            else if (_rover.Direction == Directions.W)
            {
                _rover.Position.X--;
            }
            else if (_rover.Direction == Directions.E)
            {
                _rover.Position.X++;
            }
        }

        public void Action(string actions)
        {
            foreach (var action in actions)
            {
                if (!StepList.ContainsKey(action))
                {
                    throw new ArgumentException(string.Format("Invalid step: {0}", action));
                }
                StepList[action]();
            }
        }
    }
}
