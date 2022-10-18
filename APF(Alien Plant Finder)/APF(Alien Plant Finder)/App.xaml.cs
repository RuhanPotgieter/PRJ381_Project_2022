using APF;
using gui;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APF_Alien_Plant_Finder_
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new gui.gui();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
