namespace DesignPattern.Structural.Flyweight.GameBoard
{
    class GameTileBorder
    {
        public string Style { get; private set; }
        public string Thickness { get; private set; }
        public GameTile Tile { get; private set; }

        public GameTileBorder(string style, string thickness, string color, string size, string level)
        {
            this.Style = style;
            this.Thickness = thickness;
            this.Tile = GameTileFactory.CreateTile(color, size, level);
        }

    }
}
