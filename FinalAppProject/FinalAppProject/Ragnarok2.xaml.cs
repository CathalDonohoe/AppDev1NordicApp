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

            string strFilename4 = "FinalAppProject.Assets.Images.RagnarokImage4.jpg";
            RagnarokImage4.Source = ImageSource.FromResource(strFilename4, assembly);

            string strFilename5 = "FinalAppProject.Assets.Images.RagnarokImage5.jpg";
            RagnarokImage5.Source = ImageSource.FromResource(strFilename5, assembly);


        }
    }
}