using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskKitLTA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PendienteNuevoPage : ContentPage
	{
		public PendienteNuevoPage ()
		{
			InitializeComponent ();
		}
        public void ClickNuevoPendiente(object sender, EventArgs e)
        {
            try
            {
                BD.TaskRepository.Instancia.AddPendientes(txtTitulo.Text, txtDescripcion.Text, dtmFecha.Date);
                DisplayAlert("Mensaje","Agredo","OK");
                limpiar();
                //var allpendiente = BD.TaskRepository.Instancia.GetAllPendientes();
                //ltyPendientes.ItemsSource = allpendiente;
            } catch(Exception exMss)
            {
                DisplayAlert("Error","No agregado", "OK");
            }
        }

        public void limpiar()
        {
            txtDescripcion.Text = "";
            txtTitulo.Text = "";
        }
	}
}