using System;
using Xamarin.Forms;
using TareasApp.Models;
using App2;

namespace App2
{
    public partial class TareaPage : ContentPage
    {
        private Tarea _tarea;

        public TareaPage()
        {
            InitializeComponent();
            _tarea = new Tarea();
            BindingContext = _tarea;
        }

        public TareaPage(Tarea tarea)
        {
            InitializeComponent();
            _tarea = tarea;
            BindingContext = _tarea;

            nombreEntry.Text = _tarea.Nombre;
            descripcionEditor.Text = _tarea.Descripcion;
            eliminarButton.IsVisible = true;
        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            _tarea.Nombre = nombreEntry.Text;
            _tarea.Descripcion = descripcionEditor.Text;

            await App.Database.SaveTareaAsync(_tarea);
            await Navigation.PopAsync();
        }

        private async void OnEliminarClicked(object sender, EventArgs e)
        {
            var confirm = await DisplayAlert("Eliminar", "¿Deseas eliminar esta tarea?", "Sí", "No");
            if (confirm)
            {
                await App.Database.DeleteTareaAsync(_tarea);
                await Navigation.PopAsync();
            }
        }
    }
}
