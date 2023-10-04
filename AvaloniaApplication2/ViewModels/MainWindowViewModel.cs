using AvaloniaApplication2.Models;
using ReactiveUI;
using System;
using System.Reactive.Linq;

namespace AvaloniaApplication2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;

        public MainWindowViewModel()
        {
           Content = List = new TodoListViewModel();
        }

        public TodoListViewModel List { get; }
         
        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public void AddItem()
        {
            var vm = new AddItemViewModel();

            Observable.Merge(
                vm.Ok,
                vm.Cancel.Select(_ => (Todo)null))
                .Take(1)
                .Subscribe(model =>
                {
                    if (model != null)
                    {
                        List.Items.Add(model);
                        db.todoContext.Todos.Add(model);
                        db.todoContext.SaveChanges();
                    }

                    Content = List;
                });

            Content = vm;
        }
        public void Checked()
        {
            db.todoContext.SaveChanges();
        }
    }
}