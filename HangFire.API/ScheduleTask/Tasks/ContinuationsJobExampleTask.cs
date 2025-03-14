using HangFire.API.Job.Abstractions;
using HangFire.API.ScheduleTask.Enum;

namespace HangFire.API.ScheduleTask.Tasks;

public class ContinuationsJobExampleTask : JobBase
{
    public ContinuationsJobExampleTask()
    {
        ProcessName = ScheduleTaskType.ContinuationsJobExample.ToString();
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