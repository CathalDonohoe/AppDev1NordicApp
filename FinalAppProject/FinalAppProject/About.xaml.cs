using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalAppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class About : ContentPage
	{
		public About ()
		{
			InitializeComponent ();
		}

        //button to move to contact page
        private void btnContact_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Contact());
        }
    }
}