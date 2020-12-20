using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Corotarium
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InterestMenuPage : ContentPage
    {
        public InterestMenuPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void OnPropertyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InterestPropertyPage());
        }
        async void OnCarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InterestCarPage());
        }

        async void OnPersonalClicked(object sender, EventArgs e)
        {

        }
        async void OnCreditClicked(object sender, EventArgs e)
        {
            
        }
    }
}