using MarsRover.Enums;

namespace MarsRover.Interfaces
{
    public interface IRover
    {
        IMars Mars { get; set; }
        IPosition Position { get; set; }
        Directions Direction { get; set; }
        void Go(string actions);
    }
}
