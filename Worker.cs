using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumina
{
    class Worker
    {

        public static async Task Run()
        {
            await Task.Delay(1000);

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
                    Util.ResetChar();
                    Movement.AutoObb();
                }
                else
                {

                    MessageBox.Show("No features turned on...");

                }
            }
            catch (Exception ex) { return; }

        }

    }
}

