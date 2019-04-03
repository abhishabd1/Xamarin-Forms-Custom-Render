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
using CRDemo.CustomControl;
using CRDemo.Droid.CustomRender;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry),typeof(EntryCustomRender))]//Registry
namespace CRDemo.Droid.CustomRender
{
    public class EntryCustomRender : EntryRenderer
    {
        public EntryCustomRender(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry>e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.PaleGreen);
            }
        }
    }
}