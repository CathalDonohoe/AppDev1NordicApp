using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalAppProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void btnGods_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NordicGodsPage());
        }

        private void SetUpImages()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Background Image.png";

            bckgrndImage.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void btnRagnarok_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ragnarok());
        }

        private void btnAbout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }
}
