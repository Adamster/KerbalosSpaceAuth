using System;

namespace Domain.Response
{
    public class Response
    {
        public Guid ClientId { get; set; }
        public DateTime Timestamp { get; set; }
        public string ServiceName { get; set; }
    }
}