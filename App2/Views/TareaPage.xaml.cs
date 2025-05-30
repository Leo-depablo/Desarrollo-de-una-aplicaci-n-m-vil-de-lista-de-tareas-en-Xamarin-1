using App2;
using System;
using TareasApp.Models;
using Xamarin.Forms;

uusing System;
using Xamarin.Forms;
using TareasApp.Models;

namespace TareasApp
{
    public partial class TareaPage : ContentPage
    {
        private Tarea _tarea;

        public TareaPage()
        {
            InitializeComponent();
            _tarea = new Tarea();
        }

        public TareaPage(Tarea tarea)
        {
            InitializeComponent();
            _tarea = tarea;

            nombreEntry.Text = _tarea.Nombre;
            descripcionEditor.Text = _tarea.Descripcion;
            eliminarButton.IsVisible = true;
        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            _tarea.Nombre = nombreEntry.Text?.Trim();
            _tarea.Descripcion = descripcionEditor.Text?.Trim();

            if (string.IsNullOrWhiteSpace(_tarea.Nombre))
            {
                await DisplayAlert("Error", "El nombre de la tarea es obligatorio.", "OK");
                return;
            }

            await App.Database.SaveTareaAsync(_tarea);
            await Navigation.PopAsync();
        }

        private async void OnEliminarClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Confirmar", "¿Eliminar esta tarea?", "Sí", "No");
            if (confirm)
            {
                await App.Database.DeleteTareaAsync(_tarea);
                await Navigation.PopAsync();
            }
        }
    }
}
