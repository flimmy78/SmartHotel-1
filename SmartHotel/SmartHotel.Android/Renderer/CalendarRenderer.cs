using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using SmartHotel.Controls;
using SmartHotel.Droid.Renderers;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(Calendar), typeof(CalendarRenderer))]
namespace SmartHotel.Droid.Renderers
{
    public class CalendarRenderer : ViewRenderer<Calendar, CalendarView>
    {
        public CalendarRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Calendar> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                SetNativeControl(new CalendarView(Context));
            }
        }
    }
}