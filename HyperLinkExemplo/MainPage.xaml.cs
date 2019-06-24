using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HyperLinkExemplo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(AbrirNavegador);
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void AbrirNavegador(string url)
        {
            Device.OpenUri(new Uri(url));
        }
    }
}
