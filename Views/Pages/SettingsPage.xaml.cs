using Lumina.ViewModels.Pages;
using System.IO;
using Wpf.Ui.Controls;

namespace Lumina.Views.Pages
{
    public partial class SettingsPage : INavigableView<SettingsViewModel>
    {
        public SettingsViewModel ViewModel { get; }

        public SettingsPage(SettingsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var WebhookAddress = Webhook.Text;

            try
            {
                using (StreamWriter writer = new StreamWriter(@"./config/Webhook.txt"))
                {
                    writer.WriteLine(WebhookAddress);
                    System.Windows.MessageBox.Show(WebhookAddress);

                }
            }
            catch (Exception ex) { }
        }

        private void SaveServ_Click(object sender, RoutedEventArgs e)
        {
            var PrivateServerAddress = PrivServ.Text;

            try
            {
                using (StreamWriter writer = new StreamWriter(@"./config/PrivateServer.txt"))
                {
                    writer.WriteLine(PrivateServerAddress);
                    System.Windows.MessageBox.Show(PrivateServerAddress);

                }
            }
            catch (Exception ex) { }
        }
    }
}
