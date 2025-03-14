using Hangfire;
using HangFire.API.Job.Abstractions;
using HangFire.API.Job.Domain;

namespace HangFire.API.Job.Service;

public class ContinuationsJobService : JobServiceBase
{
    private readonly string parentId;

    public ContinuationsJobService(string parentId)
    {
        this.parentId = parentId;
    }
    
    public override TaskResult<string> Task(JobBase job)
    {
        TaskResult<string> response = new();
        try
        {
            response.Data = BackgroundJob.ContinueJobWith(parentId, () => job.Execute());
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
