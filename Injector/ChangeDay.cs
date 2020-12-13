using System;
using System.Collections.Generic;
using Data;
using Service;

namespace Injector
{
    class ChangeDay : ITasksCommand
    {
        public void Show(object obj)
        {

        }

        public List<Task> GetTaskList(DateTime date)
        {
            return null;
        }
    }
}