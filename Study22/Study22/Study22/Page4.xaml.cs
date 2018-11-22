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
	public partial class Page4 : CarouselPage
	{
		public Page4 ()
		{
			InitializeComponent ();
		}

	    private async void Button5_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new MasterDetailPage1());
	    }
	}
}