namespace CartManagement.Domain.CommandCart
{
    public class ExecutedCommand
    {
        public int Id { get; set; }
        public DateTime TimeOfCreation { get; set; }
        public string TextCommand { get; set; }
    }
}
