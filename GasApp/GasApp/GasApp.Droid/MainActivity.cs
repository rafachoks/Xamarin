using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GasApp.Droid
{
    [Activity(Label = "GasApp.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            ImageView button = FindViewById<ImageView>(Resource.Id.Plus);
            button.Click += Button_Click;

            ImageView buttonMinus = FindViewById<ImageView>(Resource.Id.Minus);

            buttonMinus.Click += ButtonMinus_Click;

        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(FindViewById<TextView>(Resource.Id.lbnprice5kg).Text);
            int numero = int.Parse(FindViewById<EditText>(Resource.Id.nr5kg).Text);
            numero -= 1;
            if(numero >= 0)
            {
                FindViewById<EditText>(Resource.Id.nr5kg).Text = numero.ToString();
              
            }
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            decimal valor = decimal.Parse(FindViewById<TextView>(Resource.Id.lbnprice5kg).Text);
            int numero = int.Parse(FindViewById<EditText>(Resource.Id.nr5kg).Text);
            numero += 1;

            FindViewById<EditText>(Resource.Id.nr5kg).Text = numero.ToString();
            
        }
    }
}


