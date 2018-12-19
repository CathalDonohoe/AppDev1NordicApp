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
	public partial class Freyr : ContentPage
	{
		public Freyr ()
		{
			InitializeComponent ();
            //calling function to set up images
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(MainPage);

            //setting up images function
            string strFilename = "FinalAppProject.Assets.Images.Freyr.png";
            imageFreyr.Source = ImageSource.FromResource(strFilename, assembly);


            string strFilename2 = "FinalAppProject.Assets.Images.Freyr2.png";
            imageFreyr2.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Freyr3.jpg";
            imageFreyr3.Source = ImageSource.FromResource(strFilename3, assembly);

        
            string strFilename4 = "FinalAppProject.Assets.Images.Freyr4.jpg";
            imageFreyr4.Source = ImageSource.FromResource(strFilename4, assembly);

        }
    }
}