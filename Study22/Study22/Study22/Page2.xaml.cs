using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Study22
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}

	    async void Button2_OnClicked(object sender, EventArgs e)
	    {
	        Person person = new Person
	        {
                Name = "Rafael",
                Age = 30,
                Occupation = "Developer"
	        };

	        var page = new Page3 {BindingContext = person};
	        await Navigation.PushAsync(page);
	    }
	}
}