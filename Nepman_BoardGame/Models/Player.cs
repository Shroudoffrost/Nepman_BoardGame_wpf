using System;

namespace Nepman_BoardGame.Models
{
    public sealed class Player
    {
        private int    _id       = 0;
        private string _name     = "test_name";
        private string _color    = "Empty";
        private int    _cash     = 0;
        private int    _debt     = 0;
        private Location _location;
        
        public bool is_in_Jail = false;
        public int  move_pints = 0;
        Random _dice            = new Random();

        public Player(int id, string name, string color, int cash)
        {
            ID = id;
            Name = name;
            Color = color;
            Cash = cash;
            Location.Map_segment = "Start";
            Location.Tile_id     = 0;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        public int Debt
        {
            get { return _debt; }
            set { _debt = value; }
        }

        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string Introduce()
        {
            return Name + ", " + Color + ", " + Cash.ToString();
        }

        public override string ToString()
        {
            return Name;
        }


        public int Roll_dice()
        {
            return 1 + _dice.Next(6);
        }

        public void Buy(Country c)
        {
            if(c.Owner == "none" && c.Price_base <= this.Cash)
            {
                c.Owner = this.Name;
            }
            else return;
        }

        public void Sell(Country c)
        {
            // TODO: check if player has monopoly

            if(c.Owner == this.Name)
            {
                this.Cash = c.Price_base;
                c.Owner = "none";
            }
            else return;
        }
    }
}
