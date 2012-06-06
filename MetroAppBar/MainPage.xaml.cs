using System.Windows;
using TinyMessenger;

namespace MetroAppBar
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            var hub = Application.Current.Resources[ResourceKeys.Hub] as ITinyMessengerHub;
            hub.Subscribe<GenericTinyMessage<string>>((m) => { InfoTextBlock.Text = m.Content + " button was clicked."; });
        }
    }
}
