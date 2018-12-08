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
	public partial class Bragi : ContentPage
	{
		public Bragi ()
		{
			InitializeComponent ();
            SetUpImages();
            SetUpImages3();
            SetUpImages4();
		}


        private void SetUpImages()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Bragi.png";

            imageBragi.Source = ImageSource.FromResource(strFilename, assembly);

        }

        

        private void SetUpImages3()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Bragi2.jpg";

            imageBragi2.Source = ImageSource.FromResource(strFilename, assembly);

        }



        private void SetUpImages4()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Bragi3.jpg";

            imageBragi3.Source = ImageSource.FromResource(strFilename, assembly);

        }

    }
}