using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SodaU
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private async void MenuSemanal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuSemanal());
        }
    }
}