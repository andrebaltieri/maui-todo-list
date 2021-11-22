using Microsoft.Maui.Controls;
using MyTodoMaui.Models;
using System;

namespace MyTodoMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            myListView.ItemsSource = AppState.Items;
            AppState.Items.Add(new TodoModel() { Id = 1, Title = "Ir ao supermercado", CreatedAt = DateTime.Now, Done = false });
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            AppState.Items.Add(new TodoModel() { Id = 2, Title = "Ir a academia", CreatedAt = DateTime.Now, Done = false });
        }
    }
}
