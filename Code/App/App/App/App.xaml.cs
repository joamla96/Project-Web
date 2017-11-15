using System;

using Xamarin.Forms;

namespace App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new AboutPage();
            else
                MainPage = new AboutPage();
        }
    }
}