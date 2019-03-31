using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace showie
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            boton.Clicked += Button_Cliecked;

        }
        private async void Button_Cliecked(object sender, EventArgs e)
        {
            string name = entrada.Text;
            await DisplayAlert("Hi there", $"Hello {name}", "OK");
        }
    }
}
