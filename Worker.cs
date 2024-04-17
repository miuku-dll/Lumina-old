using Microsoft.VisualStudio.Threading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumina
{
    partial class Worker
    {

        public static async Task Run()
        {
            await TaskScheduler.Default;

            while (Settings1.Default.ison == true)
            {
                Util.Focus();
                await Task.Delay(1000);
                Util.CheckChat();
            loop:
                int i = 1;
                if (Settings1.Default.Status1 == false)
                {
                    return;
                }
                
                else if (Settings1.Default.Status1 == true)
                {
                    await Task.Delay(1000);
                    Movement.CollectAll();
                    i++;
                    if (i > 3)
                    {
                        goto AfterLoop;
                    }
                    else
                    {
                        goto loop;
                    }
                }
        AfterLoop:
            if (Settings1.Default.Status2 == true)
            {
                Movement.AutoObb();
                Util.ResetChar();
            }
            else
            {
                    goto loop;
            }
            }
        }
    }
}

