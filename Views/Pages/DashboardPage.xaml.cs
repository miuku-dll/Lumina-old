using Lumina.ViewModels.Pages;
using System.IO;
using System.Net;
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


            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://raw.githubusercontent.com/yurkyu/Lumina/master/Info/Version");
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadLine();



            InitializeComponent();

            Version.Text = content;

        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/4xuYgTzp5H");

        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
