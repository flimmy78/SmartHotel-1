using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using SmartHotel.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(UnderLineTextEffect), "UnderLineTextEffect")]
namespace SmartHotel.Droid.Effects
{
    public class UnderLineTextEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
           if(Control is TextView textView)
            {
                textView.PaintFlags = textView.PaintFlags | PaintFlags.UnderlineText;
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}