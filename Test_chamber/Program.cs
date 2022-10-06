using System.Collections.Generic;
using Nepman_BoardGame.Models;
using Nepman_BoardGame.Tools;
using System.Xml;
using System.Collections.ObjectModel;
using System;

namespace Test_chamber
{
    public class Program
    {
        static void Main()
        {
            Mock_UI ui = new Mock_UI();
            bool calculate = true;

            while(calculate)
            {
                ui.Say_nl("enter Y");

                double y = double.Parse(ui.ReadLine());
                double x = Math.Sqrt(y / 0.016);

                double side = 2 * (Math.Sqrt(y / 0.016));
                ui.Say_nl($"Y = {y}, Side = {side}");

                ui.Say_nl("repeat? y/n: ");
                string response = ui.ReadLine();
                switch(response)
                {
                    case "n": calculate = false; break;
                    default: break;
                }
            }


            //string file_path = "..\\..\\..\\..\\Nepman_BoardGame\\Assets\\Countries\\Defines\\" +
            //    "Country_infos.xml";

            //ObservableCollection<Country> countries = Xml_parser.Fill_with_info(
            //    new ObservableCollection<Country>(), file_path);

            //Game game = new Game();

            //List<Player> players = new List<Player>();
            //ui.Say("Enter num of players: ");
            //int player_count = int.Parse(ui.ReadLine());

            //string[] colors = {"blue", "red", "green", "yellow"};

            //for(int i = 1; i <= player_count; i++)
            //{
            //    ui.Say($"Enter name for player {i}: ");
            //    string name = ui.ReadLine();
            //    players.Add(new Player(i, name, colors[i], 0));
            //}

            //ui.Show_player(players[0]);
            //ui.Say_nl("\n");
            //ui.Show_player(players[1]);



            //int move_points = 0;
            //Location location = players[0].Location;
            //bool playing = true;
            //bool is_reversed = false;

            //ui.Say_nl("Hello " + players[0].Name);

            //#region move mechanics test

            //while(playing)
            //{
            //    ui.Say_nl("Your location is " + location.Tile_id);
            //    //ui.Display_all_info();
            //    //else ui.Say_nl($"A tile at location {location.Tile_id} is yet to be added");
            //    ui.Say_nl("Press any key to roll dice");
            //    ui.ReadKey();

            //    move_points = players[0].Roll_dice();
            //    ui.Say_nl($"You have {move_points} move points");
            //    ui.Say_nl("Press any key to move");
            //    ui.ReadKey();

            //    if(location.Tile_id + move_points > countries.Count) location.Tile_id = move_points - (39 - location.Tile_id);
            //    else location.Tile_id += move_points;

            //    //players[0].Location = location.Tile_id;
            //    ui.Say_nl("Your new location is " + players[0].Location.Tile_id);
            //    if(countries[location.Tile_id] != null) ui.Display_all_info(countries[location.Tile_id]);
            //    else ui.Say_nl($"A tile at location {location.Tile_id} is yet to be added");
            //    ui.Say_nl("repeat? y/n: ");
            //    string response = ui.ReadLine();
            //    switch(response)
            //    {
            //        case "n": playing = false; break;
            //        case "y": ui.Say_nl("Starting over"); break;
            //    }
            //}
            //#endregion move mechanics test
        }
    }
}