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
    public partial class EmiCalculatorPage : ContentPage
    {
        public EmiCalculatorPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void OnCalculateEMI(object sender, EventArgs e)
        {

            var principal = 0.0;
            var interest = 0.0;
            var period = 0.0;
            var emiresult = 0.0;

            if ((Double.TryParse(inputPrincipal.Text, out principal)) &&
                (Double.TryParse(inputInterest.Text, out interest)) &&
                (Double.TryParse(inputPeriod.Text, out period)))
            {
                interest = interest / (12 * 100); // one month interest 
                //period = period * 12; one month period 
                emiresult = (principal * interest * (float)Math.Pow(1 + interest, period)) / (float)(Math.Pow(1 + interest, period) - 1);
                //emiresult = (principal * interest * (interest + 1) * (period)) / ((interest + 1) * (period) - 1);
                //outputResult.Text = string.Format("{0:##.00}", emiresult);

                await Navigation.PushAsync(new EmiResultPage(emiresult));
            }
            //else
            //{
            //    outputResult.Text = "Please enter a valid value";
            //}

        }


    }
}