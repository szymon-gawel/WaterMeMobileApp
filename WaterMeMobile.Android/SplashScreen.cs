using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WaterMeMobile.Droid
{
   
        [Activity(Theme = "@style/Theme.Splash",
       MainLauncher = true,
       NoHistory = true)]
        public class SplashScreen : Activity
        {
            protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);
                System.Threading.Thread.Sleep(3000);
                StartActivity(typeof(MainActivity));
            }

            protected override void OnResume()
            {
                base.OnResume();
                Task startUpWork = new Task(() => { SimulateStartup(); });
                startUpWork.Start();
            }

            async void SimulateStartup()
            {
                await Task.Delay(2000);
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            }

        }
    }
