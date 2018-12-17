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
	public partial class Odin : ContentPage
	{
		public Odin ()
		{
			InitializeComponent ();
            SetUpImages();
            SetUpImages2();
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

            string strFilename = "FinalAppProject.Assets.Images.Odin.png";

            imageOdin.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void SetUpImages2()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.OdinSymbol.png";

            imageOdinSymbol.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void SetUpImages3()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Odin2.jpg";

            imageOdin2.Source = ImageSource.FromResource(strFilename, assembly);

        }


        private void SetUpImages4()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Odin3.jpg";

            imageOdin3.Source = ImageSource.FromResource(strFilename, assembly);

        }
    }
}