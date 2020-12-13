using Data;
using Service;

namespace Injector
{
    class DeleteTask : ITaskCommand
    {
        public TaskRepository TaskRepository { get; set; }

        public void Show(Task task)
        {

        }
    }
}