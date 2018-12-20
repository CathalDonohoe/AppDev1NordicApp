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
            //calling function
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set um images
            var assembly = typeof(MainPage);
           

            string strFilename = "FinalAppProject.Assets.Images.Odin.png";
            imageOdin.Source = ImageSource.FromResource(strFilename, assembly);


            string strFilename2 = "FinalAppProject.Assets.Images.vikingSymbol.png";
            imageOdinSymbol.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Odin2.jpg";
            imageOdin2.Source = ImageSource.FromResource(strFilename3, assembly);


            string strFilename4 = "FinalAppProject.Assets.Images.Odin3.jpg";
            imageOdin3.Source = ImageSource.FromResource(strFilename4, assembly);
        }
    }
}