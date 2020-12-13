using Data;
using Injector;

namespace Service
{
    interface ITaskCommand
    {
        TaskRepository TaskRepository { get; set; }
        void Show(Task task);
    }
}