using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepServices.iOS.dependeciaservicios;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(IOSmessage))]
namespace DepServices.iOS.dependeciaservicios
{
    public class IOSmessage : IPlatMessage
    {
        public string Getmessage()
        {
            return "esto es desde ios";
        }
    }

    public interface IPlatMessage
    {
    }
}