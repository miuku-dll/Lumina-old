using FluentScheduler;
using Lumina.ViewModels.Pages;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);
        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        private void PrivServ_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
