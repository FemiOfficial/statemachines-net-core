using System;

namespace src.web.api.infrastructure.Persistence.Entities
{
    public class Task
    {
        public long Id { get; set; }
        public long PredecessorId { get; set; }
        public  string Response { get; set; }
        public DateTime DateInitiated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string State { get; set; }
    }
}