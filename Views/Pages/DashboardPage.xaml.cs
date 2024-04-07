using Lumina.ViewModels.Pages;
using System.IO;
using System.Net;
using System.Reflection.PortableExecutable;
using Wpf.Ui.Controls;

namespace Lumina.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();

            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://raw.githubusercontent.com/yurkyu/Sutes-Macro/master/Info/changelog.txt");
                StreamReader reader = new StreamReader(stream);
                String content = reader.ReadToEnd();
                Changelog.Text = content;
            }
            catch (Exception ex) { }

            try
            {
                WebClient client2 = new WebClient();
                Stream stream2 = client2.OpenRead("https://raw.githubusercontent.com/yurkyu/Sutes-Macro/master/Info/Announcement.txt");
                StreamReader reader2 = new StreamReader(stream2);
                String content2 = reader2.ReadToEnd();
                Announcement.Text = content2;
            }
            catch { }

            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://raw.githubusercontent.com/yurkyu/Sutes-Macro/master/Info/Version");
                StreamReader reader = new StreamReader(stream);
                String content = reader.ReadToEnd();
                Version.Text = content;
            }
            catch (Exception ex) { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Hoimo");

        }

        

    }
}
