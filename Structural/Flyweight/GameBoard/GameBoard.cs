namespace DesignPattern.Structural.Flyweight.GameBoard
{
    class GameBoard
    {
        private List<GameTileBorder>? Tiles = new List<GameTileBorder>();

        public List<GameTileBorder> GetTiles() => Tiles;

        public void AddTile(GameTileBorder gameTile)
        {
            Tiles.Add(gameTile);
        }


    }
}
