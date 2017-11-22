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
        async void OnSelectingTeacherUser(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage (new AdminAndTeacherBurgerSelectClass()));
        }
        async void OnSelectingAdminUser(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new AdminAndTeacherBurgerSelectClass()));
        }

    }
}
