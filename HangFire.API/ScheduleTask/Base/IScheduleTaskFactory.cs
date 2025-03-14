using HangFire.API.Job.Abstractions;
using HangFire.API.ScheduleTask.Enum;

namespace HangFire.API.ScheduleTask.Base;

public interface IScheduleTaskFactory
{
    JobBase CreateTask(ScheduleTaskType scheduleTaskType);
}
