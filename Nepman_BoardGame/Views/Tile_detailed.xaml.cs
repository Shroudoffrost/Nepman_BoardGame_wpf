using System.Windows;
using System.Windows.Controls;
using Nepman_BoardGame.Models;

namespace Nepman_BoardGame.Views
{
    public partial class Tile_detailed : UserControl
    {
        public string Group_name
        {
            get { return (string)GetValue(Group_nameProperty); }
            set { SetValue(Group_nameProperty, value); }
        }

        public static readonly DependencyProperty Group_nameProperty =
            DependencyProperty.Register(
                "Group_name", typeof(string), typeof(Tile_detailed));

        public Tile_detailed()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
