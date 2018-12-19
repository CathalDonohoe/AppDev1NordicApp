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
	public partial class Ragnarok3 : ContentPage
	{
		public Ragnarok3 ()
		{
			InitializeComponent ();
            //calling images function
            SetUpImages();
		}

        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);
            

            string strFilename6 = "FinalAppProject.Assets.Images.RagnarokImage6.jpg";
            RagnarokImage6.Source = ImageSource.FromResource(strFilename6, assembly);

            string strFilename7 = "FinalAppProject.Assets.Images.RagnarokImage7.jpg";
            RagnarokImage7.Source = ImageSource.FromResource(strFilename7, assembly);


        }
    }
}