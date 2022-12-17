using MauiAppNet7.Service.Abstractions;
using System.Windows.Input;

namespace MauiAppNet7.ViewModes
{
    public class CartControlViewModel : BaseViewModel
    {
        private DateTime _dateTime;
        private Timer _timer;
        private string _inputString = "";
        private string _countCommandCompleted = "0";
        private readonly ICommandService _commandService;

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

        public ICommand ButtonCommand { get; }

        public string InputString
        {
            get => _inputString;
            private set
            {
                if (_inputString != value)
                {
                    _inputString = value;
                    _commandService.SendCommand(InputString);
                    CountCommandCompleted = _commandService.GetAListOfExecutedCommands().Count().ToString();
                }
            }
        }

        public string CountCommandCompleted {
            get => _countCommandCompleted;
            set
            {
                if (_countCommandCompleted != value)
                {
                    _countCommandCompleted = value;
                    OnPropertyChanged();
                }
            }
        }

        public CartControlViewModel(ICommandService commandService)
        {
            CountCommandCompleted = "0";
            _commandService = commandService;

            ButtonCommand = new Command((key) => InputString += key);

            _timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now),
                null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }
    }
}

