using System.Windows.Input;
using CartManagement.Service.Abstraction;

namespace CartManagement.MauiApp.ViewModes
{
    public class CartControlViewModel : BaseViewModel
    {
        private DateTime _dateTime;
        private Timer _timer;
        private readonly ICommandService _commandService;

        public CartControlViewModel(ICommandService commandService)
        {
            _commandService = commandService;

            _timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now),
                null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

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

        public ICommand ButtonCommand
            =>  new Command((key) =>
            {
                InputString = key.ToString();
                _commandService.SendCommand(InputString);
            });

        public string InputString { get; set; }
    }
}

