using System;

namespace Data
{
    class Task
    {
        private int id;
        private string task;
        private DateTime date;
        private bool isFinished;

        public Task(string name, DateTime date)
        {
            task = name;
            this.date = date;
        }
    }
}