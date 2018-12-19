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
            //calling function to set up images
            SetUpImages();
        }

        //button to go to gods tabbed pages
        private void btnGods_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NordicGodsPage());
        }

        //function to set up images
        private void SetUpImages()
        {
            var assembly = typeof(MainPage);


            string strFilename = "FinalAppProject.Assets.Images.Background Image.png";
            bckgrndImage.Source = ImageSource.FromResource(strFilename, assembly);

        }

        //function to go to Ranarok tabbed pages
        private void btnRagnarok_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ragnarok());
        }

        //button to go to about page
        private void btnAbout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }
}
