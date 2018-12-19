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
	public partial class Freya : ContentPage
	{
		public Freya ()
		{
			InitializeComponent ();

            //set up images
            SetUpImages();
            
        }

        private void SetUpImages()
        {
            var assembly = typeof(MainPage);
            

            string strFilename = "FinalAppProject.Assets.Images.Freya.png";
            imageFreya.Source = ImageSource.FromResource(strFilename, assembly);


            string strFilename2 = "FinalAppProject.Assets.Images.FreyaSymbol.jpg";
            imageFreyaSymbol.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Freya2.jpg";
            imageFreya2.Source = ImageSource.FromResource(strFilename3, assembly);

        }

    }
}