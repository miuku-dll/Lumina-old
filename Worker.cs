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
        public static void Starting()
        {
            
            Util.Focus();
            Thread.Sleep(1000);
            Run();
        }






        static void Run()
        {
            for (; ; )
            {

                string Check2Path = File.ReadAllText(@".\Config\Status2.txt");
                string CheckPath = File.ReadAllText(@".\Config\Status1.txt");
                if (CheckPath.Contains("true", StringComparison.OrdinalIgnoreCase))
                {
                    int i = 1;
                    for (; ; )
                    {
                        Util.AutoCollect();
                        i++;
                        if (i > 4)
                            break;
                    }
                }
                else if (Check2Path.Contains("true", StringComparison.OrdinalIgnoreCase))
                {
                    Util.AutoCraft();
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
