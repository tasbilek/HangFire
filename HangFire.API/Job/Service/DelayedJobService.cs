using Hangfire;
using HangFire.API.Job.Abstractions;
using HangFire.API.Job.Domain;

namespace HangFire.API.Job.Service;

public class DelayedJobService : JobServiceBase
{
    private readonly TimeSpan delayTime = TimeSpan.FromMinutes(5);

    public DelayedJobService()
    {
    }

    public DelayedJobService(TimeSpan delayTime)
    {
        this.delayTime = delayTime;
    }
    
    public override TaskResult<string> Task(JobBase job)
    {
        TaskResult<string> response = new();
        try
        {
            response.Data = BackgroundJob.Schedule(()=>job.Execute(), delayTime);
            response.IsSuccess = true;
        }
        catch (Exception ex)
        {
            response.IsSuccess = false;
            response.Message = ex.Message;
        }
        return response;
    }
}