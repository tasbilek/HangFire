using Hangfire;
using HangFire.API.Job.Abstractions;
using HangFire.API.Job.Domain;

namespace HangFire.API.Job.Service;

public class RecurringJobService : JobServiceBase
{
    private readonly string cron = Cron.Daily();

    public RecurringJobService()
    {
    }

    public RecurringJobService(string cron)
    {
        this.cron = cron;
    }

    public override TaskResult<string> Task(JobBase job)
    {
        TaskResult<string> response = new();

        try
        {
            RecurringJob.AddOrUpdate(job.ProcessName, () => job.Execute(), cron);
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