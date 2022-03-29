

using Producer.Models;

namespace Producer.Handlers
{
    public class RequestCommand
    {
        public string Topic { get; set; }
        public Person Person { get; set; }

        public RequestCommand() { }
    }
}
