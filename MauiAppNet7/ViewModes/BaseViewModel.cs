using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiAppNet7.ViewModes
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (field.Equals(value))
                return false;

            field = value;

            OnPropertyChanged(propertyName);

            return true;
        }
    }
}
