using SmartHotel.Views;
using System;
using SmartHotel.Services;
using SmartHotel.Services.Navigation;
using SmartHotel.ViewModels;
using Xamarin.Forms;

namespace SmartHotel
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
		    
            ServiceLocator.Instance.Build();

		    ServiceLocator.Instance.Resolve<INavigationService>()
		        .NavigateToAsync<LoginViewModel>();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
