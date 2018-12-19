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
	public partial class Loki : ContentPage
	{
		public Loki ()
		{
			InitializeComponent ();
            //calling function
            SetUpImages();
        }

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);
         

            string strFilename = "FinalAppProject.Assets.Images.Loki.png";
            imageLoki.Source = ImageSource.FromResource(strFilename, assembly);


            string strFilename2 = "FinalAppProject.Assets.Images.LokiSymbol.png";
            imageLokiSymbol.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Loki2.jpg";
            imageLoki2.Source = ImageSource.FromResource(strFilename3, assembly);


            string strFilename4 = "FinalAppProject.Assets.Images.Loki3.jpg";
            imageLoki3.Source = ImageSource.FromResource(strFilename4, assembly);
        }
    }
}