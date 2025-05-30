using System;
using Xamarin.Forms;
using TareasApp.Models;
using App2;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            // Cargar la lista de tareas desde la base de datos
            TareasListView.ItemsSource = await App.Database.GetTareasAsync();
        }

        private async void OnAgregarClicked(object sender, EventArgs e)
        {
            // Navegar a la página de creación de tarea
            await Navigation.PushAsync(new TareaPage());
        }

        private async void OnTareaSeleccionada(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Tarea tarea)
            {
                // Navegar a la página de edición con la tarea seleccionada
                await Navigation.PushAsync(new TareaPage(tarea));
                // Deseleccionar la tarea después de seleccionarla
                TareasListView.SelectedItem = null;
            }
        }
    }
}
