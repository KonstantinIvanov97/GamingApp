using GamingApp.Interfaces;
using System.ComponentModel;
using Microsoft.VisualBasic.ApplicationServices;

namespace GamingApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public User CurrUser { get; set; }
        public IView View { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string property)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
