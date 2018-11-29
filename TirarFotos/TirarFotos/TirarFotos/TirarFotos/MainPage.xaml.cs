using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TirarFotos
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _viewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();

            //Declara a view model como contexto de binding
            _viewModel = new MainPageViewModel();
            BindingContext = _viewModel;

            //Declara a lista de imagens da view model como item source da lista no XAML
            Fotos.ItemsSource = _viewModel.imageList;
        }
    }
}
