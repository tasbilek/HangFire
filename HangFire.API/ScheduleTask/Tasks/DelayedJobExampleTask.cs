using HangFire.API.Job.Abstractions;
using HangFire.API.ScheduleTask.Enum;

namespace HangFire.API.ScheduleTask.Tasks;

public class DelayedJobExampleTask : JobBase
{
    public DelayedJobExampleTask()
    {
        ProcessName = ScheduleTaskType.DelayedJobExample.ToString();
    }
    public override Task Execute()
    {
        try
        {
            ///business logic
        }
        catch (Exception ex)
        {
            ///logging with ex
        }
        return Task.CompletedTask;
    }
}
