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

            //function to set up images
            SetUpImages();
		}


        private void SetUpImages()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            
            //first image set up
            string strFilename = "FinalAppProject.Assets.Images.Bragi.png";
            imageBragi.Source = ImageSource.FromResource(strFilename, assembly);

            //second image set up
            string strFilename2 = "FinalAppProject.Assets.Images.Bragi2.jpg";
            imageBragi2.Source = ImageSource.FromResource(strFilename2, assembly);

            //third image
            string strFilename3 = "FinalAppProject.Assets.Images.Bragi3.jpg";
            imageBragi3.Source = ImageSource.FromResource(strFilename3, assembly);

        }
  
    }
}