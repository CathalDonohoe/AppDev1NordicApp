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
	public partial class Balder : ContentPage
	{
		public Balder ()
		{
			InitializeComponent ();
            SetUpImages();
            SetUpImages2();
            SetUpImages3();
		}

        private void SetUpImages()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Balder.png";

            imageBalder.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void SetUpImages2()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Balder2.png";

            imageBalder2.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void SetUpImages3()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Balder3.jpg";

            imageBalder3.Source = ImageSource.FromResource(strFilename, assembly);

        }
    }
}