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
    public partial class EmiResultPage : ContentPage
    {
        public EmiResultPage(double outputResult)
        {
            InitializeComponent();
            mainLabel.Text = "RM " + string.Format("{0:##.00}", outputResult);
        }

    }
}