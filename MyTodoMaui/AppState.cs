using MyTodoMaui.Models;
using System.Collections.ObjectModel;

namespace MyTodoMaui
{
    public static class AppState
    {
        public static ObservableCollection<TodoModel> Items { get; set; } = new();
    }
}
