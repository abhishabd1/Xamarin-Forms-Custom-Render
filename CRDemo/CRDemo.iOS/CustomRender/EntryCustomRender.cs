using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRDemo.CustomControl;
using CRDemo.iOS.CustomRender;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(CustomEntry), typeof(EntryCustomRender))]
namespace CRDemo.iOS.CustomRender
{
   public class EntryCustomRender : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry>e)
        {
            base.OnElementChanged(e);
            if(Control !=null)
            {
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
            return;
        }
    }
}