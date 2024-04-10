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


            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://raw.githubusercontent.com/yurkyu/Lumina/master/Info/Version");
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadLine();

            

            InitializeComponent();

            Version.Text = content + "";
        }


        

    }
}
