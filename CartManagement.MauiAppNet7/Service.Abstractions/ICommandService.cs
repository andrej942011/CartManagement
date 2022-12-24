using CartManagement.Domain.CommandCart;
using System.Collections.ObjectModel;

namespace MauiAppNet7.Service.Abstractions
{
    public interface ICommandService
    {
        void SendCommand(string command);

        public ObservableCollection<ExecutedCommand> GetAListOfExecutedCommands();
    }
}
