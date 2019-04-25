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
    public partial class MarathonListPage : ContentPage
    {
        public MarathonListPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            // get the json from the server
            string getAllMarathonsUrl = "http://itweb.fvtc.edu/wetzel/marathon/races/";

            string json;

            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {                 
                json = await webClient.DownloadStringTaskAsync(getAllMarathonsUrl);
            }

            // deserialize the json to objects
            RaceListResult raceResults =
                Newtonsoft.Json.JsonConvert.DeserializeObject<RaceListResult>(json);


            // display the objects
            MarathonListView.ItemsSource = raceResults.races.OrderBy(x => x.race_name);
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Race selectedRace;

            selectedRace = (Race)e.SelectedItem;

            RaceResultsPage resultsPage = new RaceResultsPage();

            resultsPage.TheRace = selectedRace;

            await Navigation.PushAsync(resultsPage);

            // code here now executes after the resultsPage is navigated to
        }
    }
}