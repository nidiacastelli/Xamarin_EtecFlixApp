﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlixApp.Categorias
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Drama : ContentPage
	{
		public Drama ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}