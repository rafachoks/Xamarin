using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TirarFotos
{
    class MainPageViewModel
    {
        //Declara os comandos
        public ICommand DeletarCommand { get; private set; }
        public ICommand FotoCommand { get; private set; }

        //Lista de imagens
        public ObservableCollection<string> imageList = new ObservableCollection<string>();

        public MainPageViewModel()
        {
            //Declara os comandos as metodos
            DeletarCommand = new Command<string>(Deletar);
            FotoCommand = new Command(async () => await TirarFoto());

        }

        //Deleta a foto da lista
        void Deletar(string foto)
        {
            imageList.Remove(foto);
        }

        async Task TirarFoto()
        {
            await CrossMedia.Current.Initialize();

            //Verifica se a camera está disponivel
            if (!CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.Current.IsCameraAvailable)
            {
                await App.Current.MainPage.DisplayAlert("Aviso", "Nenhuma camera detectada", "OK");

                return;
            }

            //tira a foto
            var file = await CrossMedia.Current.TakePhotoAsync(

            new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
                Directory = "Demo"
            });

            //Verifica se foi tirado alguma foto
            if (file == null)
                return;

            //Adiciona a foto a lista de imagens
            imageList.Add(file.Path);


        }
    }
}
