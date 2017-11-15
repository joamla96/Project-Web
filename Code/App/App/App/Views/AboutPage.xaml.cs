using App.Views;
using System;

using Xamarin.Forms;

namespace App
{
	public partial class AboutPage : ContentPage
	{
		public AboutPage()
		{
			InitializeComponent();
		}
        async void OnSelectingStudentUser(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudentMainMenu());
        }

    }
}
