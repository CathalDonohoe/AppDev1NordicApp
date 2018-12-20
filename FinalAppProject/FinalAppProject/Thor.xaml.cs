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
	public partial class Thor : ContentPage
	{
		public Thor ()
		{
			InitializeComponent ();
            //calling function
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);
            

            string strFilename = "FinalAppProject.Assets.Images.Thor.png";
            imageThor.Source = ImageSource.FromResource(strFilename, assembly);


             string strFilename2 = "FinalAppProject.Assets.Images.ThorSymbol.png";
            imageThorSymbol.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Thor2.jpg";
            imageThor2.Source = ImageSource.FromResource(strFilename3, assembly);


            string strFilename4 = "FinalAppProject.Assets.Images.Thor3.jpg";
            imageThor3.Source = ImageSource.FromResource(strFilename4, assembly);
        }
    }
}