using QuartzApp2.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriteJobScheduler.Start();
        }
    }
}
