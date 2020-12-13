using System;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    class TaskData
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        public bool IsFinished { get; set; } = false;
    }
}