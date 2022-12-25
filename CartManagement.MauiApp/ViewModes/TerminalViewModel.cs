using CartManagement.Domain.CommandCart;
using CartManagement.Service.Abstraction;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CartManagement.MauiApp.ViewModes
{
    public class TerminalViewModel : BaseViewModel
    {
        private readonly ICommandService _commandService;
        private ICommand _sendCommandCommand;

        public TerminalViewModel(ICommandService commandService)
        {
            _commandService = commandService;
        }

        public string InputString { get; set; }
        
        public ObservableCollection<ExecutedCommand> ExecutedCommands
        {
            get => _commandService.GetAListOfExecutedCommands();
            set => OnPropertyChanged(nameof(ExecutedCommands));
        }

        
        public ICommand SendCommandCommand
            => _sendCommandCommand ??= new Command(() =>
            {
                _commandService.SendCommand(InputString);
                ExecutedCommands = _commandService.GetAListOfExecutedCommands();
            });
    }
}
