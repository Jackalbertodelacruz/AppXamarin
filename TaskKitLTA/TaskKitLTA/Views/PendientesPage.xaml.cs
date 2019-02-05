using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskKitLTA.BD;
using TaskKitLTA.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskKitLTA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PendientesPage : ContentPage
	{
		public PendientesPage ()
		{
			InitializeComponent ();
            Mostrar();
		}

        public void btnAgregar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PendienteNuevoPage());
        }
        public void btnRefrescar(object sender, EventArgs e)
        {
            Mostrar();
        }
        //public async Task BackButtonPressed()
        //{
        //    var action = await DisplayAlert("Exit?", "Are you sure to close", "Yes", "No");
        //    if (action)
        //    {
        //        //  Navigate to first page
        //    }
        //}
        public async void btnEliminarAsync(object sender, EventArgs e)
        {


            await EliminarAsync();

        }

        public async Task EliminarAsync()
        {

            var action = await DisplayAlert("Mensaje", "Decea Eliminar el pendiente?", "SI", "NO");
            if (action)
            {
                if (lst.SelectedItem == null)
                {
                    await DisplayAlert("Mensaje", "Selecciona item", "OK");
                }
                else
                {
                    var pendientes = new PendientesBD
                    {
                        Id = id,
                        Descripcion = des,
                        Titulo = titulo,
                        Fecha = fecha
                    };
                    TaskRepository.Instancia.EliminarPicking(pendientes);
                    await DisplayAlert("Mensaje", "Eliminado Correctamente", "OK");
                }
                Mostrar();
            }
            
        }
        public void Mostrar()
        {
            var allpendiente = TaskRepository.Instancia.GetAllPendientes();
            lst.ItemsSource = allpendiente;
            //ltyPendientes.ItemsSource = allpendiente;
        }
        public int id;
        public string titulo;
        public string des;
        public DateTime fecha;

        public void OnItemTapped(Object sender, ItemTappedEventArgs e)
        {
            var dataItem = (BD.PendientesBD)(e.Item);
            des = dataItem.Descripcion;
            titulo = dataItem.Titulo;
            fecha = dataItem.Fecha;
            id = dataItem.Id;


        }

    }
}