using Lumina.ViewModels.Pages;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Wpf.Ui.Controls;
using ZedGraph;

namespace Lumina.Views.Pages
{
    public partial class SettingsPage : INavigableView<SettingsViewModel>
    {
        string myString = "#FFF";
        public SettingsViewModel ViewModel { get; }

        public SettingsPage(SettingsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }



        private void WebhookButton_Click(object sender, RoutedEventArgs e)
        {
            var WEbhook = Webhook.Text;
            using (StreamWriter writer = new StreamWriter(@"./config/Webhook.txt"))
            {
                writer.WriteLine(WEbhook);

            }
        }

        private void SaveServ_Click(object sender, RoutedEventArgs e)
        {
            var PrivateServerAddress = PrivServ.Text;


            try
            {
                using (StreamWriter writer = new StreamWriter(@"./config/PrivateServer.txt"))
                {
                    writer.WriteLine(PrivateServerAddress);

                }
            }
            catch (Exception ex) { }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);
        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        static async Task StarDetection()
        {
            await Task.Delay(1000).ConfigureAwait(
                continueOnCapturedContext: false);

            System.Windows.MessageBox.Show("Thread Started");
        Back:
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, 960, 540);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb(
                (byte)(pixel & 0x000000FF),
                (byte)((pixel & 0x0000FF00) >> 8),
                (byte)((pixel & 0x00FF0000) >> 16));

            try
            {

                // var valuesToMatch = Colors.Where(stringCheck => Colors.Contains($"{color}"));
                bool exists;
                string firstMatch;
                IEnumerable<string> matchingList;



                var Colors = new List<string>() { "Color [A=255, R=75, G=138, B=255]", "Color [A=255, R=81, G=99, B=255]", "Color [A=255, R=255, G=127, B=127]", "Color [A=255, R=111, G=150, B=255]", "Color [A=255, R=41, G=22, B=147]", "Color [A=255, R=81, G=64, B=255]", "Color [A=255, R=81, G=66, B=255]", "Color [A=255, R=151, G=162, B=255]", "Color [A=255, R=37, G=86, B=255]", "Color [A=255, R=9, G=104, B=55]", "Color [A=255, R=163, G=34, B=72]", "Color [A=255, R=56, G=201, B=216]", "Color [A=255, R=84, G=96, B=255]", "Color [A=255, R=119, G=91, B=255]", "Color [A=255, R=7, G=142, B=0]", "Color [A=255, R=190, G=210, B=255]", "Color [A=255, R=255, G=66, B=69]", "Color [A=255, R=125, G=255, B=223", "Color [A=255, R=136, G=136, B=136]", "Color [A=255, R=76, G=133, B=255]" };


                exists = Colors.Any(x => x.Contains($"{color}"));
                if (exists)
                {


                }
                else
                {
                }
                // exists => true

                if ($"{color}".StartsWith("Color [A=255, R=7, G=142, B=0]"))
                {
                    Webhooks.WebhookUndead();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }
                else if ($"{color}".StartsWith("Color [A=255, R=190, G=210, B=255]"))
                {
                    Webhooks.WebhookComet();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }
                else if ($"{color}".StartsWith("Color [A=255, R=255, G=66, B=69]"))
                {
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=125, G=255, B=223]"))
                {
                    Webhooks.WebhookPermaFrost();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=136, G=136, B=136]"))
                {
                    Webhooks.WebhookStormal();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=76, G=133, B=255]"))
                {
                    Webhooks.WebhookAquatic();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=119, G=91, B=255]"))
                {
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=169, B=0]"))
                {
                    Webhooks.WebhookFlushed();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=85, G=98, B=255]"))
                {
                    Webhooks.WebhookNautilus();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=56, G=201, B=216]"))
                {
                    Webhooks.WebhookExotic();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=163, G=34, B=72]"))
                {
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=9, G=104, B=55]"))
                {
                    Webhooks.WebhookJade();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=151, G=162, B=255]"))
                {
                    Webhooks.WebhookCelestial();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=37, G=86, B=255]"))
                {
                    Webhooks.WebhookBounded();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=66, B=255]"))
                {
                    Webhooks.WebhookGalaxy();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=64, B=255]"))
                {
                    Webhooks.WebhookTwilight();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=41, G=22, B=147]"))
                {
                    Webhooks.WebhookKyawthuite();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                // Over 1mil

                else if ($"{color}".StartsWith("Color [A=255, R=111, G=150, B=255]"))
                {
                    Webhooks.WebhookArcane();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=255, G=127, B=127]"))
                {
                    Webhooks.WebhookStarscourge();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=81, G=99, B=255]"))
                {
                    Webhooks.WebhookGravitational();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }

                else if ($"{color}".StartsWith("Color [A=255, R=75, G=138, B=255]"))
                {
                    Webhooks.WebhookVirtual();
                    await Task.Yield();
                    Thread.Sleep(8000);
                    goto Back;
                }


                else
                {
                    using (StreamWriter writer = new StreamWriter(@"./config/Status3.txt"))
                    {
                        writer.WriteLine($"{color}");

                    }

                    goto Back;
                }




            }

            catch (Exception ex)
            {
            }
        }
        private void StarChecker_Checked(object sender, RoutedEventArgs e)
        {
            _ = StarDetection();
        }
        private void StarChecker_UnChecked(object sender, RoutedEventArgs e)
        {

        }

        private void PrivServ_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
