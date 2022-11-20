using MauiAppNet7.Service.Abstractions;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiAppNet7.ViewModes
{
    public class CartControlViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime _dateTime;
        private Timer _timer;
        private string _inputString = "";
        private ICommandService _commandService;

        public DateTime DateTime
        {
            get => _dateTime;
            set
            {
                if (_dateTime != value)
                {
                    _dateTime = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand ButtonCommand { get; private set; }

        public string InputString
        {
            get => _inputString;
            private set
            {
                if (_inputString != value)
                {
                    _inputString = value;
                    OnPropertyChanged();
                    //DisplayText = FormatText(_inputString);
                    // Perhaps the delete button must be enabled/disabled.
                    //((Command)DeleteCharCommand).ChangeCanExecute();
                }
            }
        }

        public CartControlViewModel()
        {
            //_commandService = commandService;

            ButtonCommand = new Command((key) => InputString += key);

            _timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now),
                null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

