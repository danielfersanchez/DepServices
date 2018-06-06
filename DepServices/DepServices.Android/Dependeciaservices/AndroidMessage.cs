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
using DepServices.Droid.Dependeciaservices;
using Xamarin.Forms;

[assembly:Dependency(typeof(AndroidMessage))]
namespace DepServices.Droid.Dependeciaservices
{
   public  class AndroidMessage:IPlatMessage
    {
        public string GetMessage()
        {
            return "estoy desde Android";
        }

    }

    public interface IPlatMessage
    {
    }
}