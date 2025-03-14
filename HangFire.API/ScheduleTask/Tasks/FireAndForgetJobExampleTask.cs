using HangFire.API.Job.Abstractions;
using HangFire.API.ScheduleTask.Enum;

namespace HangFire.API.ScheduleTask.Tasks;

public class FireAndForgetJobExampleTask : JobBase
{
    public FireAndForgetJobExampleTask()
    {
        ProcessName = ScheduleTaskType.FireAndForgetJobExample.ToString();
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
