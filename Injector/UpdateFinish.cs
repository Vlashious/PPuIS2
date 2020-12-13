using Data;
using Service;

namespace Injector
{
    class UpdateFinish : ITaskCommand
    {
        public TaskRepository TaskRepository { get; set; }

        public void Show(Task task)
        {

        }
    }
}