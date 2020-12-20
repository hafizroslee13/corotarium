using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Corotarium
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void OnCalculatorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmiCalculatorPage());
        }
        async void OnInterestClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InterestMenuPage());
        }

        async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}
