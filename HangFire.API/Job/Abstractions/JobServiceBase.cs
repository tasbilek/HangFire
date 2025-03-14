using HangFire.API.Job.Domain;

namespace HangFire.API.Job.Abstractions;

public abstract class JobServiceBase
{
    public abstract TaskResult<string> Task(JobBase baseJob);
}