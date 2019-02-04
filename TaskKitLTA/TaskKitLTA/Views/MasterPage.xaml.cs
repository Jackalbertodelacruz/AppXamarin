using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskKitLTA.ViewsModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskKitLTA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
        public ListView ListView { get { return navigationDrawerList; } }
        public MasterPage ()
		{
			InitializeComponent ();
            BindingContext = new MasterPageViewModel();
        }
	}
}