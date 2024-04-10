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

        public async static void SomeMethod()
        {
            Util.Focus();
            Thread.Sleep(1000);
            await Task.Delay(1000);

            for (; ; )
            {
                string CheckPath = File.ReadAllText(@".\Config\Status1.txt");
                if (CheckPath.Contains("true", StringComparison.OrdinalIgnoreCase))
                {
                    int i = 1;
                    for (; ; )
                    {
                        Util.ResetChar();
                        if (CheckPath.Contains("false",StringComparison.OrdinalIgnoreCase))
                        {
                            return;
                        }
                        else
                        {
                            await Task.Delay(1000);
                            Util.AutoCollect();
                            i++;
                            if (i > 4)
                                break;
                        }
                    }
                }
                else
                {
                    
                    MessageBox.Show("No features turned on...");
                    
                    break;
                }
            }
           
        }

    }
}
