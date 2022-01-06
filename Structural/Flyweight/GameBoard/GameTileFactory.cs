namespace DesignPattern.Structural.Flyweight.GameBoard
{
    class GameTileFactory
    {
        public static Dictionary<String, GameTile>? Tiles = new Dictionary<String, GameTile>();

        public static GameTile CreateTile(string color, string size, string level)
        {
            HashSet<String> d5 = new HashSet<String>();
            d5.Add(color + size + level);
            var x = d5.FirstOrDefault().ToString();
            if (!Tiles.ContainsKey(d5.FirstOrDefault().ToString()))
            {
                GameTile newTile = new GameTile(color, size, level);
                Tiles.Add(d5.FirstOrDefault().ToString(), newTile);
            }
            return Tiles.GetValueOrDefault(d5.FirstOrDefault().ToString());
        }
    }
}
