using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Corotarium.Droid
{
    [Activity(Label = "Corotarium", Icon = "@drawable/corotarium_icon_2", Theme = "@style/Splash", MainLauncher = true)]

    public class SplashActivity:Activity
    {
        public SplashActivity()
        {

        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();
        }

    }
}