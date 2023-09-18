using AvaloniaApplication2.Service;

namespace AvaloniaApplication2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new TodoListViewModel(db.GetItems());
        }
        public TodoListViewModel List { get; }
    }
}