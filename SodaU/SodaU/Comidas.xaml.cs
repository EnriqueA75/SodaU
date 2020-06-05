using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace SodaU
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comidas : ContentPage
    {
        public Comidas()
        {

            InitializeComponent();
            LlenarComidas();
        }

        /// get comidas

        private async void LlenarComidas()
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("https://sodau.azurewebsites.net");

            var request = await cliente.GetAsync("/api/Comidas");

            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<Comidas>>(responseJson);

                lstcomidas.ItemsSource = response;
            }

        }

    }
        
}