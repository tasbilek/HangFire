using HangFire.API.Job.Abstractions;
using HangFire.API.ScheduleTask.Enum;
using HangFire.API.ScheduleTask.Tasks;

namespace HangFire.API.ScheduleTask.Base;

public class ScheduleTaskFactory : IScheduleTaskFactory
{
    public JobBase CreateTask(ScheduleTaskType scheduleTaskType)
    {
        return scheduleTaskType switch
        {
            ScheduleTaskType.FireAndForgetJobExample => new FireAndForgetJobExampleTask(),
            ScheduleTaskType.DelayedJobExample => new DelayedJobExampleTask(),
            ScheduleTaskType.RecurringJobExample => new RecurringJobExampleTask(),
            ScheduleTaskType.ContinuationsJobExample => new ContinuationsJobExampleTask(),
            _ => throw new InvalidOperationException($"{scheduleTaskType} not implemented")
        };
    }
}