using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WeatherAppBySam
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string Lat, Lon;
        public MainPage()
        {
            this.InitializeComponent();
            HideStatusBar();
        }

        private async void HideStatusBar()
        {
            if (ApiInformation.IsApiContractPresent("Windows.Phone.PhoneContract", 1, 0))
            {
                var statusBar =StatusBar.GetForCurrentView();
                await statusBar.HideAsync();
            }
            
        }

        private async void btnGetWeather_Click(object sender, RoutedEventArgs e)
        {
            ProgressRing.IsActive = true;
            var geoLocator = new Geolocator();
            geoLocator.DesiredAccuracy = PositionAccuracy.High;
            Geoposition pos = await geoLocator.GetGeopositionAsync();

            Lat = pos.Coordinate.Point.Position.Latitude.ToString();
            Lon = pos.Coordinate.Point.Position.Longitude.ToString();

            var data = await Helper.Helper.GetWeather(Lat, Lon);

            if(data != null)
            {
                txtCity.Text = $"{data.name},{data.sys.country}";
                txtLastUpdate.Text = $"Last Updated : {DateTime.Now.ToString("dd MMM yyy HH:mm")}";

                BitmapImage image = new BitmapImage(new Uri ($"http://openweathermap.org/img/w/{data.weather[0].icon}.png",UriKind.Absolute) );
                imgWeather.Source = image;


                txtDescription.Text = $"Humidity:{data.main.humidity}%";
                txtTime.Text = $"{Commence.Commence.ConvertUnixTimeToDateTime(data.sys.sunrise).ToString("HH:mm")}/ {Commence.Commence.ConvertUnixTimeToDateTime(data.sys.sunset).ToString("HH:mm")}";
                txtCel.Text = $"{data.main.temp}°C";
            }
            ProgressRing.IsActive = false;
        }
    }
}
