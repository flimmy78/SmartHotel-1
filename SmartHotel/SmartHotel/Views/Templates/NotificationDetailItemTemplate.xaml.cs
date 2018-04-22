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
	public partial class NotificationDetailItemTemplate : ContentView
	{
        public static readonly BindableProperty DeleteCommandProperty =
               BindableProperty.Create(
                   "DeleteCommand",
                   typeof(ICommand),
                   typeof(NotificationDetailItemTemplate),
                   default(ICommand));

        public ICommand DeleteCommand
        {
            get { return (ICommand)GetValue(DeleteCommandProperty); }
            set { SetValue(DeleteCommandProperty, value); }
        }

        public NotificationDetailItemTemplate()
        {
            InitializeComponent();

            var tapGesture = new TapGestureRecognizer
            {
                Command = new Command(OnDeleteTapped)
            };

            DeleteImage.GestureRecognizers.Add(tapGesture);
            InitializeCell();
        }

        private ICommand TransitionCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var isUwp = Device.RuntimePlatform == Device.UWP;

                    DeleteContainer.BackgroundColor = Color.FromHex("#EC0843");
                    DeleteImage.Source = isUwp ? $"Assets/ic_paperbin.png" : $"ic_paperbin";

                    await this.TranslateTo(-this.Width, 0, 500, Easing.SinIn);

                    DeleteCommand?.Execute(BindingContext);

                    InitializeCell();
                });
            }
        }

        private void OnDeleteTapped()
        {
            TransitionCommand.Execute(null);
        }

        private void InitializeCell()
        {
            var isUwp = Device.RuntimePlatform == Device.UWP;

            this.TranslationX = 0;
            DeleteContainer.BackgroundColor = Color.FromHex("#F2F2F2");
            DeleteImage.Source = isUwp ? $"Assets/ic_paperbin_red.png" : $"ic_paperbin_red";
        }
    }
}