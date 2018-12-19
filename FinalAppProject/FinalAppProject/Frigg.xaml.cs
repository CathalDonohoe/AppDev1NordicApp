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
	public partial class Frigg : ContentPage
	{
        public Frigg()
        {
            InitializeComponent();
            //calling the function
            SetUpImages();
        }


        private void SetUpImages()
        {
            //function for setting up images
            var assembly = typeof(MainPage);
            

            string strFilename = "FinalAppProject.Assets.Images.Frigg.png";
            imageFrigg3.Source = ImageSource.FromResource(strFilename, assembly);

            string strFilename2 = "FinalAppProject.Assets.Images.Frigg2.png";
            imageFrigg2.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.frigg3.jpg";
            imageFrigg.Source = ImageSource.FromResource(strFilename3, assembly);

        }
    }
}