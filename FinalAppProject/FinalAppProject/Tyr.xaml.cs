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
            //calling function
            SetUpImages();
		}

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);
            

            string strFilename = "FinalAppProject.Assets.Images.Tyr.png";
            imageTyr.Source = ImageSource.FromResource(strFilename, assembly);


            string strFilename2 = "FinalAppProject.Assets.Images.TyrSymbol.png";
            imageTyrSymbol.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Tyr2.jpg";
            imageTyr2.Source = ImageSource.FromResource(strFilename3, assembly);


            string strFilename4 = "FinalAppProject.Assets.Images.Tyr3.jpg";
            imageTyr3.Source = ImageSource.FromResource(strFilename4, assembly);

        }
    }
}