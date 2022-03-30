using MarsRover.Interfaces;

namespace MarsRover
{
    public class Mars : IMars
    {
        public Position Position { get; set; }
        public Mars(Position position)
        {
            Position = position;
        }
    }
}
