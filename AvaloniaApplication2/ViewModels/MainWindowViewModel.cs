using AvaloniaApplication2.Service;
using System.Linq;

namespace AvaloniaApplication2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            List = new TodoListViewModel();
        }
        public TodoListViewModel List { get; }
    }
}