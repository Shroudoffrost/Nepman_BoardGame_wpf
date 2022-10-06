using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nepman_BoardGame.Views
{
    public partial class Tile_mini : UserControl
    {
        public Tile_mini()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string Tile_name
        {
            get { return (string)GetValue(Tile_nameProperty); }
            set { SetValue(Tile_nameProperty, value); }
        }

        public static readonly DependencyProperty Tile_nameProperty =
            DependencyProperty.Register(
                "Tile_name", typeof(string), typeof(Tile_mini), new PropertyMetadata("none"));
    }
}
