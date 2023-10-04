using AvaloniaApplication2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication2.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel()
        {
            Items = Models.db.todoContext.Todos.ToList();
        }
        public List<Todo> Items { get; }

    }
}
