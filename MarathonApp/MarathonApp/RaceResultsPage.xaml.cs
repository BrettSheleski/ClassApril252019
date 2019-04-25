using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarathonApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RaceResultsPage : ContentPage
    {
        public RaceResultsPage()
        {
            InitializeComponent();
        }

        public Race TheRace { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.Title = TheRace.race_name;

            string url = $"http://itweb.fvtc.edu/wetzel/marathon/results/{TheRace.id}/";

            // get the json from the server
            System.Net.WebClient webClient = new System.Net.WebClient();

            string json = webClient.DownloadString(url);

            // deserialize the json to objects
            MarathonResult marathonResult = 
                Newtonsoft.Json.JsonConvert.DeserializeObject<MarathonResult>(json);

            // display the objects
            RaceResultsListView.ItemsSource = marathonResult.results;
        }
    }
}