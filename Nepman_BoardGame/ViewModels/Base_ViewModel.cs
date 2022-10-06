using System.ComponentModel;

namespace Nepman_BoardGame.ViewModels
{
    public class Base_ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
