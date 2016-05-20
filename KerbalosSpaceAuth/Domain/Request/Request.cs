using System;

namespace Domain.Request
{
    public abstract class Request
    {
        public string ClientName { get; set; }

        public Guid ClientId { get; set; }

        public Guid RequestId { get; set; }
    }
}