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
    public partial class Botones : ContentPage
    {
        public Botones()
        {
            InitializeComponent();
        }

        private async void Pedidos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pedidos());
        }
    }
}