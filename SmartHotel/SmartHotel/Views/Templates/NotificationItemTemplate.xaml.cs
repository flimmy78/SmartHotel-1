using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHotel.Views.Templates
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotificationItemTemplate : ContentView
	{
		public NotificationItemTemplate ()
		{
			InitializeComponent ();
		}

        public static readonly BindableProperty TapCommandProperty =
            BindableProperty.Create("TapCommand", typeof(ICommand), typeof(NotificationItemTemplate));

        public ICommand TapCommand
        {
            get { return (ICommand)GetValue(TapCommandProperty); }
            set { SetValue(TapCommandProperty, value); }
        }
    }
}