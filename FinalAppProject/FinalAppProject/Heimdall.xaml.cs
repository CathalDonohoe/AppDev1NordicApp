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
	public partial class Heimdall : ContentPage
	{
        public Heimdall()
        {
            InitializeComponent();
            //calling function to set up images
            SetUpImages();
        }


        private void SetUpImages()
        {

            //function to set up images
            var assembly = typeof(MainPage);
          

            string strFilename = "FinalAppProject.Assets.Images.Heimdall.png";
            imageHeimdall.Source = ImageSource.FromResource(strFilename, assembly);


            string strFilename2 = "FinalAppProject.Assets.Images.HeimdallSymbol.png";
            imageHeimdallSymbol.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Heimdall2.jpg";
            imageHeimdall2.Source = ImageSource.FromResource(strFilename3, assembly);
        }

    }
}