﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlixApp.Filmes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Joker : ContentPage
	{
		public Joker ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}