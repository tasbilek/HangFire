namespace HangFire.API.Job.Domain;

public class TaskResult<T>
{
    public string Message { get; set; } = string.Empty;
    public bool IsSuccess { get; set; }
    public T Data { get; set; } = default!;
}