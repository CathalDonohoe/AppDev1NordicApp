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
	public partial class Ragnarok2 : ContentPage
	{
		public Ragnarok2 ()
		{
			InitializeComponent ();
            //calling function
            SetUpImages();
		}

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);

            string strFilename4 = "FinalAppProject.Assets.Images.RagnarokImage4.jpg";
            RagnarokImage4.Source = ImageSource.FromResource(strFilename4, assembly);

            string strFilename5 = "FinalAppProject.Assets.Images.RagnarokImage5.jpg";
            RagnarokImage5.Source = ImageSource.FromResource(strFilename5, assembly);


        }
    }
}