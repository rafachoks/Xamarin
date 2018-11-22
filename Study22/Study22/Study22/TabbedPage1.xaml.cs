using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Study22
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1 ()
        {

            InitializeComponent();
        }

        private async void Button4_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}