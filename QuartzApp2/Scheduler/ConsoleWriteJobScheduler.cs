using Quartz;
using Quartz.Impl;
using QuartzApp2.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzApp2.Scheduler
{
    public static class ConsoleWriteJobScheduler
    {
        public static void Start() { 
        IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
        scheduler.Start();
        IJobDetail job = JobBuilder.Create<ConsoleWriterJob>().Build();
        ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("TreiggerForConsoleWriter", "GroupCount")
            .StartNow()
            .WithSimpleSchedule(x => x
            .WithIntervalInSeconds(10)
            .RepeatForever())
            .Build();
        scheduler.ScheduleJob(job, trigger);
    }
    }
}
