using System.Collections.Generic;
using Data;
using Service;

namespace Injector
{
    class TasksList : ICommand
    {
        public TaskRepository TaskRepository { get; private set; }
        public ITasksCommand TaskCommand { get; private set; }

        public void Show()
        {

        }

        public void Cancel()
        {

        }

        public List<Task> GetTaskList()
        {
            return null;
        }

        public void SelectCommand()
        {

        }

        public void RunCommand()
        {

        }
    }
}