using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using Nepman_BoardGame.Models;

namespace Nepman_BoardGame.Tools
{
    public class Xml_parser
    {
        public static ObservableCollection<Country> Fill_with_info(
            ObservableCollection<Country> countries, string file)
        {
            XmlDocument defines = new XmlDocument();
            defines.Load(file);
            XmlNodeList groups = defines.SelectNodes("/Countries/Outer_ring/Group")!; // static
            int g_count = groups.Count;

            int c_count = 0;
            XmlNode Xml_country;

            int id         = 0;
            string g_name  = "empty";
            string owner   = "none";
            string c_name  = "empty";
            string flag    = "empty";
            int price_base = 0;
            
            for(int i = 0; i < g_count; i++)
            {
                XmlNode current_group = groups[i]!;
                g_name = current_group.Attributes[0]!.Value;

                c_count = current_group.ChildNodes.Count;
                for(int j = 0; j < c_count; j++)
                {
                    Xml_country = current_group.ChildNodes[j]!;
                    id          = int.Parse(Xml_country.ChildNodes[0]!.InnerText);
                    c_name      = Xml_country.ChildNodes[1]!.InnerText;
                    flag        = c_name + ".png";
                    price_base  = int.Parse(Xml_country.ChildNodes[2]!.InnerText);

                    countries.Add(new Country(
                            id, g_name, c_name, flag, owner, price_base));
                }
            }
            return countries;
        }
    }
}
