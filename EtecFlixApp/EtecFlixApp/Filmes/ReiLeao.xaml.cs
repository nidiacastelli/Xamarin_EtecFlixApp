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
	public partial class ReiLeao : ContentPage
	{
		public ReiLeao ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}