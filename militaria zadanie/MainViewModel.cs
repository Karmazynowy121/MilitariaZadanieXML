using Microsoft.Toolkit.Mvvm.ComponentModel;
using militaria_zadanie;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace militaria_zadanie
{
    public class MainViewModel : ObservableObject
    {
        private ObservableCollection<Area> areas = new ObservableCollection<Area>();
        public ObservableCollection<Area> Areas
        {
            get { return areas; }
            set { SetProperty(ref areas, value); }
        }

        public MainViewModel()
        {
            Task.Run(LoadData);
        }

        private async Task LoadData()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetFromJsonAsync<Area[]>("https://api-dbw.stat.gov.pl/api/1.1.0/area/area-area");

            if (response != null)
            {
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    Areas = new ObservableCollection<Area>(response);
                });
            }
        }
        //public Brush GetLevelNameColor(string levelName)
        //{
        //    switch (levelName)
        //    {
        //        case "Temat":
        //            return Brushes.Green;
        //        case "Zakres informacyjny":
        //            return Brushes.Red;
        //        case "Dziedzina":
        //            return Brushes.Yellow;
        //        default:
        //            return Brushes.Black;
        //    }
        //}
    }
}
