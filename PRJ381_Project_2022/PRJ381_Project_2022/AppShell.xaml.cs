using PRJ381_Project_2022.ViewModels;
using PRJ381_Project_2022.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PRJ381_Project_2022
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
