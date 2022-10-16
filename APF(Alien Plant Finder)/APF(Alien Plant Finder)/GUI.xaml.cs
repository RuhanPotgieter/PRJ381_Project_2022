using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class GUI : ContentPage
{
    public GUI()
    {
        InitializeComponent();
            imglogo.Source = ImageSource.FromResource("launcher_foregrround.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        
    }
}