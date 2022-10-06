using Nepman_BoardGame.Models;
using Nepman_BoardGame.Views;


namespace Nepman_BoardGame.ViewModels
{
    public class Tile_view_straight_View : Base_ViewModel
    {

        static int id = 1;
        static string g_name = "Airport";
        static string c_name = "australia";
        static string flag = "D:\\Documents\\Coding\\offline_repos\\cs\\Nepman_BoardGame\\Nepman_BoardGame\\Assets\\Countries\\Flags\\Australia.png";
        static string owner = "none";
        int price = 25000;

        public Country au = new Country(
            1, "Airport", "Australia", flag, "none", 25000);

    }
}
