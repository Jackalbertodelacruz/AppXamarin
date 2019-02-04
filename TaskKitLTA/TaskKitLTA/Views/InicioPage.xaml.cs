﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskKitLTA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InicioPage : ContentPage
	{
		public InicioPage ()
		{
			InitializeComponent ();
		}

        public void OnClickEntrar(object sender, EventArgs e)
        {

            // MPostAsync();
            MainPage main = new MainPage();
            Navigation.PushModalAsync(main);
        }
    }
}