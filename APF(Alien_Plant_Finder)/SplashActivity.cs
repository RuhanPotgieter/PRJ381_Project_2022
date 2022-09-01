using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APF_Alien_Plant_Finder_
{
    [Activity(Label = "SplashActivity", MainLauncher = true, Theme = "@style/CustomTheme.Splash", NoHistory =true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override async void OnResume()
        {
            base.OnResume();
            await SimulationStartup();
        }

        async Task SimulationStartup()
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}