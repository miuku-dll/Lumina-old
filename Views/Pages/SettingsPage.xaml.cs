using FluentScheduler;
using Lumina.ViewModels.Pages;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using Wpf.Ui;
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

            ResolutionCombobox.Text = Settings.Default.Resolution;

            if (Settings.Default.AutoUpdater == true)
            {
                AutoUpdateToggle.IsChecked = true;
            }
            else
            {
                AutoUpdateToggle.IsChecked = false;
            }

        }

        void WinLoaded(object sender, RoutedEventArgs e)
        {
            PrivServ.PlaceholderText = Settings.Default.PrivateServer;
            Webhook.PlaceholderText = Settings.Default.WebhookAddress;
        }

        private void WebhookButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.WebhookAddress = Webhook.Text;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void SaveServ_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default.PrivateServer = PrivServ.Text;
            Settings.Default.Save();
            Settings.Default.Reload();

        }

        private void PrivServ_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResolutionCombobox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            String Item = (this.ResolutionCombobox.SelectedItem as ComboBoxItem).Content.ToString();

            Settings.Default.Resolution = Item;
            Util.SaveConfig();
        }

        private void AutoUpdateToggle_Checked(object sender, RoutedEventArgs e)
        {
            Settings.Default.AutoUpdater = true;
            Util.SaveConfig();
        }
        private void AutoUpdateToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            Settings.Default.AutoUpdater = false;
            Util.SaveConfig();
        }

        private void KeycodeClick(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://boostrobotics.eu/windows-key-codes/") { UseShellExecute = true });
        }


    }
}
