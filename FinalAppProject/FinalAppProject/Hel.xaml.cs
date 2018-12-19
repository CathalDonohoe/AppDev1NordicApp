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
	public partial class Hel : ContentPage
	{
		public Hel ()
		{
			InitializeComponent ();
            //calling fucntion
            SetUpImages();
        }

        private void SetUpImages()
        {

            //function to set up images
            var assembly = typeof(MainPage);
           
            string strFilename = "FinalAppProject.Assets.Images.Hel.png";
            imageHel.Source = ImageSource.FromResource(strFilename, assembly);


            string strFilename2 = "FinalAppProject.Assets.Images.HelSymbol.png";
            imageHelSymbol.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Hel2.jpg";
            imageHel2.Source = ImageSource.FromResource(strFilename3, assembly);


            string strFilename4 = "FinalAppProject.Assets.Images.Hel3.jpg";
            imageHel3.Source = ImageSource.FromResource(strFilename4, assembly);
        }
        
    }
}