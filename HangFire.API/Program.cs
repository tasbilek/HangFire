using Hangfire;
using Hangfire.MemoryStorage;
using HangFire.API.Job.Service;
using HangFire.API.ScheduleTask.Base;
using HangFire.API.ScheduleTask.Enum;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddHangfire(cfg => cfg.UseMemoryStorage());
builder.Services.AddHangfireServer();

builder.Services.AddSingleton<IScheduleTaskFactory,ScheduleTaskFactory>();

var app = builder.Build();

app.UseHangfireDashboard();

app.MapGet("/FireAndForgetJobTrigger", (IScheduleTaskFactory scheduleTaskFactory, int scheduleTaskType) => 
{
    var job = scheduleTaskFactory.CreateTask((ScheduleTaskType)scheduleTaskType);
    FireAndForgetJobService fireAndForgetJobService = new();
    var response = fireAndForgetJobService.Task(job);
    return response;
});

app.MapGet("/DelayedJobTrigger", (IScheduleTaskFactory scheduleTaskFactory, int scheduleTaskType, int delayMinute) => 
{
    var job = scheduleTaskFactory.CreateTask((ScheduleTaskType)scheduleTaskType);
    DelayedJobService delayedJobService = new(TimeSpan.FromMinutes(delayMinute));
    var response = delayedJobService.Task(job);
    return response;
});

app.MapGet("/RecurringJobTrigger", (IScheduleTaskFactory scheduleTaskFactory, int scheduleTaskType, string cron) => 
{
    var job = scheduleTaskFactory.CreateTask((ScheduleTaskType)scheduleTaskType);
    RecurringJobService recurringJobService = new(cron);
    var response = recurringJobService.Task(job);
    return response;
});

app.MapGet("/ContinuationsJobTrigger", (IScheduleTaskFactory scheduleTaskFactory, int scheduleTaskType, string parentId) => 
{
    var job = scheduleTaskFactory.CreateTask((ScheduleTaskType)scheduleTaskType);
    ContinuationsJobService continuationsJobService = new(parentId);
    var response = continuationsJobService.Task(job);
    return response;
});

if(app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.Run();
