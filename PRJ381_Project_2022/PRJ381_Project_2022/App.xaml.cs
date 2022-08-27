﻿using PRJ381_Project_2022.Services;
using PRJ381_Project_2022.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRJ381_Project_2022
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
