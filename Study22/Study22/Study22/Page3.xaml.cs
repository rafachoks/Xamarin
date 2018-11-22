using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Study22
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}

	    private async void Button3_OnClicked(object sender, EventArgs e)
	    {
	        var person = new Person
	        {
	            Name = "Rafael",
	            Age = 30,
	            Occupation = "Developer"
	        };

	        var page = new TabbedPage1 { BindingContext = person };
	        await Navigation.PushAsync(page);
	    }
	}
}