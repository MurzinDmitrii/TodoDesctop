using AvaloniaApplication2.Service;
using ReactiveUI;
using System.Linq;

namespace AvaloniaApplication2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;

        public MainWindowViewModel()
        {
           Content= List = new TodoListViewModel();
        }

        public TodoListViewModel List { get; }

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public void AddItem()
        {
            Content = new AddItemViewModel();
        }
    }
}