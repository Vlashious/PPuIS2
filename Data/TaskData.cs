using System;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class TaskData
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        public bool IsFinished { get; set; } = false;
    }
}