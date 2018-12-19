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
    public partial class Ymir : ContentPage
    {
        public Ymir()
        {
            InitializeComponent();
            //calling function
            SetUpImages();

        }


        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);
            

            string strFilename = "FinalAppProject.Assets.Images.Ymir.png";
            imageYmir.Source = ImageSource.FromResource(strFilename, assembly);


            string strFilename2 = "FinalAppProject.Assets.Images.Ymir2.png";
            imageYmir2.Source = ImageSource.FromResource(strFilename2, assembly);


            string strFilename3 = "FinalAppProject.Assets.Images.Ymir3.jpg";
            imageYmir3.Source = ImageSource.FromResource(strFilename3, assembly);


            string strFilename4 = "FinalAppProject.Assets.Images.Ymir4.jpg";
            imageYmir4.Source = ImageSource.FromResource(strFilename4, assembly);
        }



    }
}