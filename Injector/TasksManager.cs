using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Data;

namespace Injector
{
    class TasksManager
    {
        public List<TaskData> Tasks { get; private set; } = new();

        public void LoadTasks()
        {
            var json = File.ReadAllText("tasks.json");
            Tasks = JsonSerializer.Deserialize<List<TaskData>>(json);
        }

        public void SaveTasks()
        {
            var json = JsonSerializer.Serialize(Tasks, new JsonSerializerOptions()
            {
                WriteIndented = true
            });
            File.WriteAllText("tasks.json", json);
        }

        public void AddTask(TaskData task)
        {
            Tasks.Add(task);
            SaveTasks();
        }
    }
}