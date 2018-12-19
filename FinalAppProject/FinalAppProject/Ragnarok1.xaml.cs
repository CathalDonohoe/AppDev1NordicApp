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
	public partial class Ragnarok1 : ContentPage
	{
		public Ragnarok1 ()
		{
			InitializeComponent ();
            //calling functions
            SetUpImages();

        }


        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);
          

            string strFilename = "FinalAppProject.Assets.Images.RagnarokImage1.jpg";
            RagnarokImage1.Source = ImageSource.FromResource(strFilename, assembly);

            string strFilename2 = "FinalAppProject.Assets.Images.RagnarokImage2.jpg";
            RagnarokImage2.Source = ImageSource.FromResource(strFilename2, assembly);

            string strFilename3 = "FinalAppProject.Assets.Images.RagnarokImage3.jpg";
            RagnarokImage3.Source = ImageSource.FromResource(strFilename3, assembly);

        }
    }
}