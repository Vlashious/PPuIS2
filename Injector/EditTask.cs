using Data;
using Service;

namespace Injector
{
    class EditTask : ITaskCommand
    {
        public TaskRepository TaskRepository { get; set; }

        public void Show(Task task)
        {

        }

        public void Cancel()
        {

        }
    }
}