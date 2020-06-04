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
    public partial class MenuSemanal : ContentPage
    {
        public MenuSemanal()
        {
            InitializeComponent();
        }
        private async void Desayuno_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuDesayuno());
        }
        private async void Almuerzo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuAlmuerzos());
        }
        private async void Cena_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuCena());
        }
    }
}