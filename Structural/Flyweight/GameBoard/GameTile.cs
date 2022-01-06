namespace DesignPattern.Structural.Flyweight.GameBoard
{
    class GameTile
    {
        public string Color { get; private set; }
        public string Size { get; private set; }
        public string Level { get; private set; }

        public GameTile(string color, string size, string level)
        {
            Color = color;
            Size = size;
            Level = level;
        }
    }
}
