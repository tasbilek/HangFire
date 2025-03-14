namespace HangFire.API.Job.Abstractions;

public abstract class JobBase
{
    public Guid ProcessId { get; set; } = Guid.NewGuid();
    public string ProcessName { get; set; } = string.Empty;
    public abstract Task Execute();
}
