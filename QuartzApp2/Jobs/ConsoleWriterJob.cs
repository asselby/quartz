using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzApp2.Jobs
{
    public class ConsoleWriterJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("hello");
        }
    }
}
