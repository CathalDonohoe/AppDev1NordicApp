﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalAppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Thor : ContentPage
	{
		public Thor ()
		{
			InitializeComponent ();
            SetUpImages();
            SetUpImages2();
		}

        private void SetUpImages()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.Thor.png";

            imageThor.Source = ImageSource.FromResource(strFilename, assembly);

        }

        private void SetUpImages2()
        {
            // get the assembly
            var assembly = typeof(MainPage);
            /*
             * need a directory path - ImageSample/Assets/Images/oogway.jpg
             * two parameters are that directory path in that assembly
             */

            string strFilename = "FinalAppProject.Assets.Images.ThorSymbol.png";

            imageThorSymbol.Source = ImageSource.FromResource(strFilename, assembly);

        }
    }
}