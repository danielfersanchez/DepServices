using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using DepServices.Droid.Dependeciaservices;
using Xamarin.Forms;
using static Android.Speech.Tts.TextToSpeech;
[assembly: Dependency(typeof(AndroidTextVoz))]
namespace DepServices.Droid.Dependeciaservices
{
    public class AndroidTextVoz : Java.Lang.Object, ITextVoz, IOnInitListener
    {
        private TextToSpeech speaker;
        private string toSpeak;
        public void OnIniT([GeneratedEnum] OperationResult status)
        {

            speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }

       

        public void Spek(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Forms.Context, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
    }

}