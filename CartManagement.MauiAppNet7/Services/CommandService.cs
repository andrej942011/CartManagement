using System.Collections.ObjectModel;
using CartManagement.Domain.CommandCart;
using MauiAppNet7.Service.Abstractions;

namespace MauiAppNet7.Services
{
    internal class CommandService : ICommandService
    {
        private ObservableCollection<ExecutedCommand> _executedCommands;
        public CommandService()
        {
            _executedCommands = new ObservableCollection<ExecutedCommand>();
        }

        public void SendCommand(string command)
        {
            _executedCommands.Add(new ExecutedCommand()
            {
                TextCommand = command,
                TimeOfCreation = DateTime.Now
            });
        }

        public ObservableCollection<ExecutedCommand> GetAListOfExecutedCommands()
        {
            return _executedCommands;
        }
    }
}
