using Microsoft.VisualStudio.Threading;

namespace Lumina.Workers
{
    partial class Worker
    {

        public static async Task Run()
        {
            await TaskScheduler.Default;

            while (Settings.Default.ison == true)
            {
                Util.Focus();
                await Task.Delay(1000);
                Util.CheckChat();
            loop:
                int i = 1;
                if (Settings.Default.Status1 == false)
                {
                    return;
                }

                else if (Settings.Default.Status1 == true)
                {
                    await Task.Run(() => Movement.CollectAll());

                    goto AfterLoop;

                }
            AfterLoop:
                if (Settings.Default.Status2 == true)
                {
                    Util.Focus();
                    await Task.Run(() => Movement.AutoObb());
                }
                else
                {
                    return;
                }
            }
        }
    }
}

