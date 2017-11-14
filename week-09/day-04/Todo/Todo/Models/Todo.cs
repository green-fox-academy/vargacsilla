using System;

namespace TodoApp.Models
{
    public class Todo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }       
    }
}