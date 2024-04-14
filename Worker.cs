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
            ISITON();

            try
            {
                Util.Focus();
                Thread.Sleep(1000);
                await Task.Delay(1000);

                string CheckPath = File.ReadAllText(@".\Config\Status1.txt");
                string CheckPath3 = File.ReadAllText(@".\Config\Status3.txt");
                if (CheckPath.Contains("true", StringComparison.OrdinalIgnoreCase))
                {
                loop:

                    int i = 1;
                    if (CheckPath.Contains("false", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }
                    else
                    {
                        await Task.Delay(1000);
                        Util.AutoCollect();
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
                }


            AfterLoop:
                if (CheckPath3.Contains("true", StringComparison.OrdinalIgnoreCase))
                {
                    Movement.AutoObb();
                    Util.ResetChar();
                }
                else
                {

                    MessageBox.Show("No features turned on...");

                }
            }
            catch (Exception ex) { return; }

        }

        public static async Task ISITON()
        {
            string CheckPath = File.ReadAllText(@".\Config\ISON.txt");

            if (CheckPath.Contains("true", StringComparison.OrdinalIgnoreCase))
            {

            }
            else if (CheckPath.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
        }

    }
}

