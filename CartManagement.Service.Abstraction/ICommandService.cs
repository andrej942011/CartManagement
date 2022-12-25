using System.Collections.ObjectModel;
using CartManagement.Domain.CommandCart;

namespace CartManagement.Service.Abstraction
{
    public interface ICommandService
    {
        void SendCommand(string command);

        public ObservableCollection<ExecutedCommand> GetAListOfExecutedCommands();
    }
}
