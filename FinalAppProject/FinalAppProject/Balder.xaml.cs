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

            //function to set up the images
            SetUpImages();
		}

        private void SetUpImages()
        {
            // get the assembly
            var assembly = typeof(MainPage);

            //first image
            string strFilename = "FinalAppProject.Assets.Images.Balder.png";
            imageBalder.Source = ImageSource.FromResource(strFilename, assembly);

            //second image, third image on the page
            string strFilename2 = "FinalAppProject.Assets.Images.Balder2.png";
            imageBalder2.Source = ImageSource.FromResource(strFilename2, assembly);

            //third image, second on the page
            string strFilename3 = "FinalAppProject.Assets.Images.Balder3.jpg";
            imageBalder3.Source = ImageSource.FromResource(strFilename3, assembly);

        }
        
    }
}