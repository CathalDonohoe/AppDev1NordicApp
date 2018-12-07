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
	public partial class Tyr : ContentPage
	{
		public Tyr ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Tyr.png";

            imageTyr.Source = ImageSource.FromResource(strFilename, assembly);

        }
    }
}