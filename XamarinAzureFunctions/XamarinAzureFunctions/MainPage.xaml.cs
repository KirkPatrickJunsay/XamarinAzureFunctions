using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAzureFunctions
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonExecute_OnClicked(object sender, EventArgs e)
        {
            var azureFunction = "https://xamarinazurefunction.azurewebsites.net/api/xamarinhelloworld?code=" +
                                $"Texc95fQqL3ZVcB9aV5Gqb95yTyUsQicnRIZhs8YKmmna/WRnlP92w==&name={entryName.Text}";
            var httpClient = new HttpClient();

            labelGreeting.Text = await httpClient.GetStringAsync(azureFunction);
        }
    }
}
