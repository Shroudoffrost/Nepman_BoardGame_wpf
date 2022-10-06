using Nepman_BoardGame.Models;

namespace Test_chamber
{
    public sealed class Mock_UI
    {
        //string Basic_info = "D:\\Documents\\Coding\\offline_repos\\cs\\Nepman_BoardGame\\Nepman_BoardGame\\Assets\\Countries\\Defines\\Basic_info.xml";
        //string Basic_info = "..\\..\\..\\..\\Nepman_BoardGame\\Assets\\Countries\\Defines\\Country_infos.xml";

        public void Display_all_info(Country country)
        {
            System.Console.WriteLine(country.Release_info());
        }

        public void Show_player(Player player)
        {
            System.Console.WriteLine(player.Introduce());
        }

        public void Say(string something)
        {
            System.Console.Write(something);
        }

        public void Say_nl(string something)
        {
            System.Console.WriteLine(something);
        }

        public void ReadKey()
        {
            System.Console.ReadKey();
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public void Ask()
        {
            System.Console.ReadLine();
        }
    }
}
