namespace Nepman_BoardGame.Models
{
    public sealed class Country
    {
        private int    _id               = 0;
        private string _group            = "Empty";
        private string _name             = "Empty";
        private string _owner            = "none";
        private string _flag             = "Empty";
        private int    _price_base       = 0;
        private int    _price_monopoly   = 0;
        private int    _revenue_base     = 0;
        private int    _revenue_monopoly = 0;

        public int ID
        { 
            get { return _id; }
            set { _id = value; }
        }

        public string Group_name
        {
            get { return _group; }
            set { _group = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public string Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        public int Price_base
        {
            get { return _price_base; }
            set { _price_base = value; }
        }

        public int Price_monopoly
        {
            get { return _price_monopoly; }
            set { _price_monopoly = value; }
        }

        public int Revenue_base
        {
            get { return _revenue_base; }
            set { _revenue_base = value; }
        }

        public int Revenue_monopoly
        {
            get { return _revenue_monopoly; }
            set { _revenue_monopoly = value; }
        }

        public Country() { }

        public Country(
            int id, string group_name, string name, string flag, string owner,
            int price_base)
        {
            ID = id;
            Group_name = group_name;
            Name = name;
            Flag = flag;
            Owner = owner;
            Price_base = price_base;
            Price_monopoly = Price_base * 2;
            Revenue_base = Price_base / 5;
            Revenue_monopoly = Revenue_base * 2;
        }

        public string Release_info()
        {
            return $"\n====== start ====\n"+
            ID+"\n"+
            Group_name+"\n"+
            Name+"\n"+
            Price_base+" "+Revenue_base+"\n"+
            Price_monopoly+" "+Revenue_monopoly+"\n"+
            "Owner: "+_owner+"\n"+
            "Flag: "+ _flag+
            "\n======== end ====\n";
        }
    }
}
