namespace Nepman_BoardGame.Models
{
    public sealed class Location
    {
        private string _map_segment = "Start";
        private int    _tile_id     = 0;

        public int Tile_id
        {
            get { return _tile_id; }
            set { _tile_id = value; }
        }

        public string Map_segment
        {
            get { return _map_segment; }
            set { _map_segment = value; }
        }
    }
}
