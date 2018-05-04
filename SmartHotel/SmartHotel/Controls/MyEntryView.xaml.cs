using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHotel.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyEntryView : ContentView
    {
        public MyEntryView()
        {
            InitializeComponent();
        }

        // neu la kieu khac string thi ko de null defaul
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(MyEntryView), null, BindingMode.TwoWay);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }


        public static readonly BindableProperty LabelTextProperty =
            BindableProperty.Create(nameof(LabelText), typeof(string), typeof(MyEntryView));

        public string LabelText
        {
            get => (string)GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }


        public static readonly BindableProperty PlaceholderTextProperty =
            BindableProperty.Create(nameof(PlaceholderText), typeof(string), typeof(MyEntryView));

        public string PlaceholderText
        {
            get => (string)GetValue(PlaceholderTextProperty);
            set => SetValue(PlaceholderTextProperty, value);
        }
    }
}