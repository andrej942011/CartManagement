using System.Collections.ObjectModel;
using CartManagement.Domain.CommandCart;
using CartManagement.Service.Abstraction;
using CartManagement.Service.Extentions;

namespace CartManagement.Service
{
    public class CommandService : ICommandService
    {
        private ObservableCollection<ExecutedCommand> _executedCommands;
        private int _id = 0;
        public CommandService()
        {
            _executedCommands = new ObservableCollection<ExecutedCommand>();
        }

        public void SendCommand(string command)
        {
            _id++;

            _executedCommands.Add(new ExecutedCommand()
            {
                TextCommand = command,
                TimeOfCreation = DateTime.Now,
                Id = _id
            });

            var sortedCollection = _executedCommands
                .OrderByDescending(x => x.Id)
                .ToList();

            _executedCommands.OrderByReference(sortedCollection);
        }

        public ObservableCollection<ExecutedCommand> GetAListOfExecutedCommands()
        {
            return _executedCommands;
        }
    }
}
