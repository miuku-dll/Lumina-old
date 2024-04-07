using Lumina.ViewModels.Pages;
using System.IO;
using Wpf.Ui.Controls;

namespace Lumina.Views.Pages
{
    public partial class FeaturesPage : INavigableView<FeaturesViewModel>
    {
        public FeaturesViewModel ViewModel { get; }

        public FeaturesPage(FeaturesViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;
            InitializeComponent();

            string Status1 = File.ReadAllText(@"./Config/Status1.txt");
            if (Status1.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                AutoCollectToggle.Content = Status1;
            }
            else if (Status1.Contains("true", StringComparison.OrdinalIgnoreCase))
            {
                AutoCollectToggle.Content = Status1;
            }

            string Status2 = File.ReadAllText(@"./Config/Status2.txt");
            if (Status2.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                AutoCollectToggle.Content = Status2;
            }
            else if (Status2.Contains("true", StringComparison.OrdinalIgnoreCase))
            {
                AutoCollectToggle.Content = Status2;
            }
        }

        private void GlobalToggle_Click(object sender, RoutedEventArgs e)
        {
            bool on = false;

            if (on == false)
            {
                Worker.Starting();
                GlobalToggle.Content = "Stop";
                on = true;
            }
            else if (on == true)
            {
                return;
            }

           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Status1File = File.ReadAllText(@"./Config/Status1.txt");

            if (Status1File.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                using (StreamWriter writer = new StreamWriter(@"./config/Status1.txt"))
                {
                    writer.WriteLine("true");
                    AutoCollectToggle.Content = "true";
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"./config/Status1.txt"))
                {
                    writer.WriteLine("false");
                    AutoCollectToggle.Content = "false";
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string Status2File = File.ReadAllText(@"./Config/Status2.txt");

            if (Status2File.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                using (StreamWriter writer = new StreamWriter(@"./config/Status2.txt"))
                {
                    writer.WriteLine("true");
                    AutoCraftGilded.Content = "true";
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"./config/Status2.txt"))
                {
                    writer.WriteLine("false");
                    AutoCraftGilded.Content = "false";
                }
            }
        }
    }
}
