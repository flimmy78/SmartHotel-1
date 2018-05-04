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
using SmartHotel.Controls;
using SmartHotel.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace SmartHotel.Droid.Renderer
{
   public class ExtendedEntryRenderer :EntryRenderer
    {
        public ExtendedEntryRenderer(Context context) : base(context)
        {

        }

        // vua renderer
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(e.NewElement != null)
            {
                           
            }
        }

        // update lai do ly do nao do dung OnElementPropertyChanged
    }
}